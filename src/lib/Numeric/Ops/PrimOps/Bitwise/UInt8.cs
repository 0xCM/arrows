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
            Bitwise<byte> 
        {

            [MethodImpl(Inline)]   
            public byte and(byte a, byte b) 
                => (byte)(a & b);

            [MethodImpl(Inline)]   
            public byte or(byte a, byte b) 
                => (byte)(a | b);

            [MethodImpl(Inline)]   
            public byte xor(byte a, byte b) 
                => (byte)(a ^ b);

            [MethodImpl(Inline)]   
            public byte lshift(byte a, int shift) 
                => (byte)(a << shift);

            [MethodImpl(Inline)]   
            public byte rshift(byte a, int shift) 
                => (byte)(a >> shift);

            [MethodImpl(Inline)]   
            public byte flip(byte a) 
                => (byte)~ a;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(byte src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<byte>());


            [MethodImpl(Inline)]   
            public BitString bitstring(byte src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(byte src, int pos)
                => (src & (1 << pos)) != 0;
        
            [MethodImpl(Inline)]
            public bit[] bits(byte src)
            {                
                var bitsize = 8;
                var maxidx = 7;
                var dst = array<bit>(bitsize);
                for(var i = 0; i < bitsize; i++)
                    dst[maxidx - i] = testbit(src,i);
                return dst; 
            }

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(byte src)
                => array(src);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(byte src)
                => countLeadingOff((ushort)src) - 8;

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(byte src)
                => countTrailingOff((uint)src);
        }
    }
}
    public static partial class BitwiseX
    {
        [MethodImpl(Inline)]
        public static byte LShift(this byte src, int shift)
            => (byte)(src << shift);

        [MethodImpl(Inline)]
        public static byte RShift(this byte src, int shift)
            => (byte)(src >> shift);

        [MethodImpl(Inline)]
        public static byte And(this byte lhs, byte rhs)
            => (byte)(lhs & rhs);
            
        [MethodImpl(Inline)]
        public static byte Or(this byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        public static byte XOr(this byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public static byte Flip(this byte src)
            => (byte)(~src);

        [MethodImpl(Inline)]
        public static bool TestBit(this byte src, int pos)
            => (src & (1 << pos)) != 0;
    }
}

