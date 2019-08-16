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
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static nfunc;

    partial class mkl
    {
        /// <summary>
        /// Computes x = ax, in-place
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(float a, Vector<float> X)        
            => CBLAS.cblas_sscal(X.Length, a, ref head(X), 1);

        /// <summary>
        /// Computes y = ax, leaving x unmodified
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        /// <param name="y">The target vector</param>
        /// <remarks>This adds the overhead of a copy operation on the vector</remarks>
        [MethodImpl(Inline)]
        public static ref Vector<float> scale(float a, in Vector<float> x, ref Vector<float> y)        
        {
            CBLAS.cblas_sscal(x.Length, a, ref head(x.CopyTo(ref y)), 1);
            return ref y;
        }

        /// <summary>
        /// Computes x = ax, in-place
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(double a, Vector<double> x)        
            => CBLAS.cblas_dscal(x.Length, a, ref head(x), 1);

        /// <summary>
        /// Computes y = ax, leaving x unmodified
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="x">The source vector</param>
        /// <param name="y">The target vector</param>
        /// <remarks>This adds the overhead of a copy operation on the vector</remarks>
        [MethodImpl(Inline)]
        public static ref Vector<double> scale(double a, in Vector<double> x, ref Vector<double> y)        
        {
            CBLAS.cblas_dscal(x.Length, a, ref head(x.CopyTo(ref y)), 1);
            return ref y;
        }


    }

}