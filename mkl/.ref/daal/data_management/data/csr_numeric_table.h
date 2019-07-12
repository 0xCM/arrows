/* file: csr_numeric_table.h */
/*******************************************************************************
* Copyright 2014-2018 Intel Corporation.
*
* This software and the related documents are Intel copyrighted  materials,  and
* your use of  them is  governed by the  express license  under which  they were
* provided to you (License).  Unless the License provides otherwise, you may not
* use, modify, copy, publish, distribute,  disclose or transmit this software or
* the related documents without Intel's prior written permission.
*
* This software and the related documents  are provided as  is,  with no express
* or implied  warranties,  other  than those  that are  expressly stated  in the
* License.
*******************************************************************************/

/*
//++
//  Implementation of a compressed sparse row (CSR) numeric table.
//--
*/

#ifndef __CSR_NUMERIC_TABLE_H__
#define __CSR_NUMERIC_TABLE_H__

#include "services/base.h"
#include "data_management/data/numeric_table.h"
#include "data_management/data/data_serialize.h"
#include "data_management/data/internal/conversion.h"

namespace daal
{
namespace data_management
{

namespace interface1
{
/**
 * @ingroup numeric_tables
 * @{
 */
/**
 *  <a name="DAAL-CLASS-DATA_MANAGEMENT__CSRBLOCKDESCRIPTOR"></a>
 *  \brief %Base class that manages buffer memory for read/write operations required by CSR numeric tables.
 */
template<typename DataType = DAAL_DATA_TYPE>
class DAAL_EXPORT CSRBlockDescriptor
{
public:
    /** \private */
    CSRBlockDescriptor();

    /** \private */
    ~CSRBlockDescriptor() { freeValuesBuffer(); freeRowsBuffer(); }

    /**
     *  Gets a pointer to the buffer
     *  \return Pointer to the block
     */
    inline DataType *getBlockValuesPtr() const
    {
        if(_rawPtr)
        {
            return (DataType *)_rawPtr;
        }
        return _values_ptr.get();
    }

    inline size_t *getBlockColumnIndicesPtr() const { return _cols_ptr.get(); }
    inline size_t *getBlockRowIndicesPtr() const { return _rows_ptr.get(); }

    /**
     *  Gets a pointer to the buffer
     *  \return Pointer to the block
     */
    inline services::SharedPtr<DataType> getBlockValuesSharedPtr() const
    {
        if(_rawPtr)
        {
            return services::SharedPtr<DataType>(services::reinterpretPointerCast<DataType, byte>(*_pPtr), (DataType *)_rawPtr);
        }
        return _values_ptr;
    }

    inline services::SharedPtr<size_t> getBlockColumnIndicesSharedPtr() const { return _cols_ptr; }
    inline services::SharedPtr<size_t> getBlockRowIndicesSharedPtr() const { return _rows_ptr; }

    /**
     *  Returns the number of columns in the block
     *  \return Number of columns
     */
    inline size_t getNumberOfColumns() const { return _ncols; }

    /**
     *  Returns the number of rows in the block
     *  \return Number of rows
     */
    inline size_t getNumberOfRows() const { return _nrows; }

    /**
     *  Returns number of elements in values array.
     *  \return Number of elements in values array.
     */
    inline size_t getDataSize() const
    {
        return ((_nrows > 0) ? _rows_ptr.get()[_nrows] - _rows_ptr.get()[0] : 0);
    }
public:
    inline void setValuesPtr( DataType *ptr, size_t nValues )
    {
        _values_ptr = services::SharedPtr<DataType>(ptr, services::EmptyDeleter());
        _nvalues    = nValues;
    }

    inline void setColumnIndicesPtr( size_t *ptr, size_t nValues )
    {
        _cols_ptr   = services::SharedPtr<size_t>(ptr, services::EmptyDeleter());
        _nvalues    = nValues;
    }

    /**
     *  \param[in] ptr      Pointer to the buffer
     *  \param[in] nRows    Number of rows
     */
    inline void setRowIndicesPtr( size_t *ptr, size_t nRows )
    {
        _rows_ptr   = services::SharedPtr<size_t>(ptr, services::EmptyDeleter());
        _nrows = nRows;
    }

    inline void setValuesPtr( services::SharedPtr<DataType> ptr, size_t nValues )
    {
        _values_ptr = ptr;
        _nvalues    = nValues;
    }

    inline void setValuesPtr( services::SharedPtr<byte> *pPtr, byte* rawPtr, size_t nValues)
    {
        _pPtr = pPtr;
        _rawPtr = rawPtr;
        _nvalues = nValues;
    }

