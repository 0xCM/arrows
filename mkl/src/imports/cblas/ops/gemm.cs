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
    using static MklCommon;

	partial class CBLAS
	{
		/// <summary>
		/// Computes C = alpha*A*B + beta*C where alhpa and beta are scalars and A,B and C are matrices of compatible dimensions 
		/// </summary>
		/// <param name="Layout">Indicates whether matrix is in row-major or column-major form</param>
		/// <param name="TransA">Specfies the transpose operation, if any, to be applied to A</param>
		/// <param name="TransB">Specfies the transpose operation, if any, to be applied to B</param>
		/// <param name="M">The number of rows in A and C</param>
		/// <param name="N">The number of columns in B and C</param>
		/// <param name="K">The number of columns in A and rows in B</param>
		/// <param name="alpha">Scales the product of the matrices A and B</param>
		/// <param name="A">An mxk matrix</param>
		/// <param name="lda">The leading dimension of A</param>
		/// <param name="B">A kxn matrix</param>
		/// <param name="ldb">The leading dimension of B</param>
		/// <param name="beta">Scales the matrix C</param>
		/// <param name="C">An mxn matrix</param>
		/// <param name="ldc">The leading dimension of C</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
		public static extern void cblas_dgemm(BlasLayout Layout, BlasTrans TransA, BlasTrans TransB, 
			int M, int N, int K, double alpha, ref double A, int lda, ref double B, int ldb, double beta, ref double C, int ldc);


		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
		public static extern void cblas_cgemm(BlasLayout Layout, BlasTrans TransA, BlasTrans TransB, int M, int N, int K,
			ref ComplexF32 alpha, ref ComplexF32 A, int lda, ref ComplexF32 B, int ldb,ref ComplexF32 beta, ref ComplexF32 C, int ldc);

	
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
		public static extern void cblas_sgemm(BlasLayout Layout, BlasTrans TransA, BlasTrans TransB, int M, int n,
			int K, float alpha, ref float A, int lda, ref float B, int ldb, float beta, ref float C, int ldc);

	}

}