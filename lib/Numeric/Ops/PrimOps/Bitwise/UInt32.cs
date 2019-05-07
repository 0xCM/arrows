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
    using static zfunc;

    using static Operative;
    using static Bits;

    using uints = Index<uint>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<uint> 
        {
            [MethodImpl(Inline)]   
            public uint and(uint lhs, uint rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public uints and(uints lhs, uints rhs)
                => fuse(lhs,rhs, and, out uint[] dst);


            [MethodImpl(Inline)]   
            public uint or(uint a, uint b) 
                => (uint)(a | b);

            [MethodImpl(Inline)]
            public uints or(uints lhs, uints rhs)
                => fuse(lhs,rhs, or, out uint[] dst);

            [MethodImpl(Inline)]   
            public uint xor(uint a, uint b) 
                => (uint)(a ^ b);

            [MethodImpl(Inline)]
            public uints xor(uints lhs, uints rhs)
                => fuse(lhs,rhs, xor, out uint[] dst);

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
            public uints flip(uints lhs)
                => map(lhs,flip);

            [MethodImpl(Inline)]
            static string bitcharsu32(uint src)
                => zpad(Convert.ToString(src,2), primops.bitsize<uint>());

            [MethodImpl(Inline)]
            public string bitchars(uint src)
                => bitcharsu32(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(uint src) 
                => BitString.define(bit.Parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(uint src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(uint src, int pos)
                => (src & (1u << pos)) != 0u;

            [MethodImpl(Inline)]
            public bit[] bits(uint src)
            {
                var dst = array<bit>(SizeOf<uint>.BitSize);
                for(var i = 0; i < SizeOf<uint>.BitSize; i++)
                    dst[i] = testbit(src,i);
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

