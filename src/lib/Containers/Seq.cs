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
            where T : IEquatable<T>
                => new FiniteSeq<T>(src); 


        public static Seq<T> define<T>(params T[] src)
            where T : IEquatable<T>
                => new Seq<T>(src); 

    }

    partial class Structure
    {
        public interface Seq<T> 
        {
            
        }


        public interface FiniteSeq<S,T> : FiniteSeq<T>
            where S : FiniteSeq<S,T>, new()
        {
        }

    }

    /// <summary>
    /// Provides a layer of indirection for, and gives a concrete type to, 
    /// an IEnumerable instance
    /// </summary>
    public readonly struct Seq<T> : Structure.Seq<Seq<T>> 
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

        public Seq<T> redefine(IEnumerable<T> src)
            => new Seq<T>(src);        
    }
    

}