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
        public static extern int LAPACKE_sgeev(MatrixLayout layout, char jobvl, char jobvr,
                                int n, ref float a, int lda, ref float wr,
                                ref float wi, ref float vl, int ldvl, ref float vr,
                                int ldvr);

        /// <summary>
        /// For an n-square real nonsymmetric matrix A, computes the eigenvalues and, optionally, 
        /// the left and/or right eigenvectors. The right eigenvector v of A satisfies A*v = λ*v
        /// where λ is its eigenvalue. The left eigenvector u of A satisfies u^H *A = λ*u H
        /// where where u^H denotes the conjugate transpose of u. The computed eigenvectors are 
        /// normalized to have Euclidean norm equal to 1 and largest component real
        /// </summary>
        /// <param name="jobvl">A reference a 'N' or 'V' character where 'V' indicates that the left eigenvectors should be computed and 'N' specifies that they shouldn't</param>
        /// <param name="jobvr">A reference a 'N' or 'V' character where 'V' indicates that the right eigenvectors should be computed and 'N' specifies that they shouldn't</param>
        /// <param name="n">The dimension of the source matrix</param>
        /// <param name="a">The source matrix</param>
		/// <param name="lda">The leading dimension of a</param>
        /// <param name="wr">The real parts of the computed eigenvalues</param>
        /// <param name="wi">The imaginary parts of the computed eigenvalues</param>
        /// <param name="vl">Applicable when eigenvectors are computed; if the j-th eigenvalue is real,the i-th component of the j-th eigenvector u j is stored in vl[(i - 1)*ldvl + (j - 1)] for row major layout</param>
        /// <param name="ldvl">The leading dimension of vl</param>
        /// <param name="vr">Applicable when eigenvectors are computed; if the j-th eigenvalue is real, then the i-th component of j-th eigenvector v j is stored in vr[(i - 1)*ldvr + (j - 1)] for row major layout</param>
        /// <param name="ldvr">Th leading dimenion of vr</param>
        /// <param name="ws">A reference to the workspace allocation, which for maximum performance should be of length n*n</param>
        /// <param name="wslen">The  size of the workspace allolcation</param>
        /// <param name="exitcode">If successful, populated with 0; if -i, the i-th parameter had an illegal value; if info=i, general alorithm failure</param>
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int LAPACKE_dgeev(MatrixLayout layout, char jobvl, char jobvr,
                                int n, ref double a, int lda, ref double wr,
                                ref double wi, ref double vl, int ldvl, ref double vr,
                                int ldvr);

    }

}