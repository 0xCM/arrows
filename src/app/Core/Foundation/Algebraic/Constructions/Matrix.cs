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
        public static Reify.Matrix<M, N, T> define<M,N,T>(params T[] src)
            where M : TypeNat
            where N : TypeNat
                => new Reify.Matrix<M,N,T>(src);

    }

    partial class Class
    {

        /// <summary>
        /// Characterizes a type that supports a notion of transposition
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public interface Tranposable<S,T>
        {
            /// <summary>
            /// Effects the source-to-target transposition
            /// </summary>
            /// <param name="src">The source type</param>
            /// <returns></returns>
            T tranpose(S src);        
        }



        public interface Matrix<M,N,T> : Tranposable<Matrix<M,N,T>, Matrix<N,M,T>>
            where M : TypeNat
            where N : TypeNat
        {
            IEnumerable<Covector<N,T>> rows();

            IEnumerable<Vector<M,T>> cols();

            Covector<N,T> row<I>()
                where I : TypeNat; 

            Covector<N,T> row(int i);

            
            Vector<M,T> col<J>()
                where J : TypeNat; 

            Vector<M,T> col(int i);

            T cell<I,J>()
                where I : TypeNat
                where J : TypeNat; 
            
            T cell(int i, int j);
        }

    }

    partial class Reify
    {
        
        public readonly struct Matrix<M, N, T> : Class.Matrix<M, N, T>
            where M : TypeNat
            where N : TypeNat
        {
            readonly T[] data;
            readonly int m;
            readonly int n;

            public Matrix(params T[] src)
            {
                (m, n) = natvals<M,N>();
                demand(m*n == src.Length);
                data = src;
            }

            public T cell<I, J>()
                where I : TypeNat
                where J : TypeNat
                 => cell(natval<I>(), natval<J>());

            public T cell(int i, int j)
                => data[m*i + j];

            public Class.Vector<M, T> col(int j)
                => vector<M,T>(data[0..]);

            public Class.Vector<M, T> col<J>() 
                where J : TypeNat
                    => col(natval<J>());

            public IEnumerable<Class.Vector<M, T>> cols()
            {
                for(int j =0; j < n; j++)
                    yield return col(j);
            }

            public Class.Covector<N, T> row<I>() 
                where I : TypeNat
                => row(natval<I>());

            public Class.Covector<N, T> row(int i)
                => covector<N,T>(data[m*i..(m*i + n-1)]);

            public IEnumerable<Class.Covector<N, T>> rows()
            {
                for(int i =0; i < m; i++)
                    yield return row(i);
            }

            public Class.Matrix<N, M, T> tranpose(Class.Matrix<M, N, T> src)
                => throw new Exception();

            public override string ToString()
                => string.Join("\r\n",rows().Select(r => r.ToString()));
        }
    }

}