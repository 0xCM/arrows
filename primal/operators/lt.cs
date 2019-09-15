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
        public static bool lt(sbyte lhs, sbyte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(byte lhs, byte rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(short lhs, short rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ushort lhs, ushort rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(int lhs, int rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(uint lhs, uint rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(long lhs, long rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(ulong lhs, ulong rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(float lhs, float rhs)
            => lhs < rhs;

        [MethodImpl(Inline)]
        public static bool lt(double lhs, double rhs)
            => lhs < rhs;
        
        public static Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

    }

}