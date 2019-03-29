//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;

    partial class Traits
    {

        /// <summary>
        /// Characterizes operations over an integer type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Integer<T> : RealNumber<T>, Stepwise<T>, Bitwise<T> { }

        /// <summary>
        /// Characterizes a structure over an integer type
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Integer<S,T> : Integer<S>, Structural<S,T>
            where S : Integer<S,T>, new() { }

        public interface FiniteInt<T> : Integer<T>, BoundReal<T> { }

        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
        public interface FiniteInt<S,T> : FiniteInt<S>, Structural<S,T>
            where S : FiniteInt<S,T>, new() { }


        /// <summary>
        /// Characterizes operations over unbound integers
        /// </summary>
        public interface InfiniteInt<T> : Integer<T>, Infinite<T> { }


        /// <summary>
        /// Characterizes an unbound integer structure
        /// </summary>
        public interface InfiniteInt<S,T> : InfiniteInt<S>, Structural<S,T>
            where S : InfiniteInt<S,T>, new() { }


        /// <summary>
        /// Characterizes operations over a signed interal type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface SignedInt<T> : Integer<T>, Signed<T>, Negatable<T> { }


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
}