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
        public static bool gteq(sbyte lhs, sbyte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(byte lhs, byte rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(short lhs, short rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ushort lhs, ushort rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(int lhs, int rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(uint lhs, uint rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(long lhs, long rhs)
            => lhs >= rhs;

        [MethodImpl(Inline)]
        public static bool gteq(ulong lhs, ulong rhs)
            => lhs >= rhs;

        public static Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));
    }
}