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
        /// Computes the square root of each source cell and stores the result int the corresponding target cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target span</param>
        public static ReadOnlySpan<float> Sqrt(this ReadOnlySpan<float> src, Span<float> dst )
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                fmath.sqrt(src[i], ref dst[i]);
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
                fmath.sqrt(src[i], ref dst[i]);
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