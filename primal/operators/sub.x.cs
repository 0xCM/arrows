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
        public static Span<byte> Sub(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.sub(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> Sub(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.sub(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> Sub(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.sub(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> Sub(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.sub(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> Sub(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.sub(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> Sub(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.sub(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> Sub(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.sub(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> Sub(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.sub(lhs, rhs, span<ulong>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<float> Sub(this ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => math.sub(lhs, rhs, span<float>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<double> Sub(this ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => math.sub(lhs, rhs, span<double>(length(lhs,rhs)));

    }
}