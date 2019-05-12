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
    using static zfunc;

    using static Operative;

    using bytes = Index<byte>;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            IBitwiseOps<byte> 
        {

            [MethodImpl(Inline)]   
            public byte and(byte lhs, byte rhs) 
                => (byte)(lhs & rhs);

            [MethodImpl(Inline)]
            public bytes and(bytes lhs, bytes rhs)
                => fuse(lhs,rhs, and, out byte[] dst);

            [MethodImpl(Inline)]   
            public byte or(byte lhs, byte rhs) 
                => (byte)(lhs | rhs);

            [MethodImpl(Inline)]
            public bytes or(bytes lhs, bytes rhs)
                => fuse(lhs,rhs, or, out byte[] dst);

            [MethodImpl(Inline)]   
            public byte xor(byte lhs, byte rhs) 
                => (byte)(lhs ^ rhs);

            [MethodImpl(Inline)]
            public bytes xor(bytes lhs, bytes rhs)
                => fuse(lhs,rhs, xor, out byte[] dst);

            [MethodImpl(Inline)]   
            public byte lshift(byte src, int shift) 
                => (byte)(src << shift);

            [MethodImpl(Inline)]   
            public byte rshift(byte a, int shift) 
                => (byte)(a >> shift);

            [MethodImpl(Inline)]   
            public byte flip(byte a) 
                => (byte)~ a;

            [MethodImpl(Inline)]
            public bytes flip(bytes lhs)
                => map(lhs,flip);

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string BitString(byte src)
                => Z0.Bits.bitstring(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool TestBit(byte src, int pos)
                => (src & (1 << pos)) != 0;
        
            [MethodImpl(Inline)]
            public Bit[] Bits(byte src)
            {
                var dst = array<Bit>(SizeOf<byte>.BitSize);
                for(var i = 0; i < SizeOf<byte>.BitSize; i++)
                    dst[i] = TestBit(src,i);
                return dst; 
            }

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] Bytes(byte src)
                => new byte[]{src};

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

}

