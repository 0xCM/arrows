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

        public static byte Sum(this ReadOnlySpan<byte> src)
            => math.sum(src);

        public static sbyte Sum(this ReadOnlySpan<sbyte> src)
            => math.sum(src);

        public static short Sum(this ReadOnlySpan<short> src)
            => math.sum(src);

        public static ushort Sum(this ReadOnlySpan<ushort> src)
            => math.sum(src);

        public static int Sum(this ReadOnlySpan<int> src)
            => math.sum(src);

        public static uint Sum(this ReadOnlySpan<uint> src)
            => math.sum(src);

        public static long Sum(this ReadOnlySpan<long> src)
            => math.sum(src);

        public static ulong Sum(this ReadOnlySpan<ulong> src)
            => math.sum(src);

        public static float Sum(this ReadOnlySpan<float> src)
            => math.sum(src);

        public static double Sum(this ReadOnlySpan<double> src)
            => math.sum(src);

        [MethodImpl(Inline)]
        public static byte Sum(this Span<byte> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static sbyte Sum(this Span<sbyte> src)
            => src.ReadOnly().Sum();
    
        [MethodImpl(Inline)]
        public static short Sum(this Span<short> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static ushort Sum(this Span<ushort> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static int Sum(this Span<int> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static uint Sum(this Span<uint> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static long Sum(this Span<long> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static ulong Sum(this Span<ulong> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static float Sum(this Span<float> src)
            => src.ReadOnly().Sum();

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src)
            => src.ReadOnly().Sum();

    }

}