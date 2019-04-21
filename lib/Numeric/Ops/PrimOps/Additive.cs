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

    partial class PrimalIndex
    {

        [MethodImpl(Inline)]
        public static Index<sbyte> Add(this Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static Index<byte> Add(this Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static Index<short> Add(this Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static Index<ushort> Add(this Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static Index<int> Add(this Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<uint> Add(this Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<long> Add(this Index<long> lhs, Index<long> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<ulong> Add(this Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<float> Add(this Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<double> Add(this Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<decimal> Add(this Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Index<BigInteger> Add(this Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

    }
}