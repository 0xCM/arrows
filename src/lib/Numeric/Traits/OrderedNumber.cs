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
        public interface OrderedNumber<T> :  Ordered<T>, Number<T> { }

    }

    partial class Structure
    {
        public interface OrderedNumber<S> :  Ordered<S>,  Number<S>
        {

        }
        
        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface OrderedNumber<S,T> : OrderedNumber<S>,  Ordered<S,T>,  Number<S,T>
            where S : OrderedNumber<S,T>, new() {}
    }

}