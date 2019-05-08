//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static zcore;
    using static zfunc;

    using static Operative;
    
    
    using sbytes = Index<sbyte>;

    partial class PrimOps { partial class Reify {
        
        public readonly partial struct Bitwise : 
            IBitwiseOps<sbyte> 
        {
        
            [MethodImpl(Inline)]   
            public sbyte and(sbyte lhs, sbyte rhs) 
                => (sbyte)(lhs & rhs);

            [MethodImpl(Inline)]
            public sbytes and(sbytes lhs, sbytes rhs)
                => fuse(lhs,rhs, and, out sbyte[] dst);

            [MethodImpl(Inline)]   
            public sbyte or(sbyte lhs, sbyte rhs) 
                => (sbyte)(lhs | rhs);

            [MethodImpl(Inline)]
            public sbytes or(sbytes lhs, sbytes rhs)
                => fuse(lhs,rhs, or, out sbyte[] dst);

            [MethodImpl(Inline)]   
            public sbyte xor(sbyte a, sbyte b) 
                => (sbyte)(a ^ b);

            [MethodImpl(Inline)]
            public sbytes xor(sbytes lhs, sbytes rhs)
                => fuse(lhs,rhs, xor, out sbyte[] dst);

            [MethodImpl(Inline)]   
            public sbyte lshift(sbyte a, int shift) 
                => (sbyte)(a << shift);

            [MethodImpl(Inline)]   
            public sbyte rshift(sbyte a, int shift) 
                => (sbyte)(a >> shift);

            [MethodImpl(Inline)]   
            public sbyte flip(sbyte a) 
                => (sbyte)~ a;
            
            [MethodImpl(Inline)]
            public string bitchars(sbyte src)
                => zpad(Convert.ToString(src,2), primops.bitsize<sbyte>());

            [MethodImpl(Inline)]   
            public BitString bitstring(sbyte src) 
                => BitString.define(Bit.Parse(bitchars(src)));

            [MethodImpl(Inline)]
            public byte[] bytes(sbyte src)
                => array((byte)src);

            [MethodImpl(Inline)]
            public bool testbit(sbyte src, int pos)
                => Bits.testbit(src,pos);

            [MethodImpl(Inline)]
            public Bit[] bits(sbyte src)
            {
                var bitsize = SizeOf<sbyte>.BitSize;
                var dst = array<Bit>(bitsize);
                for(var i = 0; i < bitsize; i++)
                    dst[i] = testbit(src,i);
                return dst; 
            }

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(sbyte src)
                => countTrailingOff((int)src);


            [MethodImpl(Inline)]
            public sbytes flip(sbytes lhs)
                => map(lhs,flip);
    }
    }
}}

