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
    using static zfunc;

    using static Seq;

    public static class Seq
    {
        public static Seq<T> define<T>(IEnumerable<T> src)
                => new Seq<T>(src); 
        public static FiniteSeq<T> finite<T>(IEnumerable<T> src)
                => new FiniteSeq<T>(src); 
        public static Seq<T> define<T>(params T[] src)
                => new Seq<T>(src); 
    }

    /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, 
    /// an IEnumerable instance
    /// </summary>
    public readonly struct Seq<T> : ISeq<Seq<T>,T>
    {
        public static readonly Seq<T> Empty = default;

        [MethodImpl(Inline)]   
        public static Seq<T> operator + (Seq<T> lhs, Seq<T> rhs)
            => lhs.concat(rhs);

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator Seq<T>(T[] src)
            => new Seq<T>(src);

        public Seq(IEnumerable<T> src)
        {
            this.stream = src;
            this.nonempty = true;
        }

        readonly IEnumerable<T> stream;
        
        readonly bool nonempty;

        public IEnumerable<T> content 
            => stream;

        public bool empty()
            => not(nonempty);

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);

        public Seq<T> concat(Seq<T> rhs)
            => new Seq<T>(stream.Concat(rhs.stream));

        public Seq<Y> Select<Y>(Func<T, Y> selector)       
             => define(from x in stream select selector(x));

        public Seq<Z> SelectMany<Y, Z>(Func<T, Seq<Y>> lift, Func<T, Y, Z> project)
            => define(from x in stream
                          from y in lift(x).stream
                          select project(x, y));

        public Seq<Y> SelectMany<Y>(Func<T, Seq<Y>> lift)
            => define(from x in stream
                          from y in lift(x).stream
                          select y);

        public Seq<T> Where(Func<T, bool> predicate)
            => define(from x in stream where predicate(x) select x);
    }
    

}