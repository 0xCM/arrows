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

        Span256<T> data;


        [MethodImpl(Inline)]
        public Matrix(Span256<T> src)
        {
            require(src.Length >= CellCount);
            data = src;
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
        public Span<N,T> Row(int r)
        {
            if(r < 0 || r >= RowCount)
                throw Errors.OutOfRange(r, 0, RowCount - 1);
            
            return data.Slice(r * RowLenth, RowLenth);
        }

        public Span<M,T> Col(int col)
        {
            if(col < 0 || col >= ColCount)
                throw Errors.OutOfRange(col, 0, ColCount - 1);
            
            var v = NatSpan.alloc<M,T>();
            for(var r = 0; r < ColLength; r++)
                v[r] = data[r + col];
            return v;
        }

        public Span256<T> Data
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Applies a function to each cell and overwites the existing cell value with the result
        /// </summary>
        /// <param name="f"></param>
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
