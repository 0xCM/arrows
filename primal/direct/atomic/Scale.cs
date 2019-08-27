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
        public static Span<sbyte> scale(ReadOnlySpan<sbyte> src, sbyte factor, Span<sbyte> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<byte> scale(ReadOnlySpan<byte> src, byte factor, Span<byte> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<short> scale(ReadOnlySpan<short> src, short factor, Span<short> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<ushort> scale(ReadOnlySpan<ushort> src, ushort factor, Span<ushort> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<int> scale(ReadOnlySpan<int> src, int factor, Span<int> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<uint> scale(ReadOnlySpan<uint> src, uint factor, Span<uint> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<long> scale(ReadOnlySpan<long> src, long factor, Span<long> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<ulong> scale(ReadOnlySpan<ulong> src, ulong factor, Span<ulong> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<float> scale(ReadOnlySpan<float> src, float factor, Span<float> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }

        public static Span<double> scale(ReadOnlySpan<double> src, double factor, Span<double> dst)
        {
            for(var i = 0; i< dst.Length; i++)
                dst[i] = mul(src[i], factor);
            return dst;                
        }
    }
}