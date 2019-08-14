//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;    

    partial class MathX
    {


        [MethodImpl(Inline)]
        public static Span<byte> Add(this Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<sbyte> Add(this Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<short> Add(this Span<short> lhs, ReadOnlySpan<short> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ushort> Add(this Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<int> Add(this Span<int> lhs, ReadOnlySpan<int> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<uint> Add(this Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<long> Add(this Span<long> lhs, ReadOnlySpan<long> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ulong> Add(this Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<float> Add(this Span<float> lhs, ReadOnlySpan<float> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<double> Add(this Span<double> lhs, ReadOnlySpan<double> rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<byte> Add(this byte[] lhs, byte[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<sbyte> Add(this sbyte[] lhs, sbyte[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<short> Add(this short[] lhs, short[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ushort> Add(this ushort[] lhs, ushort[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<int> Add(this int[] lhs, int[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<uint> Add(this uint[] lhs, uint[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<long> Add(this long[] lhs, long[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ulong> Add(this ulong[] lhs, ulong[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<float> Add(this float[] lhs, float[] rhs)
            => math.add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<double> Add(this double[] lhs, double[] rhs)
            => math.add(lhs, rhs);


    }
}