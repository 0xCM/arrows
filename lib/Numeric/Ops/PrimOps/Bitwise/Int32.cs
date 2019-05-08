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

    
    using ints = Index<int>;

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            IBitwiseOps<int> 

        {
            [MethodImpl(Inline)]   
            public int and(int lhs, int rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]
            public ints and(ints lhs, ints rhs)
                => fuse(lhs, rhs, and, out int[] dst);

            [MethodImpl(Inline)]   
            public int or(int lhs, int rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public int xor(int lhs, int rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public int lshift(int lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public int rshift(int lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public int flip(int src) 
                => ~ src;

            [MethodImpl(Inline)]
            public static string bitchars32(int src)
                => zpad(Convert.ToString(src,2), primops.bitsize<int>());

            [MethodImpl(Inline)]
            public string bitchars(int src)
                => bitchars32(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(int src) 
                => BitString.define(Bit.Parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(int src)
                => BitConverter.GetBytes(src); 

            [MethodImpl(Inline)]
            public bool testbit(int src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public Bit[] bits(int src)
            {
                var dst = array<Bit>(SizeOf<int>.BitSize);
                for(var i = 0; i < SizeOf<int>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }

            [MethodImpl(Inline)]
            public ints or(ints lhs, ints rhs)
                => fuse(lhs,rhs, or, out int[] dst);

            [MethodImpl(Inline)]
            public ints xor(ints lhs, ints rhs)
                => fuse(lhs,rhs, xor, out int[] dst);

            [MethodImpl(Inline)]
            public ints flip(ints lhs)
                => map(lhs,flip);

        }
    }
}}