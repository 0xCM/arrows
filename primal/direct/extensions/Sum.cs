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
    
    partial class MathX
    {
        public static byte Sum(this ReadOnlySpan<byte> src)
        {
            byte dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static sbyte Sum(this ReadOnlySpan<sbyte> src)
        {
            sbyte dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static short Sum(this ReadOnlySpan<short> src)
        {
            short dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static ushort Sum(this ReadOnlySpan<ushort> src)
        {
            ushort dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static int Sum(this ReadOnlySpan<int> src)
        {
            int dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static uint Sum(this ReadOnlySpan<uint> src)
        {
            uint dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static long Sum(this ReadOnlySpan<long> src)
        {
            long dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static ulong Sum(this ReadOnlySpan<ulong> src)
        {
            ulong dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static float Sum(this ReadOnlySpan<float> src)
        {
            float dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        public static double Sum(this ReadOnlySpan<double> src)
        {
            double dst = 0;
            for(var i=0; i<src.Length; i++)
                dst += src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static byte Sum(this Span<byte> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static sbyte Sum(this Span<sbyte> src)
            => src.ToReadOnlySpan().Sum();
    

        [MethodImpl(Inline)]
        public static short Sum(this Span<short> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static ushort Sum(this Span<ushort> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static int Sum(this Span<int> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static uint Sum(this Span<uint> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static long Sum(this Span<long> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static ulong Sum(this Span<ulong> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static float Sum(this Span<float> src)
            => src.ToReadOnlySpan().Sum();

        [MethodImpl(Inline)]
        public static double Sum(this Span<double> src)
            => src.ToReadOnlySpan().Sum();

    }

}