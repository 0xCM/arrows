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
        public static ref sbyte Add(this ref sbyte lhs, sbyte rhs)
        {
            lhs = (sbyte) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref byte Add(this ref byte lhs, byte rhs)
        {
            lhs = (byte) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref short Add(this ref short lhs, short rhs)
        {
            lhs = (short) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ushort Add(this ref ushort lhs, ushort rhs)
        {
            lhs = (ushort) (lhs + rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref int Add(this ref int lhs, int rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref uint Add(this ref uint lhs, uint rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref long Add(this ref long lhs, long rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref ulong Add(this ref ulong lhs, ulong rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref float Add(this ref float lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref double Add(this ref double lhs, float rhs)
        {
            lhs = lhs + rhs;
            return ref lhs;
        }

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