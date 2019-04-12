//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    using static Bits;
    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<uint> 
        {
            [MethodImpl(Inline)]   
            public uint and(uint a, uint b) 
                => a & b;

            [MethodImpl(Inline)]   
            public uint or(uint a, uint b) 
                => a | b;

            [MethodImpl(Inline)]   
            public uint xor(uint a, uint b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public uint lshift(uint a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public uint rshift(uint lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public uint flip(uint src) 
                => ~ src;

            [MethodImpl(Inline)]
            static string bitcharsu32(uint src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<uint>());

            [MethodImpl(Inline)]
            public string bitchars(uint src)
                => bitcharsu32(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(uint src) 
                => BitString.define(Bits.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(uint src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(uint src, int pos)
                => (src & (1u << pos)) != 0u;

            [MethodImpl(Inline)]
            public bit[] bits(uint src)
            {
                var bitsize = 32;
                var maxidx = bitsize - 1;
                var dst = array<bit>(bitsize); 
                for(var i=0; i<= maxidx; i++)               
                    dst[maxidx-i] = src & (1u << i);
                return dst;
            }

            /// <summary>
            /// Rotates the source bits leftward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static uint lrot(uint src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Rotates the source bits rightward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static uint rrot(uint src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(uint src)
                => BitOperations.LeadingZeroCount(src);

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(uint src)
                => BitOperations.TrailingZeroCount(src);

        }
    }
}}

