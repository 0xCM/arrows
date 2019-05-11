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

    
    using static mfunc;

    partial class math
    {
        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));



    }
}