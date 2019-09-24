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
    
    partial class fpx
    {
        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float Sqrt(this ref float src)
            => ref fmath.sqrt(ref src);

        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double Sqrt(this ref double src)
            => ref fmath.sqrt(ref src);
 
         /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float Abs(this ref float src)
            => ref fmath.abs(ref src);

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double Abs(this ref double src)
            => ref fmath.abs(ref src);

        [MethodImpl(Inline)]
        public static float Round(this float src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static double Round(this double src, int scale)
            => fmath.round(src, scale);

        [MethodImpl(Inline)]
        public static float Truncate(this float src)
            => (int)src;

        [MethodImpl(Inline)]
        public static double Truncate(this double src)
            => (long)src;

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Round(this ReadOnlySpan<float> src, int scale, Span<float> dst)
            => fmath.round(src, scale, dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Round(this ReadOnlySpan<double> src, int scale, Span<double> dst )
            => fmath.round(src, scale, dst);            

        [MethodImpl(Inline)]
        public static Span<float> Round(this Span<float> src, int scale)
            => fmath.round(src, scale);            

        [MethodImpl(Inline)]
        public static Span<double> Round(this Span<double> src, int scale)
            => fmath.round(src, scale);            


        public static Span<float> Div(this Span<float> io, float rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        }

        public static Span<double> Div(this Span<double> io, double rhs)
        {
            for(var i=0; i< io.Length; i++)
                io[i] /= rhs;
            return io;                
        } 

        /// <summary>
        /// Computes the square root of each source cell and stores the result int the corresponding target cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        public static ReadOnlySpan<float> Sqrt(this ReadOnlySpan<float> src, Span<float> dst )
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                fmath.sqrt(in src[i], ref dst[i]);
            return dst;                
        }

        /// <summary>
        /// Computes the square root of each source cell and stores the result int the corresponding target cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        public static ReadOnlySpan<double> Sqrt(this ReadOnlySpan<double> src, Span<double> dst )
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                fmath.sqrt(in src[i], ref dst[i]);
            return dst;                
        }

        /// <summary>
        /// Computes the square root of each source cell in-place
        /// </summary>
        /// <param name="src">The source/target span</param>
        public static Span<float> Sqrt(this Span<float> src)
        {
            for(var i = 0; i< src.Length; i++)
                fmath.sqrt(ref src[i]);
            return src;
        }

        /// <summary>
        /// Computes the square root of each source cell in-place
        /// </summary>
        /// <param name="src">The source/target span</param>
        public static Span<double> Sqrt(this Span<double> src)
        {
            for(var i = 0; i< src.Length; i++)
                fmath.sqrt(ref src[i]);
            return src;
        }

    }
}