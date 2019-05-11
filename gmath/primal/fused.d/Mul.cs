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
        public static ref Span<sbyte> mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, ref Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<sbyte> mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static ref Span<byte> mul(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, ref Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<byte> mul(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static ref Span<short> mul(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, ref Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<short> mul(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<ushort> mul(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, ref Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ushort> mul(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<int> mul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, ref Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<int> mul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<uint> mul(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, ref Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<uint> mul(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<long> mul(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, ref Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<long> mul(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return  dst;
        }


        [MethodImpl(NotInline)]
        public static ref Span<ulong> mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, ref Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<ulong> mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<float> mul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, ref Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<float> mul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<double> mul(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, ref Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);            
            return ref dst;
        }

        [MethodImpl(NotInline)]
        public static Span<double> mul(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);            
            return dst;
        }


    }

}