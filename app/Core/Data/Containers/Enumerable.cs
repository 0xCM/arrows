//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

    using C = Contracts;

    public static class Enumerable
    {
        public static Enumerable<T> define<T>(IEnumerable<T> src)
            => new Enumerable<T>(src); 

        public static Enumerable<T> define<T>(params T[] src)
            => new Enumerable<T>(src); 

        /// <summary>
        /// Instantiates the canonical conrete type (but does not force evaluation) 
        /// for an IEnumerable instance
        /// </summary>
        /// <param name="src">The</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Enumerable<T> Reify<T>(this IEnumerable<T> src)
            => define(src);
    }

    /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, an IEnumerable instance
    /// </summary>
    public readonly struct Enumerable<T> : IEnumerable<T> 
    {
        readonly IEnumerable<T> src;
        
        public Enumerable(IEnumerable<T> src)
        {
            this.src = src;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => src.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();

        public Enumerable<T> redefine(IEnumerable<T> src)
            => new Enumerable<T>(src);        
    }
}