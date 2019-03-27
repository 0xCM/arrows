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
        public interface Integer<T> : OrderedNumber<T>, Stepwise<T>, Bitwise<T> { }

        /// <summary>
        /// Characterizes a structure over an integer type
        /// </summary>
        /// <typeparam name="S">The type of the realizing structure</typeparam>
        /// <typeparam name="T">The type of the underlying primitive</typeparam>
        public interface Integer<S,T> : Integer<S>, Structure<S,T>
            where S : Integer<S,T>, new() { }

        public interface FiniteInt<T> : Integer<T>, Finite<T> { }

        /// <summary>
        /// Characterizes a structure over a bound integral type
        /// </summary>
        public interface FiniteInt<S,T> : FiniteInt<S>, Structure<S,T>
            where S : FiniteInt<S,T>, new() { }


        /// <summary>
        /// Characterizes operations over unbound integers
        /// </summary>
        public interface InfiniteInt<T> : Integer<T>, Infinite<T> { }


        /// <summary>
        /// Characterizes an unbound integer structure
        /// </summary>
        public interface InfiniteInt<S,T> : InfiniteInt<S>, Structure<S,T>
            where S : InfiniteInt<S,T>, new() { }

    }
}