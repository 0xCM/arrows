//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;


    public readonly struct FixedBitVector<N> : Structure.BitString<FixedBitVector<N>,N>
        where N : TypeNat, new()     
    {
        public static readonly uint Length = natval<N>();
        
        [MethodImpl(Inline)]
        public FixedBitVector(IEnumerable<bit> src)
            => this.bits = slice<N,bit>(src);

        [MethodImpl(Inline)]
        public FixedBitVector(string src)
        {
            Prove.claim<N>(src.Length);
            var digits = new bit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            bits = digits;            
        }
            

        [MethodImpl(Inline)]
        public FixedBitVector(params bit[] bits)
            => this.bits = Prove.length<N,bit>(bits);

        public Slice<N,bit> bits {get;}


        [MethodImpl(Inline)]
        public bool eq(FixedBitVector<N> rhs)
            => bits.eq(rhs.bits);

        [MethodImpl(Inline)]
        public bool neq(FixedBitVector<N> rhs)
            => bits.neq(rhs.bits);

        [MethodImpl(Inline)]
        public bool Equals(FixedBitVector<N> rhs)
            => this.eq(rhs);

        [MethodImpl(Inline)]
        bool Equality<FixedBitVector<N>>.eq(FixedBitVector<N> lhs, FixedBitVector<N> rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        bool Equality<FixedBitVector<N>>.neq(FixedBitVector<N> lhs, FixedBitVector<N> rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(map(bits,b =>  b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.hash();

        public uint length
            => Length;

        public override string ToString()
            => format();
        
        public override int GetHashCode()
            => hash();

    }

}