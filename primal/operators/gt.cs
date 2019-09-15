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
        public static bool gt(sbyte lhs, sbyte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(byte lhs, byte rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(short lhs, short rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ushort lhs, ushort rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(int lhs, int rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(uint lhs, uint rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(long lhs, long rhs)
            => lhs > rhs;

        [MethodImpl(Inline)]
        public static bool gt(ulong lhs, ulong rhs)
            => lhs > rhs;


        public static Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));
    }
}