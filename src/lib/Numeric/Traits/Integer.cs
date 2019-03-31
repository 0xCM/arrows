//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    partial class Operative
    {

        /// <summary>
        /// Characterizes operations over an integer type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Integer<T> : RealNumber<T>, Stepwise<T>, Bitwise<T> { }

        public interface FiniteInt<T> : Integer<T>, BoundReal<T> { }


        /// <summary>
        /// Characterizes operations over unbound integers
        /// </summary>
        public interface InfiniteInt<T> : Integer<T>, Infinite<T> { }


        /// <summary>
        /// Characterizes operations over a signed interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface SignedInt<T> : Integer<T>, Signed<T>, Subtractive<T> { }


        /// <summary>
        /// Characterizes operations over a signed, finite interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteSignedInt<T> : SignedInt<T>, BoundReal<T> { } 

        /// <summary>
        /// Characterizes operations over an unbound signed integral type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InfiniteSignedInt<T> : InfiniteInt<T>, SignedInt<T> {}


    }

    partial class Structure
    {

        public interface Integer<S> :  RealNumber<S>, Stepwise<S>, Bitwise<S> { }

        public interface FiniteSignedInt<S> : Integer<S>, Finite<S>, Signed<S> {}

        public interface InfiniteSignedInt<S> : Integer<S>, Infinite<S>, Signed<S> { }

        /// <summary>
        /// Characterizes a structure over an integer type
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Integer<S,T> : Integer<S>, RealNumber<S,T>, Stepwise<S,T>, Bitwise<S,T>
            where S : Integer<S,T>, new() { }

        
        /// <summary>
        /// Characterizes operational reifications over infinite signed ingegers
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InfiniteSignedInt<S,T> : InfiniteSignedInt<S>, Integer<S,T>, Infinite<S,T>, Signed<S,T>
            where S : InfiniteSignedInt<S,T>, new() { }


        /// <summary>
        /// Characterizes operational reifications of RealFiniteUInt 
        /// </summary>
        /// <typeparam name="R">The reification type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteSignedInt<S,T> : FiniteSignedInt<S>, Integer<S,T>, Finite<S,T>, Signed<S,T>
            where S : FiniteSignedInt<S,T>, new() { }

    }
}