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
    using static Traits;


    partial class Traits
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

            Covector<N,T> row(uint i);

            Dimenson<M,N> dim();

            Vector<M,T> col<J>()
                where J : TypeNat; 

            Vector<M,T> col(uint i);

            T cell<I,J>()
                where I : TypeNat
                where J : TypeNat; 
            
            T cell(uint i, uint j);
        }

    }

 
}