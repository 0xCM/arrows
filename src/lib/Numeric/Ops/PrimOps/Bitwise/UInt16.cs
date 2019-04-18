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

    partial class PrimOps { partial class Reify {
        public readonly partial struct Bitwise : 
            Bitwise<ushort> 
        {


            [MethodImpl(Inline)]   
            public ushort and(ushort a, ushort b) 
                => (ushort)(a & b);

            [MethodImpl(Inline)]   
            public ushort or(ushort a, ushort b) 
                => (ushort)(a | b);

            [MethodImpl(Inline)]   
            public ushort xor(ushort a, ushort b) 
                => (ushort)(a ^ b);

            [MethodImpl(Inline)]   
            public ushort lshift(ushort a, int shift) 
                => (ushort)(a << shift);

            [MethodImpl(Inline)]   
            public ushort rshift(ushort a, int shift) 
                => (ushort)(a >> shift);

            [MethodImpl(Inline)]   
            public ushort flip(ushort a) 
                => (ushort)~ a;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(ushort src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<ushort>());

            [MethodImpl(Inline)]   
            public BitString bitstring(ushort src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(ushort src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(ushort src)
            {
                var bitsize = 16;
                var maxidx = bitsize - 1;
                var dst = alloc<bit>(bitsize); 
                for(var i=0; i<= maxidx; i++)               
                    dst[maxidx-i] = src & (1 << i);
                return dst;
            }

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(ushort src)
                => BitConverter.GetBytes(src);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(ushort src)
                => countLeadingOff((uint)src) - 16;


            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(ushort src)
                => countTrailingOff((uint)src);


        }
    }
}

    public static partial class BitwiseX
    {
        [MethodImpl(Inline)]
        public static ushort LShift(this ushort src, int shift)
            => (ushort)(src << shift);

        [MethodImpl(Inline)]
        public static ushort RShift(this ushort src, int shift)
            => (ushort)(src >> shift);

        [MethodImpl(Inline)]
        public static ushort And(this ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);
            
        [MethodImpl(Inline)]
        public static ushort Or(this ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        [MethodImpl(Inline)]
        public static ushort XOr(this ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static ushort Flip(this ushort src)
            => (ushort)(~src);

        [MethodImpl(Inline)]
        public static bool TestBit(this ushort src, int pos)
            => (src & (1 << pos)) != 0;
    }
}

