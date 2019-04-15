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

    partial class PrimOps { partial class Reify {

        public readonly partial struct Bitwise : 
            Bitwise<int> 

        {

            [MethodImpl(Inline)]   
            public int and(int lhs, int rhs) 
                => lhs & rhs;

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
                => lpadZ(Convert.ToString(src,2), primops.bitsize<int>());

            [MethodImpl(Inline)]
            public string bitchars(int src)
                => bitchars32(src);

            [MethodImpl(Inline)]   
            public BitString bitstring(int src) 
                => BitString.define(Bits.parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(int src)
                => BitConverter.GetBytes(src); 

            [MethodImpl(Inline)]
            public bool testbit(int src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(int src)
            {
                var bitsize = 32;
                var maxidx = bitsize - 1;
                var dst = alloc<bit>(bitsize); 
                for(var i=0; i<= maxidx; i++)               
                    dst[maxidx-i] = src & (1 << i);
                return dst;
            }

        }
    }
}}