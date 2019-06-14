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

        Span<M,N,T> data;

        public static implicit operator Matrix<M,N,T>(Span<M,N,T> src)
            => new Matrix<M, N, T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<M,N,T>(Matrix<M,N,T> src)
            => src.data;


        [MethodImpl(Inline)]
        public Matrix(Span<M,N,T> src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Matrix(params T[] src)
        {
            data = src;            
        }

        [MethodImpl(Inline)]
        public Matrix(IEnumerable<T> src)
        {
            data = src.ToArray();
        }

        [MethodImpl(Inline)]        
        public ref T Cell(int i, int j)
            => ref data[i,j];

        public ref T this[int i, int j]
        {
            [MethodImpl(Inline)]        
            get => ref data[i,j];
        }

        public ref T this[uint i, uint j]
        {
            [MethodImpl(Inline)]        
            get => ref data.Cell(i,j);
        }

        [MethodImpl(Inline)]
        public Covector<N,T> Row(int i)
            => data.Row(i);

        [MethodImpl(Inline)]
        public Vector<M,T> Col(int j)
            => data.Col(j);

        public Span<M,N,T> Data
        {
            
            [MethodImpl(Inline)]
            get => data;
        }

        public Matrix<I,J,T> SubMatrix<I,J>((uint r, uint c) origin, Dim<I,J> dstdim)
            where I : ITypeNat, new()
            where J : ITypeNat, new()
                => data.SubSpan(origin, dstdim);


        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}
