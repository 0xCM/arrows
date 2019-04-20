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

    using target = System.Int64;
    using targets = Index<long>;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {

            [MethodImpl(Inline)]   
            public target and(target a, target b) 
                => a & b;

            [MethodImpl(Inline)]
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);

            [MethodImpl(Inline)]   
            public target or(target a, target b) 
                => a | b;

            [MethodImpl(Inline)]
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]   
            public target xor(target a, target b) 
                => a ^ b;

            [MethodImpl(Inline)]
            public targets xor(targets lhs, targets rhs)
                => fuse(lhs,rhs, xor, out target[] dst);

            [MethodImpl(Inline)]   
            public target lshift(target a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public target rshift(target a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public target flip(target a) 
                => ~ a;

            [MethodImpl(Inline)]
            public targets flip(targets lhs)
                => map(lhs,flip);

            [MethodImpl(Inline)]
            public string bitchars(target src)
                => lpadZ(Convert.ToString(src,2), primops.bitsize<target>());

            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => (src & (1L << pos)) != 0L;

            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }
            
            [MethodImpl(Inline)]
            public static int countTrailingOff(target src)
                => BitOperations.TrailingZeroCount(src);


        }
    }
}}

