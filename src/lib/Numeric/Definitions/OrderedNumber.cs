//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
        /// <summary>
        /// Characterizes numeric operations in the presence of order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface OrderedNumber<T> : Stepwise<T>,  Ordered<T>, Number<T> { }

    }

    partial class Structures
    {
        public interface OrderedNumber<S> :  Stepwise<S>,  Orderable<S>,  Number<S>
            where S : OrderedNumber<S>, new() {}
        
        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface OrderedNumber<S,T> : OrderedNumber<S>, Wrapped<T>
            where S : OrderedNumber<S,T>, new() {}
    }

}