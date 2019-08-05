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
        public static extern double cblas_dcabs1(ref ComplexF64 z);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_scabs1(ref ComplexF32 c);

		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_sdoti(int n, ref float X, ref int indx, ref float Y);


		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_ddoti(int n, ref double X, ref int indx, ref double Y);


        /*
        * Functions having prefixes Z and C only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotu_sub(int n, ref byte X, int incX, ref byte Y, int incY, ref byte dotu);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotui_sub(int n, ref byte X, ref int indx, ref byte Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotc_sub(int n, ref byte X, int incX, ref byte Y, int incY, ref byte dotc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotci_sub(int n, ref byte X, ref int indx, ref byte Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotu_sub(int n, ref ComplexF64 X, int incX, ref ComplexF64 Y, int incY, ref byte dotu);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotui_sub(int n, ref ComplexF64 X, ref int indx, ref ComplexF64 Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotc_sub(int n, ref ComplexF64 X, int incX, ref ComplexF64 Y, int incY, ref byte dotc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotci_sub(int n, ref ComplexF64 X, ref int indx, ref ComplexF64 Y, ref byte dotui);



        /*
        * Routines with standard 4 prefixes (s, d, c, z)
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sswap(int n, ref float X, int incX,
                        ref float Y, int incY);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_scopy(int n, ref float X, int incX,
                        ref float Y, int incY);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_saxpby(int n, float alpha, ref float X,
                        int incX, float beta, ref float Y, int incY);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_saxpyi(int n, float alpha, ref float X,
                        ref int indx, ref float Y);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgthr(int n, ref float Y, ref float X,
                                        ref int indx);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgthrz(int n, ref float Y, ref float X, ref int indx);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssctr(int n, ref float X, ref int indx,
                                        ref float Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotg(ref float a, ref float b, ref float c, ref float s);

		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dswap(int n, ref double X, int incX,
                        ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dcopy(int n, ref double X, int incX, ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_daxpby(int n, double alpha, ref double X, int incX, double beta, ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_daxpyi(int n, double alpha, ref double X, ref int indx, ref double Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgthr(int n, ref double Y, ref double X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgthrz(int n, ref double Y, ref double X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsctr(int n, ref double X, ref int indx, ref double Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotg(ref double a, ref double b, ref double c, ref double s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cswap(int n, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ccopy(int n, ref byte X, int incX, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_caxpy(int n, ref byte alpha, ref byte X, int incX, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_caxpby(int n, ref byte alpha, ref byte X, int incX, ref byte beta, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_caxpyi(int n, ref byte alpha, ref byte X, ref int indx, ref byte Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgthr(int n, ref byte Y, ref byte X, ref int indx);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgthrz(int n, ref byte Y, ref byte X, ref int indx);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csctr(int n, ref byte X, ref int indx, ref byte Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_crotg(ref byte a, ref byte b, ref float c, ref byte s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zswap(int n, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zcopy(int n, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpy(int n, ref byte alpha, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpby(int n, ref byte alpha, ref byte X, int incX, ref byte beta, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpyi(int n, ref byte alpha, ref byte X, ref int indx, ref byte Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgthr(int n, ref byte Y, ref byte X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgthrz(int n, ref byte Y, ref byte X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsctr(int n, ref byte X, ref int indx, ref byte Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zrotg(ref byte a, ref byte b, ref double c, ref byte s);

        /*
        * Routines with S and D prefix only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotmg(ref float d1, ref float d2, ref float b1, float b2, ref float P);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srot(int n, ref float X, int incX,
                        ref float Y, int incY, float c, float s);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sroti(int n, ref float X, ref int indx,
                        ref float Y, float c, float s);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotm(int n, ref float X, int incX,
                        ref float Y, int incY, ref float P);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotmg(ref double d1, ref double d2, ref double b1, double b2, ref double P);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drot(int n, ref double X, int incX,
                        ref double Y, int incY, double c, double  s);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotm(int n, ref double X, int incX,
                        ref double Y, int incY, ref double P);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_droti(int n, ref double X, ref int indx, ref double Y, double c, double s);

        /*
        * Routines with CS and ZD prefix only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csrot(int n, ref byte X, int incX, ref byte Y, int incY, float c, float s);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdrot(int n, ref byte X, int incX, ref byte Y, int incY, double c, double  s);

        /*
        * Routines with S D C Z CS and ZD prefixes
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sscal(int n, float alpha, ref float X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dscal(int n, double alpha, ref double X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cscal(int n, ref byte alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zscal(int n, ref byte alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csscal(int n, float alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdscal(int n, double alpha, ref byte X, int incX);

        /*
        * ===========================================================================
        * Prototypes for level 2 BLAS
        * ===========================================================================
        */

        /*
        * Routines with standard 4 prefixes (S, D, C, Z)
        */
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        float alpha, ref float A, int lda,
                        ref float X, int incX, float beta,
                        ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgbmv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        int KL, int KU, float alpha,
                        ref float A, int lda, ref float X,
                        int incX, float beta, ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref float Ap, ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref float A, int lda, ref float X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stbsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stpsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref float Ap, ref float X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        double alpha, ref double A, int lda,
                        ref double X, int incX, double beta,
                        ref double Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgbmv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        int KL, int KU, double alpha,
                        ref double A, int lda, ref double X,
                        int incX, double beta, ref double Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref double A, int lda,
                        ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref double A, int lda,
                        ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref double Ap, ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref double A, int lda, ref double X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtbsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref double A, int lda,
                        ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtpsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref double Ap, ref double X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte X, int incX, ref byte beta,
                        ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgbmv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        int KL, int KU, ref byte alpha,
                        ref byte A, int lda, ref byte X,
                        int incX, ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte Ap, ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte A, int lda, ref byte X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctbsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref byte A, int lda,
                        ref byte X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctpsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte Ap, ref byte X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte X, int incX, ref byte beta,
                        ref byte Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgbmv(CBLAS_LAYOUT Layout,
                        CBLAS_TRANSPOSE TransA, int M, int n,
                        int KL, int KU, ref byte alpha,
                        ref byte A, int lda, ref byte X,
                        int incX, ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte Ap, ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte A, int lda, ref byte X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztbsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztpsv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_DIAG Diag,
                        int n, ref byte Ap, ref byte X, int incX);


        /*
        * Routines with S and D prefixes only
        */
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssymv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float A,
                        int lda, ref float X, int incX,
                        float beta, ref float Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, int K, float alpha, ref float A,
                        int lda, ref float X, int incX,
                        float beta, ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float Ap,
                        ref float X, int incX,
                        float beta, ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sger(CBLAS_LAYOUT Layout, int M, int n,
                        float alpha, ref float X, int incX,
                        ref float Y, int incY, ref float A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float X,
                        int incX, ref float A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float X,
                        int incX, ref float Ap);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float X,
                        int incX, ref float Y, int incY, ref float A,
                        int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref float X,
                        int incX, ref float Y, int incY, ref float A);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsymv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double A,
                        int lda, ref double X, int incX,
                        double beta, ref double Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, int K, double alpha, ref double A,
                        int lda, ref double X, int incX,
                        double beta, ref double Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double Ap,
                        ref double X, int incX,
                        double beta, ref double Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dger(CBLAS_LAYOUT Layout, int M, int n,
                        double alpha, ref double X, int incX,
                        ref double Y, int incY, ref double A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double X,
                        int incX, ref double A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double X,
                        int incX, ref double Ap);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double X,
                        int incX, ref double Y, int incY, ref double A,
                        int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref double X,
                        int incX, ref double Y, int incY, ref double A);

        /*
        * Routines with C and Z prefixes only
        */
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chemv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, int K, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, ref byte alpha, ref byte Ap,
                        ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgeru(CBLAS_LAYOUT Layout, int M, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgerc(CBLAS_LAYOUT Layout, int M, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref byte X, int incX,
                        ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, float alpha, ref byte X,
                        int incX, ref byte A);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte Ap);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhemv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhbmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, int K, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpmv(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, ref byte alpha, ref byte Ap,
                        ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgeru(CBLAS_LAYOUT Layout, int M, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgerc(CBLAS_LAYOUT Layout, int M, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref byte X, int incX,
                        ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpr(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        int n, double alpha, ref byte X,
                        int incX, ref byte A);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpr2(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo, int n,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte Ap);

        /*
        * ===========================================================================
        * Prototypes for level 3 BLAS
        * ===========================================================================
        */

        /*
        * Routines with standard 4 prefixes (S, D, C, Z)
        */
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                            ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref float alpha_Array, ref float A_Array,
                            ref int lda_Array, ref float B_Array, ref int ldb_Array,
                            ref float beta_Array, ref float C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                            ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref double alpha_Array, ref double A_Array,
                            ref int lda_Array, ref double B_Array, ref int ldb_Array,
                            ref double beta_Array, ref double C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemmt(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA, CBLAS_TRANSPOSE TransB,
                        int n, int K,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb, float beta,
                        ref float C, int ldc);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssymm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb, float beta,
                        ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyrk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        float alpha, ref float A, int lda,
                        float beta, ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb, float beta,
                        ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strmm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsm_batch(CBLAS_LAYOUT Layout, ref CBLAS_SIDE Side_Array,
                            ref CBLAS_UPLO Uplo_Array, ref CBLAS_TRANSPOSE TransA_Array,
                            ref CBLAS_DIAG Diag_Array, ref int M_Array,
                            ref int N_Array, ref float alpha_Array,
                            ref float A_Array, ref int lda_Array,
                            ref float B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemmt(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_TRANSPOSE TransB,
                        int n, int K,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsymm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyrk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        double alpha, ref double A, int lda,
                        double beta, ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrmm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsm_batch(CBLAS_LAYOUT Layout, ref CBLAS_SIDE Side_Array,
                            ref CBLAS_UPLO Uplo_Array, ref CBLAS_TRANSPOSE Transa_Array,
                            ref CBLAS_DIAG Diag_Array, ref int M_Array,
                            ref int N_Array, ref double alpha_Array,
                            ref double A_Array, ref int lda_Array,
                            ref double B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm3m(CBLAS_LAYOUT Layout, CBLAS_TRANSPOSE TransA,
                        CBLAS_TRANSPOSE TransB, int M, int n,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                            ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                            ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                            ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm3m_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                                ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                                ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                                ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                                ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                                int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemmt(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_TRANSPOSE TransB,
                        int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csymm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csyrk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csyr2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrmm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsm_batch(CBLAS_LAYOUT Layout, ref CBLAS_SIDE Side_Array,
                            ref CBLAS_UPLO Uplo_Array, ref CBLAS_TRANSPOSE Transa_Array,
                            ref CBLAS_DIAG Diag_Array, ref int M_Array,
                            ref int N_Array, ref byte alpha_Array,
                            ref byte A_Array, ref int lda_Array,
                            ref byte B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm(CBLAS_LAYOUT Layout, CBLAS_TRANSPOSE TransA,
                        CBLAS_TRANSPOSE TransB, int M, int n,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm3m(CBLAS_LAYOUT Layout, CBLAS_TRANSPOSE TransA,
                        CBLAS_TRANSPOSE TransB, int M, int n,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                            ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                            ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                            ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm3m_batch(CBLAS_LAYOUT Layout, ref CBLAS_TRANSPOSE TransA_Array,
                                ref CBLAS_TRANSPOSE TransB_Array, ref int M_Array, ref int N_Array,
                                ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                                ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                                ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                                int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemmt(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE TransA, CBLAS_TRANSPOSE TransB,
                        int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsymm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsyrk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsyr2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrmm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, CBLAS_TRANSPOSE TransA,
                        CBLAS_DIAG Diag, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsm_batch(CBLAS_LAYOUT Layout, ref CBLAS_SIDE Side_Array,
                            ref CBLAS_UPLO Uplo_Array, ref CBLAS_TRANSPOSE Transa_Array,
                            ref CBLAS_DIAG Diag_Array, ref int M_Array,
                            ref int N_Array, ref byte alpha_Array,
                            ref byte A_Array, ref int lda_Array,
                            ref byte B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        /*
        * Routines with prefixes C and Z only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chemm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cherk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        float alpha, ref byte A, int lda,
                        float beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, float beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhemm(CBLAS_LAYOUT Layout, CBLAS_SIDE Side,
                        CBLAS_UPLO Uplo, int M, int n,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zherk(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        double alpha, ref byte A, int lda,
                        double beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher2k(CBLAS_LAYOUT Layout, CBLAS_UPLO Uplo,
                        CBLAS_TRANSPOSE Trans, int n, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, double beta,
                        ref byte C, int ldc);

        /*
        * Routines with prefixes S and D only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ref float cblas_sgemm_alloc(CBLAS_IDENTIFIER identifier, int M, int n, int K);
        
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_pack(CBLAS_LAYOUT Layout, CBLAS_IDENTIFIER identifier,
                        CBLAS_TRANSPOSE Trans, int M, int n,
                        int K, float alpha, ref float src,
                        int ld, ref float dest);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_compute(CBLAS_LAYOUT Layout, int TransA,
                        int TransB, int M, int n,
                        int K, ref float A,
                        int lda, ref float B, int ldb,
                        float beta, ref float C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_free(ref float dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ref double cblas_dgemm_alloc(CBLAS_IDENTIFIER identifier, int M, int n, int K);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_pack(CBLAS_LAYOUT Layout, CBLAS_IDENTIFIER identifier,
                        CBLAS_TRANSPOSE Trans, int M, int n,
                        int K, double alpha, ref double src,
                        int ld, ref double dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_compute(CBLAS_LAYOUT Layout, int TransA,
                        int TransB, int M, int n,
                        int K, ref double A,
                        int lda, ref double B, int ldb,
                        double beta, ref double C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_free(ref double dest);

    }

}

