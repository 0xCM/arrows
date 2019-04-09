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
            // !! short
            // !! -------------------------------------------------------------
            
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
            public BitString bitstring(short src) 
                => BitString.define(src);

            /// <summary>
            /// Extracts the data contained in the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(short src)
                => BitConverter.GetBytes(src); 

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(short src, int pos)
                => (src & (1 << pos)) != 0;


            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(short src)
                => countTrailingOff((int)src);


        }
    }
}}