    inline void setColumnIndicesPtr( services::SharedPtr<size_t> ptr, size_t nValues )
    {
        _cols_ptr   = ptr;
        _nvalues    = nValues;
    }

    /**
     *  \param[in] ptr      Pointer to the buffer
     *  \param[in] nRows    Number of rows
     */
    inline void setRowIndicesPtr( services::SharedPtr<size_t> ptr, size_t nRows )
    {
        _rows_ptr = ptr;
        _nrows = nRows;
    }

    /**
     * Reset internal values and pointers to zero values
     */
    inline void reset()
    {
        _ncols = 0;
        _rowsOffset = 0;
        _rwFlag = 0;
        _pPtr = NULL;
        _rawPtr = NULL;
    }

    /**
     *  \param[in] nValues  Number of values
     */
    inline bool resizeValuesBuffer( size_t nValues )
    {
        size_t newSize = nValues * sizeof(DataType);
        if ( newSize > _values_capacity )
        {
            freeValuesBuffer();
            _values_buffer = services::SharedPtr<DataType>((DataType *)daal::services::daal_malloc(newSize), services::ServiceDeleter()) ;
            if ( _values_buffer )
            {
                _values_capacity = newSize;
            }
            else
            {
                return false;
            }
        }

        _values_ptr = _values_buffer;

        return true;
    }

    /**
     *  \param[in] nRows    Number of rows
     */
    inline bool resizeRowsBuffer( size_t nRows )
    {
        _nrows = nRows;
        size_t newSize = (nRows + 1) * sizeof(size_t);
        if ( newSize > _rows_capacity )
        {
            freeRowsBuffer();
            _rows_buffer = services::SharedPtr<size_t>((size_t *)daal::services::daal_malloc(newSize), services::ServiceDeleter()) ;
            if ( _rows_buffer )
            {
                _rows_capacity = newSize;
            }
            else
            {
                return false;
            }

        }

        _rows_ptr = _rows_buffer;

        return true;
    }

    inline void setDetails( size_t nColumns, size_t rowIdx, int rwFlag )
    {
        _ncols      = nColumns;
        _rowsOffset = rowIdx;
        _rwFlag     = rwFlag;
    }

    inline size_t getRowsOffset() const { return _rowsOffset; }
    inline size_t getRWFlag() const { return _rwFlag; }

protected:
    /**
     *  Frees the values buffer
     */
    void freeValuesBuffer()
    {
        if(_values_buffer)
        {
            _values_buffer = services::SharedPtr<DataType>();
        }
        _values_capacity = 0;
    }

    /**
     *  Frees the rows buffer
     */
    void freeRowsBuffer()
    {
        _rows_buffer = services::SharedPtr<size_t>();
        _rows_capacity = 0;
    }

private:
    services::SharedPtr<DataType> _values_ptr;
    services::SharedPtr<size_t> _cols_ptr;
    services::SharedPtr<size_t> _rows_ptr;
    size_t    _nrows;
    size_t    _ncols;
    size_t    _nvalues;

    size_t _rowsOffset;
    int    _rwFlag;

    services::SharedPtr<DataType> _values_buffer; /*<! Pointer to the buffer */
    size_t _values_capacity; /*<! Buffer size in bytes */

    services::SharedPtr<size_t> _rows_buffer; /*<! Pointer to the buffer */
    size_t _rows_capacity; /*<! Buffer size in bytes */

    services::SharedPtr<byte> *_pPtr;
    byte *_rawPtr;
};

/**
 *  <a name="DAAL-CLASS-DATA_MANAGEMENT__CSRNUMERICTABLEIFACE"></a>
 *  \brief Abstract class that defines the interface of CSR numeric tables
 */
class CSRNumericTableIface
{
public:
    /**
     * <a name="DAAL-ENUM-DATA_MANAGEMENT__CSRINDEXING"></a>
     * \brief Enumeration to specify the indexing scheme for access to data in the CSR layout
     */
    enum CSRIndexing
    {
        zeroBased = 0, /*!< 0-based indexing */
        oneBased  = 1  /*!< 1-based indexing */
    };

public:

    virtual ~CSRNumericTableIface() {}

    /**
     *  Returns number of elements in values array.
     *
     *  \return Number of elements in values array.
     */
    virtual size_t getDataSize() = 0;
    /**
     *  Gets a block of feature vectors in the CSR layout.
     *
     *  \param[in] vector_idx       Index of the first row to include into the block.
     *  \param[in] vector_num       Number of rows in the block.
     *  \param[in] rwflag           Flag specifying read/write access to the block of feature vectors.
     *  \param[out] block           The block of feature values.
     *
     *  \return Actual number of feature vectors returned by the method.
     */
    virtual services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<double> &block) = 0;

