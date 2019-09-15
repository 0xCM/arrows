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
        [MethodImpl(Inline)]
        public static float pow(float src, float exp)
            => MathF.Pow(src,exp);

        [MethodImpl(Inline)]
        public static double pow(double src, double exp)
            => Math.Pow(src,exp);

        [MethodImpl(Inline)]
        public static ref float pow(ref float src, float exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double pow(ref double src, double exp)
        {
            src = pow(src,exp);
            return ref src;
        }

        public static Span<float> pow(Span<float> b, float exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<double> pow(Span<double> b, double exp)
        {
            for(var i = 0; i<b.Length; i++) 
                b[i] = pow(b[i], exp);
            return b;
        }

        public static Span<float> pow(Span<float> b, ReadOnlySpan<float> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }

        public static Span<double> pow(Span<double> b, ReadOnlySpan<double> exp)
        {
            var len =  length(b,exp);
            for(var i = 0; i<len; i++) 
                b[i] = pow(b[i], exp[i]);
            return b;
        }


        /// <summary>
        /// Computes the base-2 log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float log2(float src)
            => MathF.Log2(src);

        /// <summary>
        /// Computes the base-2 log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double log2(double src)
            => Math.Log2(src);

        /// <summary>
        /// Computes the base-e log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float ln(float src)
            => MathF.Log(src);

        /// <summary>
        /// Computes the base-e log of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double ln(double src)
            => Math.Log(src);

        /// <summary>
        /// Computes the log of the source value relative to an optionally-specified base
        /// which otherwise defaults to base-10
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="b">The log base</param>
        [MethodImpl(Inline)]
        public static float log(float src, float? b = null)
            => MathF.Log(src, b ?? 10);

        /// <summary>
        /// Computes the log of the source value relative to an optionally-specified base
        /// which otherwise defaults to base-10
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="b">The log base</param>
        [MethodImpl(Inline)]
        public static double log(double src, double? b = null)
            => Math.Log(src, b ?? 10);
    }

}