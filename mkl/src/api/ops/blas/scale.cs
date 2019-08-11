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
        /// Scales a source vector in-place, X = aX
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(float a, Vector<float> X)        
            => CBLAS.cblas_sscal(X.Length, a, ref head(X), 1);

        /// <summary>
        /// Scales a source vector in-place, X = aX
        /// </summary>
        /// <param name="a">The value by which to scale the source vector</param>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static void scale(double a, Vector<double> X)        
            => CBLAS.cblas_dscal(X.Length, a, ref head(X), 1);
    }

}