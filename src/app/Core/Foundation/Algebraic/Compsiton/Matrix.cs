//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using static corefunc;
    using static Class;

    public static class Matrix
    {
        public static Matrix<M, N, T> define<M,N,T>(params T[] src)
            where M : TypeNat
            where N : TypeNat
                => new Matrix<M,N,T>(src);

    }



    public readonly struct Matrix<M, N, T> : Class.Matrix<M, N, T>
        where M : TypeNat
        where N : TypeNat
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
            where I : TypeNat
            where J : TypeNat
                => cell(natval<I>(), natval<J>());

        public T cell(uint i, uint j)
            => data[m*i + j];

        public Class.Vector<M, T> col(uint j)
            => vector<M,T>(data[0..]);

        public Class.Vector<M, T> col<J>() 
            where J : TypeNat
                => col(natval<J>());

        public IEnumerable<Class.Vector<M, T>> cols()
        {
            for(var j =0u; j < n; j++)
                yield return col(j);
        }

        public Class.Covector<N, T> row<I>() 
            where I : TypeNat
            => row(natval<I>());

        public Class.Covector<N, T> row(uint i)
            => covector<N,T>(data.Segment(n*i,n));  

        public IEnumerable<Class.Covector<N, T>> rows()
        {
            for(var i = 0u; i < m; i++)
                yield return row(i);
        }

        public Class.Matrix<N, M, T> tranpose(Class.Matrix<M, N, T> src)
            => throw new Exception();

        public override string ToString()
            => string.Join("\r\n",rows().Select(r => r.ToString()));
    }
 
}