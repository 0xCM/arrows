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

    public interface IFiniteSeq<S,T> : ISeq<S,T>, IFiniteContainer<S,T>
        where S : IFiniteSeq<S,T>, new()
    {
        /// <summary>
        /// Retrieves the 0-based i'th element of the sequence
        /// </summary>
        T this[int i] {get;}

    }

    public readonly struct FiniteSeq<T> : IFiniteSeq<FiniteSeq<T>,T>
    {
        public static readonly FiniteSeq<T> Empty = default;

        /// <summary>
        /// Implicitly constructs a sequence from an array
        /// </summary>
        /// <param name="src">The source array</param>
        public static implicit operator FiniteSeq<T>(T[] src)
            => new FiniteSeq<T>(src);

        [MethodImpl(Inline)]
        public FiniteSeq(Index<T> src)
        {
            this.data = src;
            this.nonempty = true;
        }

        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.data = src.ToIndex();
            this.nonempty = true;
        }
        readonly bool nonempty;

        readonly Index<T> data;

        public IEnumerable<T> content
            => data;

        public uint count 
            => (uint)data.Count;

        public bool empty()
            => not(nonempty);

        public T this[int i] 
            => data[i];

        [MethodImpl(Inline)]
        public FiniteSeq<T> redefine(IEnumerable<T> src)
            => new FiniteSeq<T>(src);                

        [MethodImpl(Inline)]
        public bool eq(FiniteSeq<T> rhs)
            => data.ContentEquals(rhs.data);

        [MethodImpl(Inline)]
        public bool Equals(FiniteSeq<T> rhs)
            =>eq(rhs);

        [MethodImpl(Inline)]
        public int hash()
            => data.HashCode();

        [MethodImpl(Inline)]
        public bool neq(FiniteSeq<T> rhs)
            => not(eq(rhs));

        public FiniteSeq<T> concat(FiniteSeq<T> rhs)
            => new FiniteSeq<T>(data.Concat(rhs.data));
    }
}