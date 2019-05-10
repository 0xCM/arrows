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
        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
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

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => gt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
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

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<bool> gteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => gteq(lhs,rhs, span<bool>(length(lhs,rhs)));
 
 

    }
}