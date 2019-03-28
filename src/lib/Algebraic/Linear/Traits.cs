//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface TVectorSemiring<N,T> : Traits.Semiring<Vector<N, T>>, Traits.Tranposable<Vector<N,T>, Covector<N,T>> 
        where N : TypeNat, new()
    {
        
    }

    partial class Traits
    {

        /// <summary>
        /// Characterizes a type that supports a notion of transposition
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public interface Tranposable<T>
        {
            /// <summary>
            /// Effects the source-to-target transposition
            /// </summary>
            /// <param name="src">The source type</param>
            /// <returns></returns>
            T tranpose();        
        }


        public interface Tranposable<S,T>
        {
            /// <summary>
            /// Effects the source-to-target transposition
            /// </summary>
            /// <param name="src">The source type</param>
            /// <returns></returns>
            T tranpose(S src);        
        }


        public interface Matrix<M,N,T> : Tranposable<Z0.Matrix<N,M,T>>
            where M : TypeNat, new()
            where N : TypeNat, new()
        {
            Z0.Slice<N,Z0.Covector<N,T>> covectors();

            Z0.Slice<M,Z0.Vector<M,T>> vectors();

            Z0.Covector<N,T> covector<I>()
                where I : TypeNat, new(); 

            Z0.Covector<N,T> covector(uint i);

            Z0.Dim<M,N> dim();

            Z0.Vector<M,T> vector<J>()
                where J : TypeNat, new(); 

            Z0.Vector<M,T> vector(uint i);

            T cell<I,J>()
                where I : TypeNat, new()
                where J : TypeNat, new(); 
            
            T cell(uint i, uint j);
        }


        public interface Vector<N,T> : IEnumerable<T>, Tranposable<Z0.Covector<N,T>>
            where N : TypeNat, new()
        {
            
        }

        public interface Covector<N,T> : Tranposable<Z0.Vector<N,T>>
            where N : TypeNat, new()
        {
            
        }
    }
}