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

    using longs = Index<long>;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            IBitwiseOps<long> 
        {

            [MethodImpl(Inline)]   
            public long and(long a, long b) 
                => a & b;

            [MethodImpl(Inline)]
            public longs and(longs lhs, longs rhs)
                => fuse(lhs,rhs, and, out long[] dst);

            [MethodImpl(Inline)]   
            public long or(long a, long b) 
                => a | b;

            [MethodImpl(Inline)]
            public longs or(longs lhs, longs rhs)
                => fuse(lhs,rhs, or, out long[] dst);

            [MethodImpl(Inline)]   
            public long xor(long a, long b) 
                => a ^ b;

            [MethodImpl(Inline)]
            public longs xor(longs lhs, longs rhs)
                => fuse(lhs,rhs, xor, out long[] dst);

            [MethodImpl(Inline)]   
            public long lshift(long a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public long rshift(long a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public long flip(long a) 
                => ~ a;

            [MethodImpl(Inline)]
            public longs flip(longs lhs)
                => map(lhs,flip);

            [MethodImpl(Inline)]
            public string BitString(long src)
                => Z0.Bits.bitstring(src);


            [MethodImpl(Inline)]
            public byte[] Bytes(long src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool TestBit(long src, int pos)
                => (src & (1L << pos)) != 0L;

            [MethodImpl(Inline)]
            public Bit[] Bits(long src)
            {
                var dst = array<Bit>(SizeOf<long>.BitSize);
                for(var i = 0; i < SizeOf<long>.BitSize; i++)
                    dst[i] = TestBit(src,i);
                return dst; 
            }
            
            [MethodImpl(Inline)]
            public static int countTrailingOff(long src)
                => BitOperations.TrailingZeroCount(src);


        }
    }
}}

