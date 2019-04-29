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

    using target = System.UInt32;
    using targets = Index<uint>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {
            [MethodImpl(Inline)]   
            public target and(target lhs, target rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);


            [MethodImpl(Inline)]   
            public target or(target a, target b) 
                => (target)(a | b);

            [MethodImpl(Inline)]
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]   
            public target xor(target a, target b) 
                => (target)(a ^ b);

            [MethodImpl(Inline)]
            public targets xor(targets lhs, targets rhs)
                => fuse(lhs,rhs, xor, out target[] dst);

            [MethodImpl(Inline)]   
            public target lshift(target a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public target rshift(target lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public target flip(target src) 
                => ~ src;

            [MethodImpl(Inline)]
            public targets flip(targets lhs)
                => map(lhs,flip);

            [MethodImpl(Inline)]
            static string bitcharsu32(target src)
                => zpad(Convert.ToString(src,2), primops.bitsize<target>());

            [MethodImpl(Inline)]
            public string bitchars(target src)
                => bitcharsu32(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => (src & (1u << pos)) != 0u;

            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }


            /// <summary>
            /// Rotates the source bits leftward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static target lrot(target src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Rotates the source bits rightward
            /// </summary>
            /// <param name="src">The source value</param>
            /// <param name="offset">The rotation magnitude</param>
            [MethodImpl(Inline)]
            public static target rrot(target src, int offset)            
                => BitOperations.RotateLeft(src,offset);

            /// <summary>
            /// Counts the number of leading zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countLeadingOff(target src)
                => BitOperations.LeadingZeroCount(src);

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(target src)
                => BitOperations.TrailingZeroCount(src);

        }
    }
}}

