//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {
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
        public static ref float abs(ref float src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double abs(ref double src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source values and stores the results in the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="dst">The result receiver</param>
        public static Span<float> abs(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = abs(src[i]);
            return dst;
        }

        /// <summary>
        /// Computes the absolute value of the source values and stores the results in the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="dst">The result receiver</param>
        public static Span<double> abs(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                dst[i] = abs(src[i]);
            return dst;
        }

        /// <summary>
        /// Computes the absolute value of the source values in-place
        /// </summary>
        /// <param name="src">The source value</param>
        public static Span<float> abs(Span<float> src)
        {
            for(var i = 0; i< src.Length; i++)
                abs(ref src[i]);
            return src;
        }

        /// <summary>
        /// Computes the absolute value of the source values in-place
        /// </summary>
        /// <param name="src">The source value</param>
        public static Span<double> abs(Span<double> src)
        {
            for(var i = 0; i< src.Length; i++)
                abs(ref src[i]);
            return src;
        }  
 
    }

}