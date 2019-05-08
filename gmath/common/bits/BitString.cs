//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    
    using static zfunc;
    using static mfunc;

    public readonly struct BitString 
    {
        public static BitString define(IReadOnlyList<Bit> src)
            => new BitString(src.ToArray());

        public static BitString define(params Bit[] src)
            => new BitString(src);

        public static BitString define(IEnumerable<Bit> src)
            => new BitString(src.ToArray());

        [MethodImpl(Inline)]   
        public BitString bitstring(ushort src) 
            => BitString.define(Bit.Parse(Bits.bitchars(src)));

        public static readonly BitString Empty = default;


        [MethodImpl(Inline)]
        public static BitString operator + (BitString lhs, BitString rhs) 
            => lhs.concat(rhs);

        public Bit[] bits {get;}

        public BitString zero 
            => Empty;


        [MethodImpl(Inline)]
        public bool nonzero()
            => bits.Length != 0;


        [MethodImpl(Inline)]
        public BitString(params Bit[] src)
            => this.bits = src;


        [MethodImpl(Inline)]
        public BitString concat(BitString rhs)
            => new BitString(bits.ConcatArrays(rhs.bits));

        [MethodImpl(Inline)]
        public bool eq(BitString rhs)
            => bits.ReallyEqual(rhs.bits);

        [MethodImpl(Inline)]
        public bool eq(BitString lhs, BitString rhs)
            => lhs.eq(rhs);

        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
            => bits.ReallyEqual(rhs.bits);

        [MethodImpl(Inline)]
        public bool neq(BitString rhs)
            =>  not(Equals(rhs));

        [MethodImpl(Inline)]
        public bool neq(BitString lhs, BitString rhs)
            => lhs.neq(rhs);

        [MethodImpl(Inline)]
        public string format()
            => string.Concat(map(bits,b =>  b.format()));

        [MethodImpl(Inline)]
        public int hash()
            => bits.HashCode();

        public uint length
            => (uint)bits.Length;

        public override string ToString()
            => format();

        public override int GetHashCode()
            => hash();


    }

 
}