    /**
     *  Gets a block of feature vectors in the CSR layout.
     *
     *  \param[in] vector_idx       Index of the first row to include into the block.
     *  \param[in] vector_num       Number of rows in the block.
     *  \param[in] rwflag           Flag specifying read/write access to the block of feature vectors.
     *  \param[out] block           The block of feature values.
     *
     *  \return Actual number of feature vectors returned by the method.
     */
    virtual services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<float> &block) = 0;

    /**
     *  Gets a block of feature vectors in the CSR layout.
     *
     *  \param[in] vector_idx       Index of the first row to include into the block.
     *  \param[in] vector_num       Number of rows in the block.
     *  \param[in] rwflag           Flag specifying read/write access to the block of feature vectors.
     *  \param[out] block           The block of feature values.
     *
     *  \return Actual number of feature vectors returned by the method.
     */
    virtual services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<int> &block) = 0;

    /**
     *  Releases a block of feature vectors in the CSR layout.
     *  \param[in] block           The block of feature values.
     */
    virtual services::Status releaseSparseBlock(CSRBlockDescriptor<double> &block) = 0;

    /**
     *  Releases a block of feature vectors in the CSR layout.
     *  \param[in] block           The block of feature values.
     */
    virtual services::Status releaseSparseBlock(CSRBlockDescriptor<float> &block) = 0;

    /**
     *  Releases a block of feature vectors in the CSR layout.
     *  \param[in] block           The block of feature values.
     */
    virtual services::Status releaseSparseBlock(CSRBlockDescriptor<int> &block) = 0;
};

/**
 *  <a name="DAAL-CLASS-DATA_MANAGEMENT__CSRNUMERICTABLE"></a>
 *  \brief Class that provides methods to access data stored in the CSR layout.
 */
class DAAL_EXPORT CSRNumericTable : public NumericTable, public CSRNumericTableIface
{
public:
    DECLARE_SERIALIZABLE_TAG();
    DECLARE_SERIALIZABLE_IMPL();

    DAAL_CAST_OPERATOR(CSRNumericTable)
    /**
     *  Constructor for an empty CSR Numeric Table
     *  \DAAL_DEPRECATED_USE{ CSRNumericTable::create }
     */
    CSRNumericTable(): NumericTable(0, 0, DictionaryIface::equal), _indexing(oneBased)
    {
        _layout = csrArray;
        this->_status |= setArrays<double>( 0, 0, 0 ); //data type doesn't matter
    }

    /**
     *  Constructor for a Numeric Table with user-allocated memory
     *  \tparam   DataType        Type of values in the Numeric Table
     *  \param[in]    ptr         Array of values in the CSR layout. Let ptr_size denote the size of an array ptr
     *  \param[in]    colIndices  Array of column indices in the CSR layout. Values of indices are determined by the index base
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout. Size of the array is nrow+1. The first element is 0/1
     *                            in zero-/one-based indexing. The last element is ptr_size+0/1 in zero-/one-based indexing
     *  \param[in]    nColumns    Number of columns in the corresponding dense table
     *  \param[in]    nRows       Number of rows in the corresponding dense table
     *  \param[in]    indexing    Indexing scheme used to access data in the CSR layout
     *  \note Present version of Intel(R) Data Analytics Acceleration Library supports 1-based indexing only
     *  \DAAL_DEPRECATED_USE{ CSRNumericTable::create }
     */
    template<typename DataType>
    CSRNumericTable( DataType *const ptr, size_t *colIndices = 0, size_t *rowOffsets = 0,
                     size_t nColumns = 0, size_t nRows = 0, CSRIndexing indexing = oneBased ):
        NumericTable(nColumns, nRows, DictionaryIface::equal), _indexing(indexing)
    {
        _layout = csrArray;
        this->_status |= setArrays<DataType>(ptr, colIndices, rowOffsets);

        _defaultFeature.setType<DataType>();
        this->_status |= _ddict->setAllFeatures( _defaultFeature );
    }


