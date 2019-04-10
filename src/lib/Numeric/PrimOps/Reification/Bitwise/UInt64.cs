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
            Bitwise<ulong> 
        {
            [MethodImpl(Inline)]   
            public ulong and(ulong a, ulong b) 
                => a & b;

            [MethodImpl(Inline)]   
            public ulong or(ulong a, ulong b) 
                => a | b;

            [MethodImpl(Inline)]   
            public ulong xor(ulong a, ulong b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public ulong lshift(ulong lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public ulong rshift(ulong lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public ulong flip(ulong src) 
                => ~ src;


            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public static string bitchars64(ulong src)
                => apply(Bits.split(src), parts 
                    => bitcharsu32(parts.hi) + bitcharsu32(parts.lo));


            [MethodImpl(Inline)]
            public string bitchars(ulong src)
                => bitchars64(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(ulong src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Extracts the data contained in the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(ulong src)
                => BitConverter.GetBytes(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(ulong src, int pos)
                => (src & (1ul << pos)) != 0ul;


            /// <summary>
            /// Rotates the source bits leftward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static ulong lrot(ulong src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Rotates the source bits rightward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static ulong rrot(ulong src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(ulong src)
                => BitOperations.LeadingZeroCount(src);

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(ulong src)
                => BitOperations.TrailingZeroCount(src);
        }
    }
}}

