//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte abs(sbyte src)
            => (sbyte)(src + (src >> 7)^(src >> 7));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short abs(short src)
            => (short)(src + (src >> 15)^(src >> 15));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int abs(int src)
            => (src + (src >> 31)^(src >> 31));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long abs(long src)
            => (src + (src >> 63)^(src >> 63));         

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float abs(float src)
            => MathF.Abs(src);

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double abs(double src)
            => Math.Abs(src);
 
        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte abs(ref sbyte src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short abs(ref short src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int abs(ref int src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long abs(ref long src)
        {
            src = abs(src);
            return ref src;
        }
 
        public static Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.abs(src[i]);
            return dst;
        }

        public static Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        public static Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }

        public static Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] =math.abs(src[i]);
            return dst;
        }
    
        public static Span<sbyte> abs(Span<sbyte> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.abs(ref src[i]);
            return src;
        }

        public static Span<short> abs(Span<short> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.abs(ref src[i]);
            return src;
        }

        public static Span<int> abs(Span<int> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.abs(ref src[i]);
            return src;
        }

        public static Span<long> abs(Span<long> src)
        {
            for(var i = 0; i< src.Length; i++)
                math.abs(ref src[i]);
            return src;
        } 
    }
}