    /**
     *  Constructs CSR numeric table with user-allocated memory
     *  \tparam   DataType        Type of values in the numeric table
     *  \param[in]    ptr         Array of values in the CSR layout. Let ptr_size denote the size of an array ptr
     *  \param[in]    colIndices  Array of column indices in the CSR layout. Values of indices are determined by the index base
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout. Size of the array is nrow+1. The first element is 0/1
     *                            in zero-/one-based indexing. The last element is ptr_size+0/1 in zero-/one-based indexing
     *  \param[in]    nColumns    Number of columns in the corresponding dense table
     *  \param[in]    nRows       Number of rows in the corresponding dense table
     *  \param[in]    indexing    Indexing scheme used to access data in the CSR layout
     *  \param[out]   stat        Status of the numeric table construction
     *  \return CSR numeric table with user-allocated memory
     *  \note Present version of Intel(R) Data Analytics Acceleration Library supports 1-based indexing only
     */
    template<typename DataType>
    static services::SharedPtr<CSRNumericTable> create(DataType *const ptr, size_t *colIndices = 0, size_t *rowOffsets = 0,
                                                       size_t nColumns = 0, size_t nRows = 0, CSRIndexing indexing = oneBased,
                                                       services::Status *stat = NULL)
    {
        return create<DataType>(services::SharedPtr<DataType>(ptr, services::EmptyDeleter()),
                                services::SharedPtr<size_t>(colIndices, services::EmptyDeleter()),
                                services::SharedPtr<size_t>(rowOffsets, services::EmptyDeleter()),
                                nColumns, nRows, indexing, stat);
    }

    /**
     *  Constructor for a Numeric Table with user-allocated memory
     *  \tparam   DataType        Type of values in the Numeric Table
     *  \param[in]    ptr         Array of values in the CSR layout. Let ptr_size denote the size of an array ptr
     *  \param[in]    colIndices  Array of column indices in the CSR layout. Values of indices are determined by the index base
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout. Size of the array is nrow+1. The first element is 0/1
     *                            in zero-/one-based indexing. The last element is ptr_size+0/1 in zero-/one-based indexing
     *  \param[in]    nColumns    Number of columns in the corresponding dense table
     *  \param[in]    nRows       Number of rows in the corresponding dense table
     *  \param[in]    indexing    Indexing scheme used to access data in the CSR layout
     *  \note Present version of Intel(R) Data Analytics Acceleration Library supports 1-based indexing only
     *  \DAAL_DEPRECATED_USE{ CSRNumericTable::create }
     */
    template<typename DataType>
    CSRNumericTable( const services::SharedPtr<DataType>& ptr, const services::SharedPtr<size_t>& colIndices, const services::SharedPtr<size_t>& rowOffsets,
                     size_t nColumns, size_t nRows, CSRIndexing indexing = oneBased ):
        NumericTable(nColumns, nRows, DictionaryIface::equal), _indexing(indexing)
    {
        _layout = csrArray;
        this->_status |= setArrays<DataType>(ptr, colIndices, rowOffsets);

        _defaultFeature.setType<DataType>();
        this->_status |= _ddict->setAllFeatures( _defaultFeature );
    }

    /**
     *  Constructs CSR numeric table with user-allocated memory
     *  \tparam   DataType        Type of values in the Numeric Table
     *  \param[in]    ptr         Array of values in the CSR layout. Let ptr_size denote the size of an array ptr
     *  \param[in]    colIndices  Array of column indices in the CSR layout. Values of indices are determined by the index base
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout. Size of the array is nrow+1. The first element is 0/1
     *                            in zero-/one-based indexing. The last element is ptr_size+0/1 in zero-/one-based indexing
     *  \param[in]    nColumns    Number of columns in the corresponding dense table
     *  \param[in]    nRows       Number of rows in the corresponding dense table
     *  \param[in]    indexing    Indexing scheme used to access data in the CSR layout
     *  \param[out]   stat        Status of the numeric table construction
     *  \return       CSR numeric table with user-allocated memory
     *  \note Present version of Intel(R) Data Analytics Acceleration Library supports 1-based indexing only
     */
    template<typename DataType>
    static services::SharedPtr<CSRNumericTable> create(const services::SharedPtr<DataType>& ptr,
                                                       const services::SharedPtr<size_t>& colIndices,
                                                       const services::SharedPtr<size_t>& rowOffsets,
                                                       size_t nColumns, size_t nRows, CSRIndexing indexing = oneBased,
                                                       services::Status *stat = NULL)
    {
        DAAL_DEFAULT_CREATE_IMPL_EX(CSRNumericTable, ptr, colIndices, rowOffsets, nColumns, nRows, indexing);
    }

    virtual ~CSRNumericTable()
    {
        freeDataMemoryImpl();
    }

    virtual services::Status resize(size_t nrows) DAAL_C11_OVERRIDE
    {
        return setNumberOfRowsImpl(nrows);
    }

    /**
     *  Returns  pointers to a data set stored in the CSR layout
     *  \param[out]    ptr         Array of values in the CSR layout
     *  \param[out]    colIndices  Array of column indices in the CSR layout
     *  \param[out]    rowOffsets  Array of row indices in the CSR layout
     */
    template<typename DataType>
    services::Status getArrays(DataType **ptr, size_t **colIndices, size_t **rowOffsets) const
    {
        if (ptr) { *ptr = (DataType*)_ptr.get(); }
        if (colIndices) { *colIndices = _colIndices.get(); }
        if (rowOffsets) { *rowOffsets = _rowOffsets.get(); }
        return services::Status();
    }

