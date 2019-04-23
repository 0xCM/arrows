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

    public static class AddX
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
        public static Span<sbyte> Add(this Span<sbyte> lhs, Span<sbyte> rhs)
            => fuse(lhs, rhs,(x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        public static Span<byte> Add(this Span<byte> lhs, Span<byte> rhs)
            => fuse(lhs,rhs,(x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        public static Span<short> Add(this Span<short> lhs, Span<short> rhs)
            => fuse(lhs,rhs,(x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        public static Span<ushort> Add(this Span<ushort> lhs, Span<ushort> rhs)
            => fuse(lhs,rhs,(x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        public static Span<int> Add(this Span<int> lhs, Span<int> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<uint> Add(this Span<uint> lhs, Span<uint> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<long> Add(this Span<long> lhs, Span<long> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<ulong> Add(this Span<ulong> lhs, Span<ulong> rhs)
            => fuse(lhs, rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<float> Add(this Span<float> lhs, Span<float> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<double> Add(this Span<double> lhs, Span<double> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<decimal> Add(this Span<decimal> lhs, Span<decimal> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);

        [MethodImpl(Inline)]
        public static Span<BigInteger> Add(this Span<BigInteger> lhs, Span<BigInteger> rhs)
            => fuse(lhs,rhs,(x,y) => x + y);
    


    }

}