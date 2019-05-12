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
    using static mfunc;
    
    using floats = Index<float>;

    partial class PrimOps { partial class Reify {

        [MethodImpl(Inline)]   
        static floats rshift(floats src, int shift)
        {
            float unaryShift(float x) => bitsf(bitsf(x) >> shift);
            return mapto(src,unaryShift, out float[] dst);
        }

        [MethodImpl(Inline)]   
        static floats lshift(floats src, int shift)
        {
            float unaryShift(float x) => bitsf(bitsf(x) << shift);            
            return mapto(src,unaryShift, out float[] dst);
        }

        public readonly partial struct Bitwise : 
            IBitwiseOps<float> 
        {
            [MethodImpl(Inline)]   
            public float and(float lhs, float rhs)
                => bitsf(bitsf(lhs) & bitsf(rhs));

            [MethodImpl(Inline)]   
            public floats and(floats lhs, floats rhs)
                => fuse(lhs,rhs, and, out float[] dst);

            [MethodImpl(Inline)]   
            public float or(float lhs, float rhs)
                => bitsf(bitsf(lhs) | bitsf(rhs));

            [MethodImpl(Inline)]   
            public floats or(floats lhs, floats rhs)
                => fuse(lhs,rhs, or, out float[] dst);

            [MethodImpl(Inline)]   
            public float xor(float lhs, float rhs)
                => bitsf(bitsf(lhs) ^ bitsf(rhs));

            [MethodImpl(Inline)]   
            public floats xor(floats lhs, floats rhs)
                => fuse(lhs,rhs, xor, out float[] dst);

            [MethodImpl(Inline)]   
            public float flip(float x)
                => bitsf(~bitsf(x));

            [MethodImpl(Inline)]   
            public floats flip(floats src)
                => map(src,flip);

            [MethodImpl(Inline)]   
            public float lshift(float lhs, int rhs)
                => bitsf(bitsf(lhs) << rhs);

            [MethodImpl(Inline)]   
            public floats lshift(floats src, int shift)
                => Reify.lshift(src,shift);

            [MethodImpl(Inline)]   
            public float rshift(float lhs, int rhs)
                => bitsf(bitsf(lhs) >> rhs);

            [MethodImpl(Inline)]   
            public floats rshift(floats src, int shift)
                => Reify.rshift(src,shift);
        


            [MethodImpl(Inline)]
            public byte[] Bytes(float src)
                => BitConverter.GetBytes(src);

            [MethodImpl(Inline)]
            public bool TestBit(float src, int pos)
                => TestBit(BitConverter.SingleToInt32Bits(src),pos);

            [MethodImpl(Inline)]
            public Bit[] Bits(float src)
                => Bits(BitConverter.SingleToInt32Bits(src));

                public string BitString(float src)
                {
                    throw new NotImplementedException();
                }
            }
    }
}}