    /**
     *  Returns  pointers to a data set stored in the CSR layout
     *  \param[out]    ptr         Array of values in the CSR layout
     *  \param[out]    colIndices  Array of column indices in the CSR layout
     *  \param[out]    rowOffsets  Array of row indices in the CSR layout
     */
    template<typename DataType>
    services::Status getArrays(services::SharedPtr<DataType> &ptr, services::SharedPtr<size_t> &colIndices, services::SharedPtr<size_t> &rowOffsets) const
    {
        if(ptr) { *ptr = _ptr; }
        if (colIndices) { *colIndices = _colIndices; }
        if (rowOffsets) { *rowOffsets = _rowOffsets; }
        return services::Status();
    }

    /**
     *  Sets a pointer to a CSR data set
     *  \param[in]    ptr         Array of values in the CSR layout
     *  \param[in]    colIndices  Array of column indices in the CSR layout
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout
     *  \param[in]    indexing    The indexing scheme for access to data in the CSR layout
     */
    template<typename DataType>
    services::Status setArrays(DataType *const ptr, size_t *colIndices, size_t *rowOffsets, CSRIndexing indexing = oneBased)
    {
        freeDataMemoryImpl();

        //if( ptr == 0 || colIndices == 0 || rowOffsets == 0 ) return services::Status(services::ErrorEmptyCSRNumericTable);

        _ptr = services::SharedPtr<byte>((byte*)ptr, services::EmptyDeleter());
        _colIndices = services::SharedPtr<size_t>(colIndices, services::EmptyDeleter());
        _rowOffsets = services::SharedPtr<size_t>(rowOffsets, services::EmptyDeleter());
        _indexing = indexing;

        if( ptr != 0 && colIndices != 0 && rowOffsets != 0 ) { _memStatus  = userAllocated; }
        return services::Status();
    }

    /**
     *  Sets a pointer to a CSR data set
     *  \param[in]    ptr         Array of values in the CSR layout
     *  \param[in]    colIndices  Array of column indices in the CSR layout
     *  \param[in]    rowOffsets  Array of row indices in the CSR layout
     *  \param[in]    indexing    The indexing scheme for access to data in the CSR layout
     */
    template<typename DataType>
    services::Status setArrays(const services::SharedPtr<DataType>& ptr, const services::SharedPtr<size_t>& colIndices, const services::SharedPtr<size_t>& rowOffsets, CSRIndexing indexing = oneBased)
    {
        freeDataMemoryImpl();

        //if( ptr == 0 || colIndices == 0 || rowOffsets == 0 ) return services::Status(services::ErrorEmptyCSRNumericTable);

        _ptr = services::reinterpretPointerCast<byte, DataType>(ptr);
        _colIndices = colIndices;
        _rowOffsets = rowOffsets;
        _indexing = indexing;

        if( ptr && colIndices && rowOffsets ) { _memStatus  = userAllocated; }
        return services::Status();
    }

    services::Status getBlockOfRows(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, BlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
        return getTBlock<double>(vector_idx, vector_num, rwflag, block);
    }
    services::Status getBlockOfRows(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, BlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
        return getTBlock<float>(vector_idx, vector_num, rwflag, block);
    }
    services::Status getBlockOfRows(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, BlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
        return getTBlock<int>(vector_idx, vector_num, rwflag, block);
    }

    services::Status releaseBlockOfRows(BlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
         return releaseTBlock<double>(block);
    }
    services::Status releaseBlockOfRows(BlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
         return releaseTBlock<float>(block);
    }
    services::Status releaseBlockOfRows(BlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
         return releaseTBlock<int>(block);
    }

    services::Status getBlockOfColumnValues(size_t feature_idx, size_t vector_idx, size_t value_num,
                                ReadWriteMode rwflag, BlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
        return getTFeature<double>(feature_idx, vector_idx, value_num, rwflag, block);
    }
    services::Status getBlockOfColumnValues(size_t feature_idx, size_t vector_idx, size_t value_num,
                                ReadWriteMode rwflag, BlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
        return getTFeature<float>(feature_idx, vector_idx, value_num, rwflag, block);
    }
    services::Status getBlockOfColumnValues(size_t feature_idx, size_t vector_idx, size_t value_num,
                                ReadWriteMode rwflag, BlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
        return getTFeature<int>(feature_idx, vector_idx, value_num, rwflag, block);
    }

