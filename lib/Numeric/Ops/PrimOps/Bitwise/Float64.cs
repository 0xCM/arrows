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
    using static mfunc;
    using static Operative;

    using doubles = Index<double>;

    partial class PrimOps { partial class Reify {

        [MethodImpl(Inline)]   
        static doubles rshift(doubles src, int shift)
        {
            double unaryShift(double x) => bitsf(bitsf(x) >> shift);
            return mapto(src,unaryShift, out double[] dst);
        }

        [MethodImpl(Inline)]   
        static doubles lshift(doubles src, int shift)
        {
            double unaryShift(double x) => bitsf(bitsf(x) << shift);            
            return mapto(src,unaryShift, out double[] dst);
        }

        public readonly partial struct Bitwise : 
            IBitwiseOps<double> 
        {
            
            [MethodImpl(Inline)]   
            public double and(double lhs, double rhs)
                => bitsf(bitsf(lhs) & bitsf(rhs));

            [MethodImpl(Inline)]   
            public doubles and(doubles lhs, doubles rhs)
                => fuse(lhs,rhs, and, out double[] dst);

            [MethodImpl(Inline)]   
            public double or(double lhs, double rhs)
                => bitsf(bitsf(lhs) | bitsf(rhs));

            [MethodImpl(Inline)]   
            public doubles or(doubles lhs, doubles rhs)
                => fuse(lhs,rhs, or, out double[] dst);

            [MethodImpl(Inline)]   
            public double xor(double lhs, double rhs)
                => bitsf(bitsf(lhs) ^ bitsf(rhs));

            [MethodImpl(Inline)]   
            public doubles xor(doubles lhs, doubles rhs)
                => fuse(lhs,rhs, xor, out double[] dst);

            [MethodImpl(Inline)]   
            public double flip(double x)
                => bitsf(~bitsf(x));

            [MethodImpl(Inline)]   
            public doubles flip(doubles src)
                => mapto(src,flip, out double[] dst);

            [MethodImpl(Inline)]   
            public double lshift(double lhs, int rhs)
                => bitsf(bitsf(lhs) << rhs);

            [MethodImpl(Inline)]   
            public doubles lshift(doubles src, int shift)
                => Reify.lshift(src,shift);

            [MethodImpl(Inline)]   
            public double rshift(double lhs, int rhs)
                => bitsf(bitsf(lhs) >> rhs);

            [MethodImpl(Inline)]   
            public doubles rshift(doubles src, int shift)
                => Reify.rshift(src,shift);

            [MethodImpl(Inline)]
            public string BitString(double src)
                => Z0.Bits.bitstring(src);

            [MethodImpl(Inline)]
            public bool TestBit(double src, int pos)
                => TestBit(bitsf(src),pos);

            [MethodImpl(Inline)]
            public Bit[] Bits(double src)
                => Bits(bitsf(src));

            public byte[] Bytes(double src)
                => Z0.Bits.bytes(src);
        }
    }
}}

