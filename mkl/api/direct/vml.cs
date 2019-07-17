//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
     using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class mkl
    {            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i=0..n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The target array allocated by the caller</param>
        [MethodImpl(Inline)]
        public static Span<float> vabs(Span<float> src, Span<float> dst)        
        {
            VML.vsAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i = 0...n-1
		/// </summary>
		/// <param name="src">The source array</param>
		/// <param name="dst">The target array allocated by the caller</param>
        [MethodImpl(Inline)]
        public static Span<double> vabs(Span<double> src, Span<double> dst)        
        {
            VML.vdAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
  		/// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<float> vadd(Span<float> lhs, Span<float> rhs, Span<float> dst)
        {
            VML.vsAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }

		/// <summary>
		/// Computes dst[i] = lhs[i] + rhs[i] for i = 0...n-1
		/// </summary>
		/// <param name="lhs">The left vector</param>
  		/// <param name="rhs">The right vector</param>
  		/// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static Span<double> vadd(Span<double> lhs, Span<double> rhs, Span<double> dst)
        {
            VML.vdAdd(length(lhs,rhs), ref head(lhs), ref head(rhs), ref head(dst));
            return dst;
        }
    }

}