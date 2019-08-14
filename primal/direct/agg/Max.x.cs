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
        public static sbyte Max(this Span<sbyte> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this Span<byte> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static short Max(this Span<short> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this Span<ushort> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static int Max(this Span<int> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this Span<uint> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static long Max(this Span<long> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this Span<ulong> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static float Max(this Span<float> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static double Max(this Span<double> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static sbyte Max(this ReadOnlySpan<sbyte> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this ReadOnlySpan<byte> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static short Max(this ReadOnlySpan<short> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this ReadOnlySpan<ushort> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static int Max(this ReadOnlySpan<int> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this ReadOnlySpan<uint> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static long Max(this ReadOnlySpan<long> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this ReadOnlySpan<ulong> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static float Max(this ReadOnlySpan<float> src)
            => math.max(src);

        [MethodImpl(Inline)]
        public static double Max(this ReadOnlySpan<double> src)
            => math.max(src);
    }

}