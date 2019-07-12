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
		/// <param name="n">The number of elements in the source array</param>
		/// <param name="src">The source array</param>
		/// <param name="dst">The target array allocated by the caller</param>
        [MethodImpl(Inline)]
        public static Span<float> vabs(Span<float> src, Span<float> dst)        
        {
            VML.vsAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }
            
		/// <summary>
		/// Computes dst[i] = |src[i]| for i=0..n-1
		/// </summary>
		/// <param name="n">The number of elements in the source array</param>
		/// <param name="src">The source array</param>
		/// <param name="dst">The target array allocated by the caller</param>
        [MethodImpl(Inline)]
        public static Span<double> vabs(Span<double> src, Span<double> dst)        
        {
            VML.vdAbs(src.Length, ref head(src), ref head(dst));
            return dst;
        }

    }

}