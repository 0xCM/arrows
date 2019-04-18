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

    partial class PrimOps { public partial class Reify
    {
        public readonly struct Additive : 
            Additive<byte>, 
            Additive<sbyte>, 
            Additive<short>, 
            Additive<ushort>, 
            Additive<int>, 
            Additive<uint>,
            Additive<long>, 
            Additive<ulong>,
            Additive<float>, 
            Additive<double>, 
            Additive<decimal>,
            Additive<BigInteger>
                
        {
            static readonly Additive Inhabitant = default;

            [MethodImpl(Inline)]
            public static Additive<T> Operator<T>() 
                => cast<Additive<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte add(byte lhs, byte rhs)
                => (byte)(lhs + rhs);

            [MethodImpl(Inline)]
            public sbyte add(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs + rhs);

            [MethodImpl(Inline)]
            public ushort add(ushort lhs, ushort rhs)
                => (ushort)(lhs + rhs);

            [MethodImpl(Inline)]
            public short add(short lhs, short rhs)
                => (short)(lhs + rhs);

            [MethodImpl(Inline)]
            public int add(int lhs, int rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public uint add(uint lhs, uint rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public ulong add(ulong lhs, ulong rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public decimal add(decimal lhs, decimal rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public double add(double lhs, double rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public float add(float lhs, float rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public BigInteger add(BigInteger lhs, BigInteger rhs)
                => lhs + rhs;

            [MethodImpl(Inline)]
            public long add(long lhs, long rhs)
                => lhs + rhs;
        }

    }}

    public static partial class PrimalArray
    {

        [MethodImpl(Inline)]
        public static byte Add(this byte lhs, params byte[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static sbyte Add(this sbyte lhs, params sbyte[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static short Add(this short lhs, params short[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static ushort Add(this ushort lhs, params ushort[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static int Add(this int lhs, params int[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static uint Add(this uint lhs, params uint[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static long Add(this long lhs, params long[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static ulong Add(this ulong lhs, params ulong[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static float Add(this float lhs, params float[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static double Add(this double lhs, params double[] rhs)
        {
            var result = lhs;
            iter(rhs.Length, i => result += rhs[i]);
            return result;
        }

        [MethodImpl(Inline)]
        public static sbyte[] Add(this sbyte[] lhs, sbyte[] rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static byte[] Add(this byte[] lhs, params byte[] rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static short[] Add(this short[] lhs, params short[] rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static ushort[] Add(this ushort[] lhs, params ushort[] rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static int[] Add(this int[] lhs, params int[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static uint[] Add(this uint[] lhs, params uint[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static long[] Add(this long[] lhs, params long[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static ulong[] Add(this ulong[] lhs, params ulong[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static float[] Add(this float[] lhs, params float[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static double[] Add(this double[] lhs, params double[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static decimal[] Add(this decimal[] lhs, params decimal[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static BigInteger[] Add(this BigInteger[] lhs, params BigInteger[] rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

    }
    partial class PrimalList
    {

        [MethodImpl(Inline)]
        public static IReadOnlyList<sbyte> Add(this IReadOnlyList<sbyte> lhs, IReadOnlyList<sbyte> rhs)
            => fuse(lhs,rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<byte> Add(this IReadOnlyList<byte> lhs, IReadOnlyList<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<short> Add(this IReadOnlyList<short> lhs, IReadOnlyList<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<ushort> Add(this IReadOnlyList<ushort> lhs, IReadOnlyList<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static IReadOnlyList<int> Add(this IReadOnlyList<int> lhs, IReadOnlyList<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<uint> Add(this IReadOnlyList<uint> lhs, IReadOnlyList<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<long> Add(this IReadOnlyList<long> lhs, IReadOnlyList<long> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<ulong> Add(this IReadOnlyList<ulong> lhs, IReadOnlyList<ulong> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<float> Add(this IReadOnlyList<float> lhs, IReadOnlyList<float> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<double> Add(this IReadOnlyList<double> lhs, IReadOnlyList<double> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<decimal> Add(this IReadOnlyList<decimal> lhs, IReadOnlyList<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static IReadOnlyList<BigInteger> Add(this IReadOnlyList<BigInteger> lhs, IReadOnlyList<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

    }
}