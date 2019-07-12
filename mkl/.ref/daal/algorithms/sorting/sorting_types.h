/* file: sorting_types.h */
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
//  Definition of common types of sorting.
//--
*/

#ifndef __SORTING_TYPES_H__
#define __SORTING_TYPES_H__

#include "data_management/data/homogen_numeric_table.h"

namespace daal
{
namespace algorithms
{
/**
 * @defgroup sorting Sorting
 * \copydoc daal::algorithms::sorting
 * @ingroup analysis
 * @{
 */
/**
 * \brief Contains classes to run the sorting algorithms
 */
namespace sorting
{
/**
 * <a name="DAAL-ENUM-ALGORITHMS__SORTING__METHOD"></a>
 * Available methods for sorting computation
 */
enum Method
{
    defaultDense = 0      /*!< Default: radix method for sorting a data set */
};

/**
 * <a name="DAAL-ENUM-ALGORITHMS__SORTING__INPUTID"></a>
 * Available identifiers of input objects for the sorting algorithm
 */
enum InputId
{
    data,             /*!< %Input data table */
    lastInputId = data
};

/**
 * <a name="DAAL-ENUM-ALGORITHMS__SORTING__RESULTID"></a>
 * Available identifiers of results of the sorting algorithm
 */
enum ResultId
{
    sortedData,        /*!< observation sorting results */
    lastResultId = sortedData
};

/**
 * \brief Contains version 1.0 of Intel(R) Data Analytics Acceleration Library (Intel(R) DAAL) interface.
 */
namespace interface1
{
/**
 * <a name="DAAL-CLASS-ALGORITHMS__SORTING__INPUT"></a>
 * \brief %Input objects for the sorting algorithm
 */
class DAAL_EXPORT Input : public daal::algorithms::Input
{
public:
    Input();
    Input(const Input& other);

    virtual ~Input() {}

    /**
     * Returns an input object for the sorting algorithm
     * \param[in] id    Identifier of the %input object
     * \return          %Input object that corresponds to the given identifier
     */
    data_management::NumericTablePtr get(InputId id) const;

    /**
     * Sets the input object of the sorting algorithm
     * \param[in] id    Identifier of the %input object
     * \param[in] ptr   Pointer to the input object
     */
    void set(InputId id, const data_management::NumericTablePtr &ptr);

    /**
     * Check the correctness of the %Input object
     * \param[in] method    Algorithm computation method
     * \param[in] par       Pointer to the parameters of the algorithm
     */
    virtual services::Status check(const Parameter *par, int method) const DAAL_C11_OVERRIDE;
};

/**
 * <a name="DAAL-CLASS-ALGORITHMS__SORTING__RESULT"></a>
 * \brief Provides methods to access final results obtained with the compute() method of the
 *        sorting algorithm in the batch processing mode
 */
class DAAL_EXPORT Result : public daal::algorithms::Result
{
public:
    DECLARE_SERIALIZABLE_CAST(Result);
    Result();

    virtual ~Result() {};

    /**
     * Allocates memory to store final results of the sorting algorithms
     * \param[in] input     Input objects for the sorting algorithm
     * \param[in] method    Algorithm computation method
     */
    template <typename algorithmFPType>
    DAAL_EXPORT services::Status allocate(const daal::algorithms::Input *input, const int method);

    /**
     * Returns the final result of the sorting algorithm
     * \param[in] id   Identifier of the final result, \ref ResultId
     * \return         Final result that corresponds to the given identifier
     */
    data_management::NumericTablePtr get(ResultId id) const;

    /**
     * Sets the Result object of the sorting algorithm
     * \param[in] id        Identifier of the Result object
     * \param[in] value     Pointer to the Result object
     */
    void set(ResultId id, const data_management::NumericTablePtr &value);

    /**
     * Checks the correctness of the Result object
     * \param[in] in     Pointer to the object
     * \param[in] par     %Parameter of algorithm
     * \param[in] method Algorithm computation method
     */
    virtual services::Status check(const daal::algorithms::Input *in, const Parameter *par, int method) const DAAL_C11_OVERRIDE;

protected:
    /** \private */
    template<typename Archive, bool onDeserialize>
    services::Status serialImpl(Archive *arch)
    {
        return daal::algorithms::Result::serialImpl<Archive, onDeserialize>(arch);
    }
};
typedef services::SharedPtr<Result> ResultPtr;

/** @} */
} // namespace interface1
using interface1::Input;
using interface1::Result;
using interface1::ResultPtr;

} // namespace daal::algorithms::sorting
} // namespace daal::algorithms
} // namespace daal
#endif
