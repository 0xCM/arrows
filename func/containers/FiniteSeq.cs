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

    using static zfunc;


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
        public FiniteSeq(T[] src)
        {
            this.data = src;
            this.nonempty = true;
        }

        [MethodImpl(Inline)]
        public FiniteSeq(IEnumerable<T> src)
        {
            this.data = src.ToArray();
            this.nonempty = true;
        }
        readonly bool nonempty;

        readonly T[] data;

        public IEnumerable<T> Content
            => data;

        public int Count 
            => data.Length;

        public bool empty()
            => not(nonempty);

        public T this[int i] 
            => data[i];


        [MethodImpl(Inline)]
        public bool Equals(FiniteSeq<T> rhs)
            => data.Equals(rhs.data);

        public FiniteSeq<T> Concat(FiniteSeq<T> rhs)
            => new FiniteSeq<T>(data.Concat(rhs.data));
    }
}