//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

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


        public interface Vector<N,T> : Slice<N,T>, Tranposable<Vector<N,T>, Covector<N,T>>
            where N : TypeNat
        {
            
        }

        public interface Covector<N,T> : Slice<N,T>, Tranposable<Covector<N,T>, Vector<N,T>>
            where N : TypeNat
        {
            
        }

        public interface Matrix<M,N,T> : Tranposable<Matrix<M,N,T>, Matrix<N,M,T>>
            where M : TypeNat
            where N : TypeNat
        {

        }

    }
}