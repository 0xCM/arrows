//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static corefunc;

   /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, 
    /// an IEnumerable instance
    /// </summary>
    public readonly struct Seq<T> : Traits.Seq<T> 
    {
        readonly IEnumerable<T> src;
        
        public Seq(IEnumerable<T> src)
        {
            this.src = src;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => src.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);        
    }

    public readonly struct FiniteSeq<T> : Traits.FiniteSeq<T>
    {
        readonly Slice<T> src;


        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.src = src.ToSlice();
        }

        public T this[int i] 
            => src[i];

        public int count 
            => src.length.ToInt();

        [MethodImpl(Inline)]
        public FiniteSeq<T> redefine(IEnumerable<T> src)
            => new FiniteSeq<T>(src);                

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => src.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => src.GetEnumerator();

    }

    public static class Seq
    {
        public static Seq<T> define<T>(IEnumerable<T> src)
            => new Seq<T>(src); 

        public static FiniteSeq<T> finite<T>(IEnumerable<T> src)
            => new FiniteSeq<T>(src); 


        public static Seq<T> define<T>(params T[] src)
            => new Seq<T>(src); 

        /// <summary>
        /// Instantiates the canonical conrete type (but does not force evaluation) 
        /// for an IEnumerable instance
        /// </summary>
        /// <param name="src">The</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Seq<T> Reify<T>(this IEnumerable<T> src)
            => define(src);
    }

 

}