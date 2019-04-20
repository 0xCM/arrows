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
    
    using target = System.UInt16;
    using targets = System.Collections.Generic.IReadOnlyList<ushort>;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {

            [MethodImpl(Inline)]   
            public target and(target a, target b) 
                => (target)(a & b);

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
                => (target)(a << shift);

            [MethodImpl(Inline)]   
            public target rshift(target a, int shift) 
                => (target)(a >> shift);

            [MethodImpl(Inline)]   
            public target flip(target a) 
                => (target)~ a;

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
            public bool testbit(target src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }
            
            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public static int countLeadingOff(target src)
                => countLeadingOff((uint)src) - 16;

            [MethodImpl(Inline)]
            public static int countTrailingOff(target src)
                => countTrailingOff((uint)src);
        }
    }
}


}

