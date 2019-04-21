//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly struct Multiplicative : 
            Multiplicative<byte>, 
            Multiplicative<sbyte>, 
            Multiplicative<short>,
            Multiplicative<ushort>, 
            Multiplicative<int>,
            Multiplicative<uint>,
            Multiplicative<long>,
            Multiplicative<ulong>,            
            Multiplicative<float>, 
            Multiplicative<double>, 
            Multiplicative<decimal>,
            Multiplicative<BigInteger>                    
        {
            static readonly Multiplicative Inhabitant = default;

            [MethodImpl(Inline)]
            public static Multiplicative<T> Operator<T>() 
                => cast<Multiplicative<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public sbyte mul(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs * rhs);

            [MethodImpl(Inline)]
            public byte mul(byte lhs, byte rhs)
                => (byte)(lhs * rhs);

            [MethodImpl(Inline)]
            public short mul(short lhs, short rhs)
                => (short)(lhs * rhs);
        
            [MethodImpl(Inline)]
            public ushort mul(ushort lhs, ushort rhs)
                => (ushort)(lhs * rhs);

            [MethodImpl(Inline)]
            public int mul(int lhs, int rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public uint mul(uint lhs, uint rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public long mul(long lhs, long rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public ulong mul(ulong lhs, ulong rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public float mul(float lhs, float rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public double mul(double lhs, double rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public decimal mul(decimal lhs, decimal rhs)
                => lhs * rhs;

            [MethodImpl(Inline)]
            public BigInteger mul(BigInteger lhs, BigInteger rhs)
                => lhs * rhs;
        }

    }}

    partial class PrimalIndex
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Mul(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x * y));

        [MethodImpl(Inline)]
        public static Index<byte> Mul(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x * y));

        [MethodImpl(Inline)]
        public static Index<short> Mul(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x * y));

        [MethodImpl(Inline)]
        public static Index<ushort> Mul(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x * y));

        [MethodImpl(Inline)]
        public static Index<int> Mul(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<uint> Mul(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<long> Mul(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<ulong> Mul(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<float> Mul(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<double> Mul(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<decimal> Mul(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Mul(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

    }    
}