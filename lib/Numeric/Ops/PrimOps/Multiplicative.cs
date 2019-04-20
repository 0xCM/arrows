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

    partial class PrimalList
    {

        [MethodImpl(Inline)]
        public static IReadOnlyList<sbyte> Mul(this IReadOnlyList<sbyte> lhs, IReadOnlyList<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x * y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<byte> Mul(this IReadOnlyList<byte> lhs, IReadOnlyList<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x * y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<short> Mul(this IReadOnlyList<short> lhs, IReadOnlyList<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x * y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<ushort> Mul(this IReadOnlyList<ushort> lhs, IReadOnlyList<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x * y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> Mul(this IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<uint> Mul(this IReadOnlyList<uint> lhs, IReadOnlyList<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<long> Mul(this IReadOnlyList<long> lhs, IReadOnlyList<long> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<ulong> Mul(this IReadOnlyList<ulong> lhs, IReadOnlyList<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<float> Mul(this IReadOnlyList<float> lhs, IReadOnlyList<float> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<double> Mul(this IReadOnlyList<double> lhs, IReadOnlyList<double> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<decimal> Mul(this IReadOnlyList<decimal> lhs, IReadOnlyList<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<BigInteger> Mul(this IReadOnlyList<BigInteger> lhs, IReadOnlyList<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x * y);

    }    
}