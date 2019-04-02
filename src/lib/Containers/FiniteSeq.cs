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

    partial class Structure
    {
        public interface FiniteSeq<T> : Seq<T>
        {
            /// <summary>
            /// Retrieves the 0-based i'th element of the sequence
            /// </summary>
            /// <value></value>
            T this[int i] {get;}

            uint count {get;}
        }
    }


    public readonly struct FiniteSeq<T> : Structure.FiniteSeq<FiniteSeq<T>,T>
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
            this.src = src.ToArray();
            this.nonempty = true;
        }

        readonly T[] src;

        readonly bool nonempty;

        public bool empty()
            => not(nonempty);

        public T this[int i] 
            => src[i];

        public uint count 
            => (uint)src.Length;        

        [MethodImpl(Inline)]
        public FiniteSeq<T> redefine(IEnumerable<T> src)
            => new FiniteSeq<T>(src);                

        public IEnumerable<T> stream()
            => src;

        public bool Equals(FiniteSeq<T> other)
            =>throw new NotImplementedException();
    }


}