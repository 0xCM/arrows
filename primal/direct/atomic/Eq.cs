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

    partial class math
    {
        [MethodImpl(Inline)]
        public static bool eq(sbyte lhs, sbyte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(byte lhs, byte rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(short lhs, short rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ushort lhs, ushort rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(int lhs, int rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(uint lhs, uint rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(long lhs, long rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(ulong lhs, ulong rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(float lhs, float rhs)
            => lhs == rhs;

        [MethodImpl(Inline)]
        public static bool eq(double lhs, double rhs)
            => lhs == rhs;
 
        public static Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> eq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => eq(lhs,rhs, span<bool>(length(lhs,rhs)));
 
    }

}