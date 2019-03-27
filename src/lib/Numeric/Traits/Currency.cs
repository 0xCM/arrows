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
        /// Characterizes a bounded fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<T> : Bounded<T>, Fractional<T>
        {

        }

        /// <summary>
        /// Characterized a bounded, structured type that admits non-whole values
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<S,T> : Currency<S>, Structure<S,T>
            where S : Currency<S,T>,  new()

            where T : new()
        {
        }


    }


 
}