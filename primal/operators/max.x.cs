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
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this Span<byte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static short Max(this Span<short> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this Span<ushort> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static int Max(this Span<int> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this Span<uint> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static long Max(this Span<long> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this Span<ulong> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static float Max(this Span<float> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static double Max(this Span<double> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static sbyte Max(this ReadOnlySpan<sbyte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static byte Max(this ReadOnlySpan<byte> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static short Max(this ReadOnlySpan<short> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ushort Max(this ReadOnlySpan<ushort> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static int Max(this ReadOnlySpan<int> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static uint Max(this ReadOnlySpan<uint> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static long Max(this ReadOnlySpan<long> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static ulong Max(this ReadOnlySpan<ulong> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static float Max(this ReadOnlySpan<float> src)
            => mathspan.max(src);

        [MethodImpl(Inline)]
        public static double Max(this ReadOnlySpan<double> src)
            => mathspan.max(src);
    }

}