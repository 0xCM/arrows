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
    using static MklImports;

    partial class CBLAS
    {

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int m, int n,
                        float alpha, ref float A, int lda,
                        ref float X, int incX, float beta,
                        ref float Y, int incY);

        
        /// <summary>
        /// Computes  y = alpha*A*x + beta*y ;
        /// </summary>
        /// <param name="Layout"></param>
        /// <param name="TransA"></param>
        /// <param name="m">The number of rows in the matrix A</param>
        /// <param name="n">The number of columns in the matrix A</param>
        /// <param name="alpha">A scalar value</param>
        /// <param name="A">An m x n matrix</param>
        /// <param name="lda">For Layout = CblasRowMajor , the value of lda must be at least max(1,n)</param>
        /// <param name="x">A vector of dimension n</param>
        /// <param name="incX"></param>
        /// <param name="beta">A scalar value</param>
        /// <param name="y">A vector of dimension m</param>
        /// <param name="incY"></param>
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemv(CBLAS_LAYOUT Layout, CBLAS_TRANSPOSE TransA, int m, int n,
                double alpha, ref double A, int lda, ref double x, int incX, double beta, ref double y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int m, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte X, int incX, ref byte beta,
                        ref byte Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int m, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte X, int incX, ref byte beta,
                        ref byte Y, int incY);

    }

}