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
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte dec(sbyte src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte dec(byte src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short dec(short src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort dec(ushort src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int dec(int src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint dec(uint src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long dec(long src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong dec(ulong src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float dec(float src)
            => --src;

        /// <summary>
        /// Decrements the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double dec(double src)
            => --src;

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte dec(ref sbyte src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte dec(ref byte src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short dec(ref short src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort dec(ref ushort src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int dec(ref int src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref uint dec(ref uint src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long dec(ref long src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ulong dec(ref ulong src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float dec(ref float src)
        {
            src--;
            return ref src;
        }

        /// <summary>
        /// Decrements the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double dec(ref double src)
        {
            src--;
            return ref src;
        }
 
        
        public static Span<sbyte> dec(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<byte> dec(ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<short> dec(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<ushort> dec(ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<int> dec(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<uint> dec(ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<long> dec(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<ulong> dec(ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<float> dec(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;
        }

        public static Span<double> dec(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = dec(src[i]);
            return dst;                
        }

        public static Span<sbyte> dec(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<byte> dec(Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<short> dec(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<ushort> dec(Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<int> dec(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<uint> dec(Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<long> dec(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<ulong> dec(Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<float> dec(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }

        public static Span<double> dec(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                dec(ref io[i]);
            return io;
        }
 

    }
}