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
    public ref struct BlockMatrix<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : struct    
    {        
        Span256<T> data;

        public static readonly Dim<M,N> Dim = default;        

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        public static readonly int RowCount = nati<M>();

        /// <summary>
        /// The number of columns in the structure
        /// </summary>
        public static readonly int ColCount = nati<N>();

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        public static readonly int RowLenth = ColCount;

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        public static readonly int ColLength = RowCount;

        /// <summary>
        /// The total number of allocated elements
        /// </summary>
        public static readonly int CellCount = RowLenth * ColLength;

        /// <summary>
        /// The Row dimension representative
        /// </summary>
        public static M RowRep = default;

        /// <summary>
        /// The Column dimension representative
        /// </summary>
        public static N ColRep = default;

        public static implicit operator BlockMatrix<M,N,T>(Span256<T> src)
            => new BlockMatrix<M,N,T>(src);

        public static implicit operator Span<M,N,T>(BlockMatrix<M,N,T> src)
            => src.Natural;

        public static implicit operator Span256<T>(BlockMatrix<M,N,T> src)
            => src.Unsized;

        [MethodImpl(Inline)]
        public static bool operator == (BlockMatrix<M,N,T> lhs, in BlockMatrix<M,N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BlockMatrix<M,N,T> lhs, in BlockMatrix<M,N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BlockMatrix(Span256<T> src)
        {
            require(src.Length >= CellCount);
            data = src;
        }

        [MethodImpl(Inline)]
        internal BlockMatrix(Span256<T> src, bool skipChecks)
            => data = src;

        [MethodImpl(Inline)]        
        public ref T Cell(int r, int c)
            => ref data[RowLenth*r + c];

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
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
            
            return BlockVector.Load<N,T>(data.Slice(row * RowLenth, RowLenth));
        }

        [MethodImpl(Inline)]
        public ref BlockVector<N,T> GetRow(int row, ref BlockVector<N,T> dst)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
             var src = data.Slice(row * RowLenth, RowLenth);
             src.CopyTo(dst.Unsized);
             return ref dst;
        }

        public ref BlockVector<M,T> GetCol(int col, ref BlockVector<M,T> dst)
        {
            if(col < 0 || col >= ColCount)
                throw Errors.OutOfRange(col, 0, ColCount - 1);
            
            for(var row = 0; row < ColLength; row++)
                dst[row] = data[row*RowLenth + col];
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
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Interchages rows and columns
        /// </summary>
        public BlockMatrix<N,M,T> Transpose()
        {
            var dst = BlockMatrix.Alloc<N,M,T>();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, GetRow(row));            
            return dst;
        }

        /// <summary>
        /// Provides access to the underlying data as a linear unblocked span
        /// </summary>
        public Span<T> Unblocked
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a 256-bit blocked span
        /// </summary>
        public Span256<T> Unsized
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a span of natural dimensions
        /// </summary>
        public Span<M,N,T> Natural
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Applies a function to each cell and overwites the existing cell value with the result
        /// </summary>
        /// <param name="f">The function to apply</param>
        public BlockMatrix<M,N,T> Apply(Func<T,T> f)
        {
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
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

        public bool Equals(BlockMatrix<M,N,T> rhs)
        {
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
                if(!gmath.eq(this[r,c], rhs[r,c]))
                    return false;
            return true;
        }

        [MethodImpl(Inline)]
        public ref BlockMatrix<M,N,T> CopyTo(ref BlockMatrix<M,N,T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public BlockMatrix<M,N,U> Convert<U>()
            where U : struct
               => new BlockMatrix<M,N,U>(convert<T,U>(data));


        /// <summary>
        /// Converts the entries of the matrix to a specified type and
        /// populates a new matrix with the converted values
        /// </summary>
        /// <typeparam name="U">The conversion target type</typeparam>
        [MethodImpl(Inline)]
        public ref BlockMatrix<M,N,U> Convert<U>(out BlockMatrix<M,N,U> dst)
            where U : struct
        {
            dst = new BlockMatrix<M,N,U>(convert<T,U>(data));
            return ref dst;
        }

        /// <summary>
        /// Reinterprets the primal type of the matrix
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public BlockMatrix<M,N,U> As<U>()
            where U : struct
               => new BlockMatrix<M,N,U>(data.As<U>());

        /// <summary>
        /// Reinterprets the primal type of the matrix
        /// </summary>
        /// <typeparam name="U">The target type</typeparam>
        [MethodImpl(Inline)]
        public ref BlockMatrix<M,N,U> As<U>(out BlockMatrix<M,N,U> dst)
            where U : struct        
        {
            dst = this.As<U>();
            return ref dst;
        }


        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
    }


}
