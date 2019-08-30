//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class MathX
    {
        
        [MethodImpl(Inline)]
        public static sbyte Avg(this Span<sbyte> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static byte Avg(this Span<byte> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static short Avg(this Span<short> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ushort Avg(this Span<ushort> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static int Avg(this Span<int> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static uint Avg(this Span<uint> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static long Avg(this Span<long> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ulong Avg(this Span<ulong> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this Span<float> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this Span<double> src)
            => math.avg(src);


        [MethodImpl(Inline)]
        public static sbyte Avg(this ReadOnlySpan<sbyte> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static byte Avg(this ReadOnlySpan<byte> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static short Avg(this ReadOnlySpan<short> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ushort Avg(this ReadOnlySpan<ushort> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static int Avg(this ReadOnlySpan<int> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static uint Avg(this ReadOnlySpan<uint> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static long Avg(this ReadOnlySpan<long> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ulong Avg(this ReadOnlySpan<ulong> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this ReadOnlySpan<float> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this ReadOnlySpan<double> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this Span256<float> src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this Span256<double> src)
            => math.avg(src);


        [MethodImpl(Inline)]
        public static sbyte Avg(this sbyte[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static byte Avg(this byte[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static short Avg(this short[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ushort Avg(this ushort[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static int Avg(this int[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static uint Avg(this uint[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static long Avg(this long[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static ulong Avg(this ulong[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static float Avg(this float[] src)
            => math.avg(src);

        [MethodImpl(Inline)]
        public static double Avg(this double[] src)
            => math.avg(src);


    }

}