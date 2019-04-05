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
    public readonly struct Seq<T> : Contain.Seq<Seq<T>,T>
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

        public IEnumerable<T> content 
            => src;

        public bool empty()
            => not(nonempty);

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);

        public Seq<T> concat(Seq<T> rhs)
            => new Seq<T>(content.Concat(rhs.content));
    }
    

}