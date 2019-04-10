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
            Bitwise<long> 
        {
            [MethodImpl(Inline)]   
            public long and(long a, long b) 
                => a & b;

            [MethodImpl(Inline)]   
            public long or(long a, long b) 
                => a | b;

            [MethodImpl(Inline)]   
            public long xor(long a, long b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public long lshift(long a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public long rshift(long a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public long flip(long a) 
                => ~ a;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(long src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<long>());

            [MethodImpl(Inline)]   
            public BitString bitstring(long src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Extracts the data contained in the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(long src)
                => BitConverter.GetBytes(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(long src, int pos)
                => (src & (1L << pos)) != 0L;

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(long src)
                => BitOperations.TrailingZeroCount(src);

        }
    }
}}

