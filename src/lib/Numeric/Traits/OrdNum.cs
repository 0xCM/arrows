//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {
        /// <summary>
        /// Characterizes numeric operations in the presence of order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface OrderedNumber<T> : Number<T>, Ordered<T>
        {
            /// <summary>
            /// Specifies the lower and upper bounds of the number, if they exist
            /// </summary>
            (T min, T max)? limits {get;}

        }

        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface OrderedNumber<S,T> :  OrderedNumber<S>, Structural<S,T>
            where S : OrderedNumber<S,T>, new() {}

        /// <summary>
        /// Characterizes operations on a type whose values are bounded below and above
        /// by respective finite values
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <remarks>Note that Bounded => Ordered, at least by our definitions</remarks>
        public interface FiniteNumber<T> : Number<T>, BoundReal<T> { }

        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface FiniteNumber<S,T> :  FiniteNumber<S>, Structural<S,T>
            where S : FiniteNumber<S,T>, new() {}

    }

}