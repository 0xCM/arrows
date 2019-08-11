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
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static float norm(Vector<float> X)        
            => CBLAS.cblas_snrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        public static double norm(Vector<double> X)        
            => CBLAS.cblas_dnrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        static float norm(Span<ComplexF32> X)        
            => CBLAS.cblas_scnrm2(X.Length, ref head(X), 1);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="X">The source vector</param>
        [MethodImpl(Inline)]
        static double norm(Span<ComplexF64> X)        
            => CBLAS.cblas_dznrm2(X.Length, ref head(X), 1);


    }

}