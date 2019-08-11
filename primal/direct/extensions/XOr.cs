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
        public static Span<byte> XOr(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.xor(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> XOr(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.xor(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> XOr(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.xor(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> XOr(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.xor(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> XOr(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.xor(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> XOr(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.xor(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> XOr(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.xor(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> XOr(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.xor(lhs, rhs, span<ulong>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<byte> XOr(this ref Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<sbyte> XOr(this ref Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<short> XOr(this ref Span<short> lhs, ReadOnlySpan<short> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ushort> XOr(this ref Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<int> XOr(this ref Span<int> lhs, ReadOnlySpan<int> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<uint> XOr(this ref Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<long> XOr(this ref Span<long> lhs, ReadOnlySpan<long> rhs)
            => math.xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ulong> XOr(this ref Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.xor(lhs, rhs);

    }

}