    services::Status releaseBlockOfColumnValues(BlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
         return releaseTFeature<double>(block);
    }
    services::Status releaseBlockOfColumnValues(BlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
         return releaseTFeature<float>(block);
    }
    services::Status releaseBlockOfColumnValues(BlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
         return releaseTFeature<int>(block);
    }


    services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
        return getSparseTBlock<double>(vector_idx, vector_num, rwflag, block);
    }
    services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
        return getSparseTBlock<float>(vector_idx, vector_num, rwflag, block);
    }
    services::Status getSparseBlock(size_t vector_idx, size_t vector_num, ReadWriteMode rwflag, CSRBlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
        return getSparseTBlock<int>(vector_idx, vector_num, rwflag, block);
    }

    services::Status releaseSparseBlock(CSRBlockDescriptor<double> &block) DAAL_C11_OVERRIDE
    {
        return releaseSparseTBlock<double>(block);
    }
    services::Status releaseSparseBlock(CSRBlockDescriptor<float> &block) DAAL_C11_OVERRIDE
    {
        return releaseSparseTBlock<float>(block);
    }
    services::Status releaseSparseBlock(CSRBlockDescriptor<int> &block) DAAL_C11_OVERRIDE
    {
        return releaseSparseTBlock<int>(block);
    }

    /**
     *  Allocates memory for a data set
     *  \param[in]    dataSize     Number of non-zero values
     *  \param[in]    type         Memory type
     */
    services::Status allocateDataMemory(size_t dataSize, daal::MemType type = daal::dram)
    {
        freeDataMemoryImpl();

        size_t nrow = getNumberOfRows();

        if( nrow == 0 )
            return services::Status(services::ErrorIncorrectNumberOfObservations);

        NumericTableFeature &f = (*_ddict)[0];

        _ptr        = services::SharedPtr<byte>  (   (byte*)daal::services::daal_malloc( dataSize   * f.typeSize     ), services::ServiceDeleter  ());
        _colIndices = services::SharedPtr<size_t>((size_t *)daal::services::daal_malloc( dataSize   * sizeof(size_t) ), services::ServiceDeleter());
        _rowOffsets = services::SharedPtr<size_t>((size_t *)daal::services::daal_malloc( (nrow + 1) * sizeof(size_t) ), services::ServiceDeleter());

        _memStatus = internallyAllocated;

        if( !_ptr || !_colIndices || !_rowOffsets )
        {
            freeDataMemoryImpl();
            return services::Status(services::ErrorMemoryAllocationFailed);
        }

        _rowOffsets.get()[0] = ((_indexing == oneBased) ? 1 : 0);
        return services::Status();
    }

    /**
     * Returns the indexing scheme for access to data in the CSR layout
     * \return  CSR layout indexing
     */
    CSRIndexing getCSRIndexing() const
    {
        return _indexing;
    }

    /**
     * \copydoc NumericTableIface::check
     */
    virtual services::Status check(const char *description, bool checkDataAllocation = true) const DAAL_C11_OVERRIDE
    {
        services::Status s;
        DAAL_CHECK_STATUS(s, data_management::NumericTable::check(description, checkDataAllocation));

        if( _indexing != oneBased )
        {
            return services::Status(services::Error::create(services::ErrorUnsupportedCSRIndexing, services::ArgumentName, description));
        }

        return services::Status();
    }

protected:
    NumericTableFeature _defaultFeature;
    CSRIndexing _indexing;

    services::SharedPtr<byte> _ptr;
    services::SharedPtr<size_t> _colIndices;
    services::SharedPtr<size_t> _rowOffsets;

    template<typename DataType>
    CSRNumericTable(const services::SharedPtr<DataType>& ptr, const services::SharedPtr<size_t>& colIndices, const services::SharedPtr<size_t>& rowOffsets,
                    size_t nColumns, size_t nRows, CSRIndexing indexing,
                    services::Status &st):
        NumericTable(nColumns, nRows, DictionaryIface::equal, st), _indexing(indexing)
    {
        _layout = csrArray;
        st |= setArrays<DataType>(ptr, colIndices, rowOffsets);

        _defaultFeature.setType<DataType>();
        st |= _ddict->setAllFeatures( _defaultFeature );
    }

    services::Status allocateDataMemoryImpl(daal::MemType type = daal::dram) DAAL_C11_OVERRIDE
    {
        return services::Status(services::ErrorMethodNotSupported);
    }

    void freeDataMemoryImpl() DAAL_C11_OVERRIDE
    {
        _ptr = services::SharedPtr<byte>();
        _colIndices = services::SharedPtr<size_t>();
        _rowOffsets = services::SharedPtr<size_t>();

        _memStatus  = notAllocated;
    }


    /** \private */
    template<typename Archive, bool onDeserialize>
    services::Status serialImpl( Archive *arch )
    {
        NumericTable::serialImpl<Archive, onDeserialize>( arch );

        size_t dataSize = 0;
        if( !onDeserialize )
        {
            dataSize = getDataSize();
        }
        arch->set( dataSize );

        if( onDeserialize )
        {
            allocateDataMemory( dataSize );
        }

        size_t nfeat = getNumberOfColumns();
        size_t nobs  = getNumberOfRows();

        if( nfeat > 0 )
        {
            NumericTableFeature &f = (*_ddict)[0];

            arch->set( (char *)_ptr.get(), dataSize * f.typeSize );
            arch->set( _colIndices.get(), dataSize );
            arch->set( _rowOffsets.get(), nobs + 1   );
        }

        return services::Status();
    }


