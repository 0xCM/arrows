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
        public static Enumerable<I> define<I>(IEnumerable<I> src)
            => new Enumerable<I>(src); 

        public static Enumerable<I> define<I>(params I[] src)
            => new Enumerable<I>(src); 

        /// <summary>
        /// Instantiates the canonical conrete type (but does not force evaluation) 
        /// for an IEnumerable instance
        /// </summary>
        /// <param name="src">The</param>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        public static Enumerable<I> Reify<I>(this IEnumerable<I> src)
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