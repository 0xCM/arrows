//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using static Bits;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            Bitwise<short> 
        {
            
            [MethodImpl(Inline)]   
            public short and(short a, short b) 
                => (short)(a & b);

            [MethodImpl(Inline)]   
            public short or(short a, short b) 
                => (short)(a | b);

            [MethodImpl(Inline)]   
            public short xor(short a, short b) 
                => (short)(a ^ b);

            [MethodImpl(Inline)]   
            public short lshift(short a, int shift) 
                => (short)(a << shift);

            [MethodImpl(Inline)]   
            public short rshift(short a, int shift) 
                => (short)(a >> shift);

            [MethodImpl(Inline)]   
            public short flip(short a) 
                => (short)~ a;

            [MethodImpl(Inline)]
            public string bitchars(short src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<short>());

            [MethodImpl(Inline)]   
            public BitString bitstring(short src) 
                => BitString.define(Bits.parse(bitchars(src)));
            [MethodImpl(Inline)]
            public byte[] bytes(short src)
                => BitConverter.GetBytes(src); 

            [MethodImpl(Inline)]
            public bool testbit(short src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(short src)
            {
                var bitsize = 16;
                var maxidx = bitsize - 1;
                var dst = alloc<bit>(bitsize); 
                for(var i=0; i<= maxidx; i++)               
                    dst[maxidx-i] = src & (1 << i);
                return dst;
            }

            [MethodImpl(Inline)]
            public static int countTrailingOff(short src)
                => countTrailingOff((int)src);
        }
    }
}
    public static partial class BitwiseX
    {
        [MethodImpl(Inline)]
        public static short LShift(this short src, int shift)
            => (short)(src << shift);

        [MethodImpl(Inline)]
        public static short RShift(this short src, int shift)
            => (short)(src >> shift);

        [MethodImpl(Inline)]
        public static short And(this short lhs, short rhs)
            => (short)(lhs & rhs);
            
        [MethodImpl(Inline)]
        public static short Or(this short lhs, short rhs)
            => (short)(lhs | rhs);

        [MethodImpl(Inline)]
        public static short XOr(this short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static short Flip(this short src)
            => (short)(~src);

        [MethodImpl(Inline)]
        public static bool TestBit(this short src, int pos)
            => (src & (1 << pos)) != 0;
    }
}

