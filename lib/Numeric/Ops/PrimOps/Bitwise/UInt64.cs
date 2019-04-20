//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static Operative;

    using target = System.UInt64;
    using targets = Index<ulong>;

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
            public target lshift(target lhs, int rhs) 
                => lhs << rhs;

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
            public static string bitchars64(target src)
                => apply(Bits.unpack(src), parts 
                    => bitcharsu32(parts.x0) + bitcharsu32(parts.x1));

            [MethodImpl(Inline)]
            public string bitchars(target src)
                => bitchars64(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => (src & (1ul << pos)) != 0ul;

            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }


        }
    }
}}

