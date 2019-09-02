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
        public static Span<sbyte> Mul(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<byte> Mul(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<short> Mul(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<ushort> Mul(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }
        public static Span<int> Mul(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }


        public static Span<uint> Mul(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<long> Mul(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return  dst;
        }

        public static Span<ulong> Mul(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<float> Mul(this ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, Span<float> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<double> Mul(this ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, Span<double> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = mul(lhs[i], rhs[i]);            
            return dst;
        }

        public static Span<sbyte> Mul(this Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<byte> Mul(this Span<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<short> Mul(this Span<short> lhs, ReadOnlySpan<short> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<ushort> Mul(this Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<int> Mul(this Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<uint> Mul(this Span<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<long> Mul(this Span<long> lhs, ReadOnlySpan<long> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<ulong> Mul(this Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<float> Mul(this Span<float> lhs, ReadOnlySpan<float> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }

        public static Span<double> Mul(this Span<double> lhs, ReadOnlySpan<double> rhs)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] *= rhs[i];
            return lhs;
        }
    }
}