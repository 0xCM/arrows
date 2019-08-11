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

        /// <summary>
        /// Computes an LU factorization of a general M-by-N matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="layout">The array layout, either row-major or column-major</param>
        /// <param name="m">The number of rows in the matrix</param>
        /// <param name="n">The number of columns in the matrix</param>
        /// <param name="a">The source matrix</param>
        /// <param name="lda">The leading dimension of the array representation</param>
        /// <param name="ipiv">An integer array of dimension MxN that records the pivot indices that were used</param>
        /// <param name="info">The algorithm exit code</param>
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int LAPACKE_sgetrf(MatrixLayout layout, int m, int n, ref float a, int lda, ref int ipiv);

        /// <summary>
        /// Computes an LU factorization of a general M-by-N matrix A using partial pivoting with row interchanges.
        /// </summary>
        /// <param name="layout">The array layout, either row-major or column-major</param>
        /// <param name="m">The number of rows in the matrix</param>
        /// <param name="n">The number of columns in the matrix</param>
        /// <param name="a">The source matrix</param>
        /// <param name="lda">The leading dimension of the array representation</param>
        /// <param name="ipiv">An integer array of dimension MxN that records the pivot indices that were used</param>
        /// <param name="info">The algorithm exit code</param>
        [DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int LAPACKE_dgetrf(MatrixLayout layout, int m, int n, ref double a, int lda, ref int ipiv);



    }

}