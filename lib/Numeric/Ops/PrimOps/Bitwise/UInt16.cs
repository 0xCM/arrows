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

    
    using ushorts = Index<ushort>;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Bitwise : 
            Bitwise<ushort> 
        {

            [MethodImpl(Inline)]   
            public ushort and(ushort a, ushort b) 
                => (ushort)(a & b);

            [MethodImpl(Inline)]
            public ushorts and(ushorts lhs, ushorts rhs)
                => fuse(lhs,rhs, and, out ushort[] dst);

            [MethodImpl(Inline)]   
            public ushort or(ushort a, ushort b) 
                => (ushort)(a | b);

            [MethodImpl(Inline)]
            public ushorts or(ushorts lhs, ushorts rhs)
                => fuse(lhs,rhs, or, out ushort[] dst);

            [MethodImpl(Inline)]   
            public ushort xor(ushort a, ushort b) 
                => (ushort)(a ^ b);

            [MethodImpl(Inline)]
            public ushorts xor(ushorts lhs, ushorts rhs)
                => fuse(lhs,rhs, xor, out ushort[] dst);

            [MethodImpl(Inline)]   
            public ushort lshift(ushort a, int shift) 
                => (ushort)(a << shift);

            [MethodImpl(Inline)]   
            public ushort rshift(ushort a, int shift) 
                => (ushort)(a >> shift);

            [MethodImpl(Inline)]   
            public ushort flip(ushort a) 
                => (ushort)~ a;

            [MethodImpl(Inline)]
            public ushorts flip(ushorts lhs)
                => map(lhs,flip);

            [MethodImpl(Inline)]
            public string bitchars(ushort src)
                => zpad(Convert.ToString(src,2), primops.bitsize<ushort>());

            [MethodImpl(Inline)]   
            public BitString bitstring(ushort src) 
                => BitString.define(bit.Parse(bitchars(src)));

            [MethodImpl(Inline)]
            public bool testbit(ushort src, int pos)
                => (src & (1 << pos)) != 0;

            [MethodImpl(Inline)]
            public bit[] bits(ushort src)
            {
                var dst = array<bit>(SizeOf<ushort>.BitSize);
                for(var i = 0; i < SizeOf<ushort>.BitSize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }
            
            [MethodImpl(Inline)]
            public byte[] bytes(ushort src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public static int countLeadingOff(ushort src)
                => countLeadingOff((uint)src) - 16;

            [MethodImpl(Inline)]
            public static int countTrailingOff(ushort src)
                => countTrailingOff((uint)src);
        }
    }
}


}

