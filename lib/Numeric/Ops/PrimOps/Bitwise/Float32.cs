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

    using target = System.Single;
    using targets = Index<float>;

    partial class PrimOps { partial class Reify {

        [MethodImpl(Inline)]   
        static targets rshift(targets src, int shift)
        {
            target unaryShift(target x) => bitsf(bitsf(x) >> shift);
            return mapto(src,unaryShift, out target[] dst);
        }

        [MethodImpl(Inline)]   
        static targets lshift(targets src, int shift)
        {
            target unaryShift(target x) => bitsf(bitsf(x) << shift);            
            return mapto(src,unaryShift, out target[] dst);
        }

        public readonly partial struct Bitwise : 
            Bitwise<target> 
        {
            [MethodImpl(Inline)]   
            public target and(target lhs, target rhs)
                => bitsf(bitsf(lhs) & bitsf(rhs));

            [MethodImpl(Inline)]   
            public targets and(targets lhs, targets rhs)
                => fuse(lhs,rhs, and, out target[] dst);

            [MethodImpl(Inline)]   
            public target or(target lhs, target rhs)
                => bitsf(bitsf(lhs) | bitsf(rhs));

            [MethodImpl(Inline)]   
            public targets or(targets lhs, targets rhs)
                => fuse(lhs,rhs, or, out target[] dst);

            [MethodImpl(Inline)]   
            public target xor(target lhs, target rhs)
                => bitsf(bitsf(lhs) ^ bitsf(rhs));

            [MethodImpl(Inline)]   
            public targets xor(targets lhs, targets rhs)
                => fuse(lhs,rhs, xor, out target[] dst);

            [MethodImpl(Inline)]   
            public target flip(target x)
                => bitsf(~bitsf(x));

            [MethodImpl(Inline)]   
            public targets flip(targets src)
                => map(src,flip);

            [MethodImpl(Inline)]   
            public target lshift(target lhs, int rhs)
                => bitsf(bitsf(lhs) << rhs);

            [MethodImpl(Inline)]   
            public targets lshift(targets src, int shift)
                => Reify.lshift(src,shift);

            [MethodImpl(Inline)]   
            public target rshift(target lhs, int rhs)
                => bitsf(bitsf(lhs) >> rhs);

            [MethodImpl(Inline)]   
            public targets rshift(targets src, int shift)
                => Reify.rshift(src,shift);
        
            [MethodImpl(Inline)]
            public string bitchars(target src)
                => bitchars(BitConverter.SingleToInt32Bits(src));
         
            [MethodImpl(Inline)]   
            public BitString bitstring(target src) 
                => BitString.define(bit.parse(bitchars(src)));


            [MethodImpl(Inline)]
            public byte[] bytes(target src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool testbit(target src, int pos)
                => testbit(BitConverter.SingleToInt32Bits(src),pos);

            [MethodImpl(Inline)]
            public bit[] bits(target src)
                => bits(BitConverter.SingleToInt32Bits(src));


        }
    }
}}

