//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;


    partial class Class
    {
        /// <summary>
        /// Characterizes a bounded fractional operation provider
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<T> : Finite<T>, Fractional<T>
        {

        }

        /// <summary>
        /// Characterized a bounded, structured type that admits non-whole values
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The primitive type</typeparam>
        public interface Currency<S,T> : Finite<S,T>, Fractional<S,T>
            where S : Currency<S,T>, new()
            where T : new()
        {
        }


    }


 
}