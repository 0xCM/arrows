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
    using static zfunc;

    using static Operative;

    using decimals = Index<decimal>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            IBitwiseOps<decimal> 
        {

            [MethodImpl(Inline)]   
            public decimal and(decimal lhs, decimal rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public decimals and(decimals lhs, decimals rhs)
                => fuse(lhs,rhs, and, out decimal[] dst);

            [MethodImpl(Inline)]   
            public decimal or(decimal lhs, decimal rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public decimal xor(decimal lhs, decimal rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public decimal flip(decimal x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public decimal lshift(decimal lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public decimal rshift(decimal lhs, int rhs)
                => (long)lhs >> rhs;

            [MethodImpl(Inline)]
            public static string bitchars128(decimal src)
                => apply(Bits.split(src), 
                        parts => append(
                            bitchars32(parts.x0), 
                            bitchars32(parts.x1),
                            bitchars32(parts.x2), 
                            bitchars32(parts.x3))
                            );

            [MethodImpl(Inline)]
            public string bitchars(decimal src)
                => bitchars128(src);
            
            [MethodImpl(Inline)]   
            public BitString bitstring(decimal src) 
                => BitString.define(Bit.Parse(bitchars(src)));

            [MethodImpl(Inline)]
            public bool testbit(decimal src, int pos)
            {
                var bits = decimal.GetBits(src);
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
            public byte[] bytes(decimal src)
                => zcore.concat(map(decimal.GetBits(src), bytes));

            [MethodImpl(Inline)]
            public Bit[] bits(decimal src)
            {
                var dst = array<Bit>(SizeOf<decimal>.BitSize);
                for(var i = 0; i < SizeOf<decimal>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }

            [MethodImpl(Inline)]
            public decimals or(decimals lhs, decimals rhs)
                => fuse(lhs,rhs, or, out decimal[] dst);

            [MethodImpl(Inline)]
            public decimals xor(decimals lhs, decimals rhs)
                => fuse(lhs,rhs, xor, out decimal[] dst);

            [MethodImpl(Inline)]
            public decimals flip(decimals lhs)
                => map(lhs,flip);
        }
    }
}}

