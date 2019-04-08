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
            Bitwise<sbyte> 


        {

            // !! sbyte
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public sbyte and(sbyte lhs, sbyte rhs) 
                => (sbyte)(lhs & rhs);

            [MethodImpl(Inline)]   
            public sbyte or(sbyte a, sbyte b) 
                => (sbyte)(a | b);

            [MethodImpl(Inline)]   
            public sbyte xor(sbyte a, sbyte b) 
                => (sbyte)(a ^ b);

            [MethodImpl(Inline)]   
            public sbyte lshift(sbyte a, int shift) 
                => (sbyte)(a << shift);

            [MethodImpl(Inline)]   
            public sbyte rshift(sbyte a, int shift) 
                => (sbyte)(a >> shift);

            [MethodImpl(Inline)]   
            public sbyte flip(sbyte a) 
                => (sbyte)~ a;
            
            /// <summary>
            /// Converts the source value to a sequence of bits
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]   
            public BitString bitstring(sbyte src) 
                => BitString.define(src);

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(sbyte src)
                => array((byte)src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(sbyte src, int pos)
                => (src & (1 << pos)) != 0;

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(sbyte src)
                => countTrailingOff((int)src);

        }
    }
}}

