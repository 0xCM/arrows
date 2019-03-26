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

    using static zcore;

   /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, 
    /// an IEnumerable instance
    /// </summary>
    public readonly struct Seq<T> : Traits.Seq<T> 
    {
        public static readonly Seq<T> Empty = default;

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator Seq<T>(T[] src)
            => new Seq<T>(src);

        public Seq(IEnumerable<T> src)
        {
            this.src = src;
            this.nonempty = true;
        }

        readonly IEnumerable<T> src;
        
        readonly bool nonempty;


        public bool empty()
            => not(nonempty);

        public IEnumerable<T> stream()
            => src;

        // IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //     => src.GetEnumerator();

        // IEnumerator IEnumerable.GetEnumerator()
        //     => src.GetEnumerator();

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);        
    }

    public readonly struct FiniteSeq<T> : Traits.FiniteSeq<T>
        where T : IEquatable<T>
    {
        public static readonly FiniteSeq<T> Empty = default;


        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src"></param>
        public static implicit operator FiniteSeq<T>(T[] src)
            => new FiniteSeq<T>(src);


        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.src = src.ToSlice();
            this.nonempty = true;
        }

        readonly Slice<T> src;

        readonly bool nonempty;

        public bool empty()
            => not(nonempty);

        public T this[int i] 
            => src[i];

        public int count 
            => src.length.ToInt();

        [MethodImpl(Inline)]
        public FiniteSeq<T> redefine(IEnumerable<T> src)
            => new FiniteSeq<T>(src);                

        public IEnumerable<T> stream()
            => src.cells;

        // IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //     => src.GetEnumerator();

        // IEnumerator IEnumerable.GetEnumerator()
        //     => src.GetEnumerator();

    }

    public static class Seq
    {
        public static Seq<T> define<T>(IEnumerable<T> src)
                => new Seq<T>(src); 

        public static FiniteSeq<T> finite<T>(IEnumerable<T> src)
            where T : IEquatable<T>
                => new FiniteSeq<T>(src); 


        public static Seq<T> define<T>(params T[] src)
            where T : IEquatable<T>
                => new Seq<T>(src); 

        /// <summary>
        /// Instantiates the canonical conrete type (but does not force evaluation) 
        /// for an IEnumerable instance
        /// </summary>
        /// <param name="src">The</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Seq<T> Reify<T>(this IEnumerable<T> src)
            where T : IEquatable<T>
                => define(src);
    }

 

}