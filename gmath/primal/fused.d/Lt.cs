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
        public static Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lt(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<bool> dst)
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = lteq(lhs[i], rhs[i]);
            return dst;
        }
 
         [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));

        [MethodImpl(NotInline)]
        public static Span<bool> lteq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
            => lteq(lhs,rhs, span<bool>(length(lhs,rhs)));
    }
}