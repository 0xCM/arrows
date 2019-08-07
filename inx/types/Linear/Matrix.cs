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
    
    using static nfunc;
    using static zfunc;

    public ref struct Matrix<M,N,T>
        where M : ITypeNat, new()
        where N : ITypeNat, new()
        where T : struct    
    {        
        Span256<T> data;

        Vector<M,T> colbuffer;

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

        public static implicit operator Matrix<M,N,T>(Span256<T> src)
            => new Matrix<M,N,T>(src);

        public static implicit operator Span<M,N,T>(Matrix<M,N,T> src)
            => src.Natural;

        public static implicit operator Span256<T>(Matrix<M,N,T> src)
            => src.Unsized;

        [MethodImpl(Inline)]
        public static bool operator == (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> operator + (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.Add(rhs);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> operator - (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> operator | (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> operator & (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static Matrix<M,N,T> operator ^ (Matrix<M,N,T> lhs, in Matrix<M,N,T> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public Matrix(Span256<T> src)
        {
            require(src.Length >= CellCount);
            data = src;
            colbuffer = Vector.Alloc<M,T>();
        }

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
        public Vector<N,T> Row(int row)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
            
            return Vector.Load(data.Slice(row * RowLenth, RowLenth), ColRep);
        }

        public ref Vector<M,T> Col(int col, ref Vector<M,T> dst)
        {
            if(col < 0 || col >= ColCount)
                throw Errors.OutOfRange(col, 0, ColCount - 1);
            
            for(var row = 0; row < ColLength; row++)
                dst[row] = data[row*RowLenth + col];
            return ref dst;
        }

        [MethodImpl(Inline)]
        public Vector<M,T> Col(int col)
            => Col(col, ref colbuffer);            

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
        public void Apply(Func<T,T> f)
        {
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
                this[r,c] = f(this[r,c]);
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

        public bool Equals(Matrix<M,N,T> rhs)
        {
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
                if(!gmath.eq(this[r,c], rhs[r,c]))
                    return false;
            return true;
        }

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}
