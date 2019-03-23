//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
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


        public interface Matrix<M,N,T> : Tranposable<Matrix<N,M,T>>
            where M : TypeNat, new()
            where N : TypeNat, new()
        {
            IEnumerable<Covector<N,T>> rows();

            IEnumerable<Vector<M,T>> cols();

            Covector<N,T> row<I>()
                where I : TypeNat, new(); 

            Covector<N,T> row(uint i);

            Dimenson<M,N> dim();

            Vector<M,T> col<J>()
                where J : TypeNat, new(); 

            Vector<M,T> col(uint i);

            T cell<I,J>()
                where I : TypeNat, new()
                where J : TypeNat, new(); 
            
            T cell(uint i, uint j);
        }


        public interface Vector<N,T> : IEnumerable<T>, Tranposable<Core.Covector<N,T>>
            where N : TypeNat, new()
        {
            
        }

        public interface Covector<N,T> : Tranposable<Core.Vector<N,T>>
            where N : TypeNat, new()
        {
            
        }
    }
}