//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a blocked primal matrix of natural dimensions
    /// </summary>
    /// <typeparam name="M">The row count type</typeparam>
    /// <typeparam name="N">The column count type</typeparam>
    /// <typeparam name="T">The primal type</typeparam>
    public struct Matrix<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : unmanaged    
    {        
        T[] data;

        public static readonly Dim<M,N> Dim = default;        

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        static readonly int _RowCount = nati<M>();

        /// <summary>
        /// The number of columns in the structure
        /// </summary>
        static readonly int _ColCount = nati<N>();

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        static readonly int _RowLenth = _ColCount;

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        static readonly int _ColLength = _RowCount;

        /// <summary>
        /// The total number of allocated elements
        /// </summary>
        public static readonly int CellCount = _RowLenth * _ColLength;

        /// <summary>
        /// The Row dimension representative
        /// </summary>
        public static readonly M RowRep = default;

        /// <summary>
        /// The Column dimension representative
        /// </summary>
        public static readonly N ColRep = default;

        [MethodImpl(Inline)]
        public static bool operator == (Matrix<M,N,T> lhs, Matrix<M,N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Matrix<M,N,T> lhs, Matrix<M,N,T> rhs) 
            => !lhs.Equals(rhs);


        [MethodImpl(Inline)]
        public Matrix(T[] src)
        {
            require(src.Length >= CellCount);
            data = src;
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => _RowCount;
        }

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        public readonly int RowLength
        {
            [MethodImpl(Inline)]
            get => _RowLenth;
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => _ColCount;
        }

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        public readonly int ColLength
        {
            [MethodImpl(Inline)]
            get => _ColLength;
        }

        /// <summary>
        /// Provides access to the underlying data as a linear unblocked span
        /// </summary>
        public T[] Data
        {            
            [MethodImpl(Inline)]
            get => data;
        }


        [MethodImpl(Inline)]        
        public ref T Cell(int r, int c)
            => ref data[_RowLenth*r + c];

        public ref T this[int r, int c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell(r,c);
        }

        public ref T this[uint r, uint c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell((int)r,(int)c);
        }

        [MethodImpl(Inline)]
        public BlockVector<N,T> GetRow(int row)
        {
            if(row < 0 || row >= _RowCount)
                throw Errors.OutOfRange(row, 0, _RowCount - 1);
            
            return BlockVector.Load<N,T>(data.AsSpan().Slice(row * _RowLenth, _RowLenth));
        }

        [MethodImpl(Inline)]
        public ref BlockVector<N,T> GetRow(int row, ref BlockVector<N,T> dst)
        {
            if(row < 0 || row >= _RowCount)
                throw Errors.OutOfRange(row, 0, _RowCount - 1);
             var src = data.AsSpan().Slice(row * _RowLenth, _RowLenth);
             src.CopyTo(dst.Unsized);
             return ref dst;
        }

        public ref BlockVector<M,T> GetCol(int col, ref BlockVector<M,T> dst)
        {
            if(col < 0 || col >= _ColCount)
                throw Errors.OutOfRange(col, 0, _ColCount - 1);
            
            for(var row = 0; row < _ColLength; row++)
                dst[row] = data[row*_RowLenth + col];
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockVector<M,T> GetCol(int col)
        {
            var alloc = BlockVector.Alloc<M,T>();
            return GetCol(col, ref alloc);
        }

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BlockVector<M,T> src)
        {
            for(var row=0; row < _RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Interchages rows and columns
        /// </summary>
        public Matrix<N,M,T> Transpose()
        {
            var dst = Matrix.Alloc<N,M,T>();
            for(var row = 0; row < _RowCount; row++)
                dst.SetCol(row, GetRow(row));            
            return dst;
        }


        /// <summary>
        /// Applies a function to each cell and overwites the existing cell value with the result
        /// </summary>
        /// <param name="f">The function to apply</param>
        public Matrix<M,N,T> Apply(Func<T,T> f)
        {
            for(var r = 0; r < _RowCount; r++)
            for(var c = 0; c < _ColCount; c++)
                this[r,c] = f(this[r,c]);
            return this;
        }

        public bool IsZero
        {
            get
            {
                for(var i = 0; i < data.Length; i++)
                    if(gmath.nonzero(data[i]))
                        return false;
                return true;
            }
        }

        /// <summary>
        /// Loads the data from the source into a block matrix, allocating as necessary to ensure alignment
        /// </summary>
        [MethodImpl(Inline)]
        public BlockMatrix<M,N,T> Block()
            => Span256.Load(data);

        public bool Equals(Matrix<M,N,T> rhs)
        {
            for(var r = 0; r < (int)_RowCount; r ++)
            for(var c = 0; c < (int)_ColCount; c ++)
                if(!gmath.eq(this[r,c], rhs[r,c]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref Matrix<M,N,T> CopyTo(ref Matrix<M,N,T> dst)
        {
            Data.CopyTo(dst.Data);
            return ref dst;
        }

        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public Matrix<M,N,U> Convert<U>()
            where U : unmanaged
               => new Matrix<M,N,U>(convert<T,U>(data));

        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public ref Matrix<M,N,U> Convert<U>(out Matrix<M,N,U> dst)
            where U : unmanaged
        {
            dst = new Matrix<M,N,U>(convert<T,U>(data));
            return ref dst;
        }



        public override bool Equals(object rhs)
            => rhs is Matrix<M,N,T> x && Equals(x);
 
        public override int GetHashCode()
            => data.GetHashCode();
    }

}
