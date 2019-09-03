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
        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte inc(sbyte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte inc(byte src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short inc(short src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort inc(ushort src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int inc(int src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint inc(uint src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long inc(long src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong inc(ulong src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float inc(float src)
            => ++src;

        /// <summary>
        /// Increments the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double inc(double src)
            => ++src;

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte inc(ref sbyte src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte inc(ref byte src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short inc(ref short src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort inc(ref ushort src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int inc(ref int src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref uint inc(ref uint src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long inc(ref long src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ulong inc(ref ulong src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float inc(ref float src)
        {
            src++;
            return ref src;
        }

        /// <summary>
        /// Increments the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double inc(ref double src)
        {
            src++;
            return ref src;
        }
 
        public static Span<sbyte> inc(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<byte> inc(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<short> inc(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<ushort> inc(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<int> inc(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static  Span<uint> inc(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<long> inc(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<ulong> inc(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<float> inc(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<double> inc(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = inc(src[i]);
            return dst;
        }

        public static Span<sbyte> inc(Span<sbyte> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<byte> inc(Span<byte> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<short> inc(Span<short> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<ushort> inc(Span<ushort> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<int> inc(Span<int> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<uint> inc(Span<uint> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<long> inc(Span<long> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<ulong> inc(Span<ulong> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<float> inc(Span<float> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

        public static Span<double> inc(Span<double> src)
        {
            for(var i = 0; i< src.Length; i++)
                inc(ref src[i]);
            return src;
        }

    }
}