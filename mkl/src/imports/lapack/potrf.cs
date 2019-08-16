//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static MklCommon;
	
    partial class LAPACK
    {        
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int LAPACKE_spotrf(BlasLayout layout, char uplo, int n, ref float a, int lda);

        /// <summary>
        /// Computes the Cholesky factorization of a symmetric, positive-definite matrix
        /// </summary>
        /// <param name="uplo">Either 'U' or 'L', respectively selecting the Transpose(U)*U or L*Transpose(L) factorizations </param>
        /// <param name="n">The order of the source matrix</param>
        /// <param name="a">The source matrix</param>
        /// <param name="lda">The leading dimension of the soruce matrix</param>
        /// <param name="exitcode">If successful, populated with 0; if -i, the i-th parameter had an illegal value; if info=i, general alorithm failure</param>
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int LAPACKE_dpotrf(BlasLayout layout, char uplo, int n, ref double a, int lda);

    }

}