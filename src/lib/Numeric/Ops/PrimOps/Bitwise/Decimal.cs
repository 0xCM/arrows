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

    using target = System.Decimal;
    using targets = System.Collections.Generic.IReadOnlyList<decimal>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {

            [MethodImpl(Inline)]   
            public target and(target lhs, target rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);

            [MethodImpl(Inline)]   
            public target or(target lhs, target rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public target xor(target lhs, target rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public target flip(target x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public target lshift(target lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public target rshift(target lhs, int rhs)
                => (long)lhs >> rhs;

            [MethodImpl(Inline)]
            public static string bitchars128(target src)
                => zcore.apply(Bits.split(src), 
                        parts => append(
                            bitchars32(parts.x0), 
                            bitchars32(parts.x1),
                            bitchars32(parts.x2), 
                            bitchars32(parts.x3))
                            );

            [MethodImpl(Inline)]
            public string bitchars(target src)
                => bitchars128(src);
            
            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
            {
                var bits = target.GetBits(src);
                if(pos < 32)
                    return testbit(bits[0], pos);
                if(pos < 64)
                    return testbit(bits[1], pos);
                if(pos < 96)
                    return testbit(bits[2], pos);
                if(pos < 128)
                    return testbit(bits[3], pos);
                throw new ArgumentException($"Bit position {pos} out of range");
            }

            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => zcore.concat(map(target.GetBits(src), bytes));

            [MethodImpl(Inline)]
            public bit[] bits(target src)
            {
                var dst = array<bit>(SizeOf<target>.BitSize);
                for(var i = 0; i < SizeOf<target>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }

            [MethodImpl(Inline)]
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]
            public targets xor(targets lhs, targets rhs)
                => fuse(lhs,rhs, xor, out target[] dst);

            [MethodImpl(Inline)]
            public targets flip(targets lhs)
                => map(lhs,flip);
        }
    }
}}

