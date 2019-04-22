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


}