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

        }

        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface OrderedNumber<S,T> :  OrderedNumber<S>, Structure<S,T>
            where S : OrderedNumber<S,T>, new()
        {

        }


    }


}