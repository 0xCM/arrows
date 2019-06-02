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
        public static sbyte Dot(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static byte Dot(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static short Dot(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ushort Dot(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static int Dot(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint Dot(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static long Dot(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ulong Dot(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static float Dot(this ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => math.dot(lhs,rhs);

        [MethodImpl(Inline)]
        public static double Dot(this ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => math.dot(lhs,rhs);

    }


}