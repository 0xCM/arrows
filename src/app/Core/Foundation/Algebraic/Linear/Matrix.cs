//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static corefunc;
    using static Traits;

    public static class Matrix
    {
        public static Matrix<M, N, T> define<M,N,T>(params T[] src)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => new Matrix<M,N,T>(src);

    }

    public readonly struct Matrix<M, N, T> : Traits.Matrix<M, N, T>
        where M : TypeNat, new()
        where N : TypeNat, new()
    {
        static readonly Dimenson<M,N> Dimenson = default;
        
        readonly T[] data;
        
        readonly uint m;
        
        readonly uint n;

        public Matrix(params T[] src)
        {
            (m, n) = (Dimenson.m, Dimenson.n);
            demand(m*n == src.Length);
            data = src;
        }

        
        public Dimenson<M,N> dim()
            => Dimenson;
        
        public T cell<I, J>()
            where I : TypeNat, new()
            where J : TypeNat, new()
                => cell(natval<I>(), natval<J>());

        public T cell(uint i, uint j)
            => data[m*i + j];

        public Traits.Vector<M, T> col(uint j)
            => vector<M,T>(data[0..]);

        public Traits.Vector<M, T> col<J>() 
            where J : TypeNat, new()
                => col(natval<J>());

        public IEnumerable<Traits.Vector<M, T>> cols()
        {
            for(var j =0u; j < n; j++)
                yield return col(j);
        }

        public Traits.Covector<N, T> row<I>() 
            where I : TypeNat, new()
            => row(natval<I>());

        public Traits.Covector<N, T> row(uint i)
            => covector<N,T>(data.Segment(n*i,n));  

        public IEnumerable<Traits.Covector<N, T>> rows()
        {
            for(var i = 0u; i < m; i++)
                yield return row(i);
        }

        public Traits.Matrix<N, M, T> tranpose()
            => new Matrix<N,M,T>(cols().SelectMany(x => x).ToArray());

        public override string ToString()
            => string.Join("\r\n",rows().Select(r => r.ToString()));
    } 
}