public:
    size_t getDataSize() DAAL_C11_OVERRIDE
    {
        size_t nobs  = getNumberOfRows();
        if( nobs > 0)
        {
            return _rowOffsets.get()[nobs] - _rowOffsets.get()[0];
        }
        else
        {
            return 0;
        }
    }

protected:

    template <typename T>
    services::Status getTBlock(size_t idx, size_t nrows, int rwFlag, BlockDescriptor<T> &block)
    {
        size_t ncols = getNumberOfColumns();
        size_t nobs  = getNumberOfRows();
        block.setDetails( 0, idx, rwFlag );
        size_t* rowOffsets = _rowOffsets.get();

        if (idx >= nobs)
        {
            block.resizeBuffer( ncols, 0 );
            return services::Status();
        }

        NumericTableFeature &f = (*_ddict)[0];

        T* buffer;
        T* castingBuffer;
        T* location = (T*)(_ptr.get() + (rowOffsets[idx] - 1) * f.typeSize);

        if( features::internal::getIndexNumType<T>() == f.indexType )
        {
            castingBuffer = location;

            if( !block.resizeBuffer( ncols, nrows ) )
                return services::Status(services::ErrorMemoryAllocationFailed);
            buffer = block.getBlockPtr();
        }
        else
        {
            size_t sparseBlockSize = rowOffsets[idx + nrows] - rowOffsets[idx];

            if( !block.resizeBuffer( ncols, nrows, sparseBlockSize * sizeof(T) ) )
                return services::Status(services::ErrorMemoryAllocationFailed);
            buffer = block.getBlockPtr();

            castingBuffer = (T*)block.getAdditionalBufferPtr();

            internal::getVectorUpCast(f.indexType, internal::getConversionDataType<T>())
            ( sparseBlockSize, location, castingBuffer );
        }

        T *bufRowCursor       = castingBuffer;
        size_t *indicesCursor = _colIndices.get() + rowOffsets[idx] - 1;

        for( size_t i = 0; i < ncols * nrows; i++ ) { buffer[i] = (T)0; }

        for( size_t i = 0; i < nrows; i++ )
        {
            size_t sparseRowSize = rowOffsets[idx + i + 1] - rowOffsets[idx + i];

            for( size_t k = 0; k < sparseRowSize; k++ )
            {
                buffer[i * ncols + indicesCursor[k] - 1] = bufRowCursor[k];
            }

            bufRowCursor  += sparseRowSize;
            indicesCursor += sparseRowSize;
        }
        return services::Status();
    }

    template <typename T>
    services::Status releaseTBlock( BlockDescriptor<T> &block )
    {
        if (!(block.getRWFlag() & (int)writeOnly))
            block.reset();
        return services::Status();
    }

    template <typename T>
    services::Status getTFeature(size_t feat_idx, size_t idx, size_t nrows, int rwFlag, BlockDescriptor<T> &block)
    {
        size_t ncols = getNumberOfColumns();
        size_t nobs = getNumberOfRows();
        block.setDetails( feat_idx, idx, rwFlag );
        size_t* rowOffsets = _rowOffsets.get();

        if (idx >= nobs)
        {
            block.resizeBuffer( 1, 0 );
            return services::Status();
        }

        nrows = ( idx + nrows < nobs ) ? nrows : nobs - idx;

        if( !block.resizeBuffer( 1, nrows ) )
            return services::Status(services::ErrorMemoryAllocationFailed);

        NumericTableFeature &f = (*_ddict)[0];

        char   *rowCursor     = (char *)_ptr.get() + (rowOffsets[idx] - 1) * f.typeSize;
        size_t *indicesCursor = _colIndices.get() + (rowOffsets[idx] - 1);

        T* bufferPtr = block.getBlockPtr();

        for(size_t i = 0; i < nrows; i++)
        {
            bufferPtr[i] = (T)0;

            size_t sparseRowSize = rowOffsets[idx + i + 1] - rowOffsets[idx + i];

            for(size_t k = 0; k < sparseRowSize; k++)
            {
                if( indicesCursor[k] - 1 == feat_idx )
                {
                    internal::getVectorUpCast(f.indexType, internal::getConversionDataType<T>())
                    ( 1, rowCursor + k * f.typeSize, bufferPtr + i );
                }
            }

            rowCursor     += sparseRowSize * f.typeSize;
            indicesCursor += sparseRowSize;
        }
        return services::Status();
    }

    template <typename T>
    services::Status releaseTFeature( BlockDescriptor<T> &block )
    {
        if(block.getRWFlag() & (int)writeOnly)
            return services::Status();
        block.reset();
        return services::Status();
    }

    template <typename T>
    services::Status getSparseTBlock( size_t idx, size_t nrows, int rwFlag, CSRBlockDescriptor<T> &block )
    {
        size_t ncols = getNumberOfColumns();
        size_t nobs  = getNumberOfRows();
        block.setDetails( ncols, idx, rwFlag );
        size_t* rowOffsets = _rowOffsets.get();

        if (idx >= nobs)
        {
            block.resizeValuesBuffer( 0 );
            return services::Status();
        }

        nrows = ( idx + nrows < nobs ) ? nrows : nobs - idx;

        NumericTableFeature &f = (*_ddict)[0];


        size_t nValues = rowOffsets[idx + nrows] - rowOffsets[idx];

        if( features::internal::getIndexNumType<T>() == f.indexType )
        {
            block.setValuesPtr(&_ptr, _ptr.get() +(rowOffsets[idx] - 1) * f.typeSize, nValues);
        }
        else
        {
            if( !block.resizeValuesBuffer(nValues) ) { return  services::Status(); }

            services::SharedPtr<byte> location(_ptr, _ptr.get() +(rowOffsets[idx] - 1) * f.typeSize);
            internal::getVectorUpCast(f.indexType, internal::getConversionDataType<T>())
            ( nValues, location.get(), block.getBlockValuesPtr() );
        }

        services::SharedPtr<size_t> shiftedColumns(_colIndices, _colIndices.get() + (rowOffsets[idx] - 1));
        block.setColumnIndicesPtr( shiftedColumns, nValues );

        if( idx == 0 )
        {
            block.setRowIndicesPtr( _rowOffsets, nrows );
        }
        else
        {
            if( !block.resizeRowsBuffer(nrows) ) { return  services::Status(); }

            size_t *row_offsets = block.getBlockRowIndicesSharedPtr().get();

            for(size_t i = 0; i < nrows + 1; i++)
            {
                row_offsets[i] = rowOffsets[idx + i] - rowOffsets[idx] + 1;
            }
        }
        return services::Status();
    }

    template <typename T>
    services::Status releaseSparseTBlock(CSRBlockDescriptor<T> &block)
    {
        if (block.getRWFlag() & (int)writeOnly)
        {
            NumericTableFeature &f = (*_ddict)[0];
            if (f.indexType != features::internal::getIndexNumType<T>())
            {
                size_t nrows = block.getNumberOfRows();
                size_t idx   = block.getRowsOffset();
                size_t nValues = _rowOffsets.get()[idx + nrows] - _rowOffsets.get()[idx];

                services::SharedPtr<byte> ptr = services::reinterpretPointerCast<byte, T>(block.getBlockValuesSharedPtr());
                services::SharedPtr<byte> location = services::SharedPtr<byte>(ptr, _ptr.get() + (_rowOffsets.get()[idx] - 1) * f.typeSize);

                internal::getVectorDownCast(f.indexType, internal::getConversionDataType<T>())
                        (nValues, ptr.get(), location.get());
            }
        }
        block.reset();
        return services::Status();
    }

    virtual services::Status setNumberOfColumnsImpl(size_t ncol) DAAL_C11_OVERRIDE
    {
        _ddict->setNumberOfFeatures( ncol );
        _ddict->setAllFeatures( _defaultFeature );
        return services::Status();
    }

};
typedef services::SharedPtr<CSRNumericTableIface> CSRNumericTableIfacePtr;
typedef services::SharedPtr<CSRNumericTable> CSRNumericTablePtr;
/** @} */
} // namespace interface1
using interface1::CSRNumericTableIface;
using interface1::CSRNumericTableIfacePtr;
using interface1::CSRBlockDescriptor;
using interface1::CSRNumericTable;
using interface1::CSRNumericTablePtr;

}
} // namespace daal
#endif
