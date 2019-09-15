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
        public static sbyte Min(this Span<sbyte> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static byte Min(this Span<byte> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static short Min(this Span<short> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static ushort Min(this Span<ushort> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static int Min(this Span<int> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static uint Min(this Span<uint> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static long Min(this Span<long> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static ulong Min(this Span<ulong> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static float Min(this Span<float> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static double Min(this Span<double> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static sbyte Min(this ReadOnlySpan<sbyte> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static byte Min(this ReadOnlySpan<byte> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static short Min(this ReadOnlySpan<short> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static ushort Min(this ReadOnlySpan<ushort> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static int Min(this ReadOnlySpan<int> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static uint Min(this ReadOnlySpan<uint> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static long Min(this ReadOnlySpan<long> src)
            => math.min(src);

        [MethodImpl(Inline)]
        public static ulong Min(this ReadOnlySpan<ulong> src)
            => math.min(src);

    }
}