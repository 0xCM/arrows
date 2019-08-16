//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Diagnostics;    
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Runtime.InteropServices;
    using static zfunc;

    using static MklCommon;

	[SuppressUnmanagedCodeSecurity]
    public static partial class CBLAS
    {
        const string CBlasDll = "z0-cblas-clib.dll";

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dcabs1(ref ComplexF64 z);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_scabs1(ref ComplexF32 c);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_sdoti(int N, ref float X, ref int indx, ref float Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_ddoti(int N, ref double X, ref int indx, ref double Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotu_sub(int N, ref byte X, int incX, ref byte Y, int incY, ref byte dotu);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotui_sub(int N, ref byte X, ref int indx, ref byte Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotc_sub(int N, ref byte X, int incX, ref byte Y, int incY, ref byte dotc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cdotci_sub(int N, ref byte X, ref int indx, ref byte Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotu_sub(int N, ref ComplexF64 X, int incX, ref ComplexF64 Y, int incY, ref byte dotu);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotui_sub(int N, ref ComplexF64 X, ref int indx, ref ComplexF64 Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotc_sub(int N, ref ComplexF64 X, int incX, ref ComplexF64 Y, int incY, ref byte dotc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdotci_sub(int N, ref ComplexF64 X, ref int indx, ref ComplexF64 Y, ref byte dotui);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sswap(int N, ref float X, int incX, ref float Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_scopy(int N, ref float X, int incX, ref float Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_saxpby(int N, float alpha, ref float X,int incX, float beta, ref float Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_saxpyi(int N, float alpha, ref float X,ref int indx, ref float Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgthr(int N, ref float Y, ref float X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgthrz(int N, ref float Y, ref float X, ref int indx);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssctr(int N, ref float X, ref int indx, ref float Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotg(ref float a, ref float b, ref float c, ref float s);

		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dswap(int N, ref double X, int incX, ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dcopy(int N, ref double X, int incX, ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_daxpby(int N, double alpha, ref double X, int incX, double beta, ref double Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_daxpyi(int N, double alpha, ref double X, ref int indx, ref double Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgthr(int N, ref double Y, ref double X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgthrz(int N, ref double Y, ref double X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsctr(int N, ref double X, ref int indx, ref double Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotg(ref double a, ref double b, ref double c, ref double s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cswap(int N, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ccopy(int N, ref byte X, int incX, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_caxpy(int N, ref byte alpha, ref byte X, int incX, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]        
        public static extern void cblas_caxpby(int N, ref byte alpha, ref byte X, int incX, ref byte beta, ref byte Y, int incY);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_caxpyi(int N, ref byte alpha, ref byte X, ref int indx, ref byte Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgthr(int N, ref byte Y, ref byte X, ref int indx);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgthrz(int N, ref byte Y, ref byte X, ref int indx);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csctr(int N, ref byte X, ref int indx, ref byte Y);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_crotg(ref byte a, ref byte b, ref float c, ref byte s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zswap(int N, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zcopy(int N, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpy(int N, ref byte alpha, ref byte X, int incX, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpby(int N, ref byte alpha, ref byte X, int incX, ref byte beta, ref byte Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpyi(int N, ref byte alpha, ref byte X, ref int indx, ref byte Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgthr(int N, ref byte Y, ref byte X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgthrz(int N, ref byte Y, ref byte X, ref int indx);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsctr(int N, ref byte X, ref int indx, ref byte Y);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zrotg(ref byte a, ref byte b, ref double c, ref byte s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotmg(ref float d1, ref float d2, ref float b1, float b2, ref float P);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srot(int N, ref float X, int incX, ref float Y, int incY, float c, float s);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sroti(int N, ref float X, ref int indx, ref float Y, float c, float s);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_srotm(int N, ref float X, int incX,ref float Y, int incY, ref float P);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotmg(ref double d1, ref double d2, ref double b1, double b2, ref double P);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drot(int N, ref double X, int incX, ref double Y, int incY, double c, double  s);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_drotm(int N, ref double X, int incX, ref double Y, int incY, ref double P);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_droti(int N, ref double X, ref int indx, ref double Y, double c, double s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csrot(int N, ref byte X, int incX, ref byte Y, int incY, float c, float s);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdrot(int N, ref byte X, int incX, ref byte Y, int incY, double c, double  s);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sscal(int N, float alpha, ref float X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dscal(int N, double alpha, ref double X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cscal(int N, ref byte alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zscal(int N, ref byte alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csscal(int N, float alpha, ref byte X, int incX);
		
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zdscal(int N, double alpha, ref byte X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgbmv(BlasLayout Layout, BlasTrans TransA, int M, int N, int KL, int KU, 
            float alpha, ref float A, int lda, ref float X, int incX, float beta, ref float Y, int incY);
        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stbmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stpmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref float Ap, ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref float A, int lda, ref float X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stbsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref float A, int lda,
                        ref float X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_stpsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref float Ap, ref float X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgbmv(BlasLayout Layout,
                        BlasTrans TransA, int M, int N,
                        int KL, int KU, double alpha,
                        ref double A, int lda, ref double X,
                        int incX, double beta, ref double Y, int incY);
        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrmv(BlasLayout Layout, BlasUpLo Uplo, BlasTrans TransA, BlasDiagonal Diag, 
            int N, ref double A, int lda, ref double X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtbmv(BlasLayout Layout, BlasUpLo Uplo, BlasTrans TransA, BlasDiagonal Diag,
                int N, int K, ref double A, int lda, ref double X, int incX);
        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtpmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref double Ap, ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref double A, int lda, ref double X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtbsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref double A, int lda,
                        ref double X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtpsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref double Ap, ref double X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgbmv(BlasLayout Layout,
                        BlasTrans TransA, int M, int N,
                        int KL, int KU, ref byte alpha,
                        ref byte A, int lda, ref byte X,
                        int incX, ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctbmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctpmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte Ap, ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte A, int lda, ref byte X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctbsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref byte A, int lda,
                        ref byte X, int incX);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctpsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte Ap, ref byte X, int incX);


        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgbmv(BlasLayout Layout,
                        BlasTrans TransA, int M, int N,
                        int KL, int KU, ref byte alpha,
                        ref byte A, int lda, ref byte X,
                        int incX, ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztbmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztpmv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte Ap, ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte A, int lda, ref byte X,
                        int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztbsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, int K, ref byte A, int lda,
                        ref byte X, int incX);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztpsv(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasDiagonal Diag,
                        int N, ref byte Ap, ref byte X, int incX);


        /*
        * Routines with S and D prefixes only
        */
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssymv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float A,
                        int lda, ref float X, int incX,
                        float beta, ref float Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssbmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, int K, float alpha, ref float A,
                        int lda, ref float X, int incX,
                        float beta, ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float Ap,
                        ref float X, int incX,
                        float beta, ref float Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sger(BlasLayout Layout, int M, int N,
                        float alpha, ref float X, int incX,
                        ref float Y, int incY, ref float A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float X,
                        int incX, ref float A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float X,
                        int incX, ref float Ap);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr2(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float X,
                        int incX, ref float Y, int incY, ref float A,
                        int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sspr2(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref float X,
                        int incX, ref float Y, int incY, ref float A);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsymv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double A,
                        int lda, ref double X, int incX,
                        double beta, ref double Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsbmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, int K, double alpha, ref double A,
                        int lda, ref double X, int incX,
                        double beta, ref double Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double Ap,
                        ref double X, int incX,
                        double beta, ref double Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dger(BlasLayout Layout, int M, int N,
                        double alpha, ref double X, int incX,
                        ref double Y, int incY, ref double A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double X,
                        int incX, ref double A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double X,
                        int incX, ref double Ap);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr2(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double X,
                        int incX, ref double Y, int incY, ref double A,
                        int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dspr2(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref double X,
                        int incX, ref double Y, int incY, ref double A);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chemv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chbmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, int K, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, ref byte alpha, ref byte Ap,
                        ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgeru(BlasLayout Layout, int M, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgerc(BlasLayout Layout, int M, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref byte X, int incX,
                        ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, float alpha, ref byte X,
                        int incX, ref byte A);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher2(BlasLayout Layout, BlasUpLo Uplo, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chpr2(BlasLayout Layout, BlasUpLo Uplo, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte Ap);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhemv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhbmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, int K, ref byte alpha, ref byte A,
                        int lda, ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpmv(BlasLayout Layout, BlasUpLo Uplo,
                        int N, ref byte alpha, ref byte Ap,
                        ref byte X, int incX,
                        ref byte beta, ref byte Y, int incY);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgeru(BlasLayout Layout, int M, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgerc(BlasLayout Layout, int M, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref byte X, int incX,
                        ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpr(BlasLayout Layout, BlasUpLo Uplo,
                        int N, double alpha, ref byte X,
                        int incX, ref byte A);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher2(BlasLayout Layout, BlasUpLo Uplo, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte A, int lda);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhpr2(BlasLayout Layout, BlasUpLo Uplo, int N,
                        ref byte alpha, ref byte X, int incX,
                        ref byte Y, int incY, ref byte Ap);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                            ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref float alpha_Array, ref float A_Array,
                            ref int lda_Array, ref float B_Array, ref int ldb_Array,
                            ref float beta_Array, ref float C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                            ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref double alpha_Array, ref double A_Array,
                            ref int lda_Array, ref double B_Array, ref int ldb_Array,
                            ref double beta_Array, ref double C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemmt(BlasLayout Layout, BlasUpLo Uplo, BlasTrans TransA, BlasTrans TransB,
                int N, int K, float alpha, ref float A, int lda, ref float B, int ldb, float beta, ref float C, int ldc);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssymm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb, float beta,
                        ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyrk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        float alpha, ref float A, int lda,
                        float beta, ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ssyr2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        float alpha, ref float A, int lda,
                        ref float B, int ldb, float beta,
                        ref float C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strmm(BlasLayout Layout, BlasSide Side, BlasUpLo Uplo, BlasTrans TransA, BlasDiagonal Diag, 
            int M, int N, float alpha, ref float A, int lda, ref float B, int ldb);

        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsm(BlasLayout Layout, BlasSide Side, BlasUpLo Uplo, BlasTrans TransA, BlasDiagonal Diag, 
            int M, int N, float alpha, ref float A, int lda, ref float B, int ldb);
        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_strsm_batch(BlasLayout Layout, ref BlasSide Side_Array,
                            ref BlasUpLo Uplo_Array, ref BlasTrans TransA_Array,
                            ref BlasDiagonal Diag_Array, ref int M_Array,
                            ref int N_Array, ref float alpha_Array,
                            ref float A_Array, ref int lda_Array,
                            ref float B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemmt(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasTrans TransB,
                        int N, int K,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsymm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyrk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        double alpha, ref double A, int lda,
                        double beta, ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dsyr2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb, double beta,
                        ref double C, int ldc);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrmm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        double alpha, ref double A, int lda,
                        ref double B, int ldb);
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dtrsm_batch(BlasLayout Layout, ref BlasSide Side_Array,
                            ref BlasUpLo Uplo_Array, ref BlasTrans Transa_Array,
                            ref BlasDiagonal Diag_Array, ref int M_Array,
                            ref int N_Array, ref double alpha_Array,
                            ref double A_Array, ref int lda_Array,
                            ref double B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm3m(BlasLayout Layout, BlasTrans TransA,
                        BlasTrans TransB, int M, int N,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                            ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                            ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                            ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemm3m_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                                ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                                ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                                ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                                ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                                int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cgemmt(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasTrans TransB,
                        int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csymm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csyrk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_csyr2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrmm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ctrsm_batch(BlasLayout Layout, ref BlasSide Side_Array,
                            ref BlasUpLo Uplo_Array, ref BlasTrans Transa_Array,
                            ref BlasDiagonal Diag_Array, ref int M_Array,
                            ref int N_Array, ref byte alpha_Array,
                            ref byte A_Array, ref int lda_Array,
                            ref byte B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm(BlasLayout Layout, BlasTrans TransA,
                        BlasTrans TransB, int M, int N,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm3m(BlasLayout Layout, BlasTrans TransA,
                        BlasTrans TransB, int M, int N,
                        int K, ref byte alpha, ref byte A,
                        int lda, ref byte B, int ldb,
                        ref byte beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                            ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                            ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                            ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                            ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                            int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemm3m_batch(BlasLayout Layout, ref BlasTrans TransA_Array,
                                ref BlasTrans TransB_Array, ref int M_Array, ref int N_Array,
                                ref int K_Array, ref byte alpha_Array, ref byte A_Array,
                                ref int lda_Array, ref byte B_Array, ref int ldb_Array,
                                ref byte beta_Array, ref byte C_Array, ref int ldc_Array,
                                int group_count, ref int group_size);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zgemmt(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans TransA, BlasTrans TransB,
                        int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsymm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsyrk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zsyr2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrmm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, BlasTrans TransA,
                        BlasDiagonal Diag, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_ztrsm_batch(BlasLayout Layout, ref BlasSide Side_Array,
                            ref BlasUpLo Uplo_Array, ref BlasTrans Transa_Array,
                            ref BlasDiagonal Diag_Array, ref int M_Array,
                            ref int N_Array, ref byte alpha_Array,
                            ref byte A_Array, ref int lda_Array,
                            ref byte B_Array, ref int ldb_Array,
                            int group_count, ref int group_size);

        /*
        * Routines with prefixes C and Z only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_chemm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cherk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        float alpha, ref byte A, int lda,
                        float beta, ref byte C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_cher2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, float beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zhemm(BlasLayout Layout, BlasSide Side,
                        BlasUpLo Uplo, int M, int N,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, ref byte beta,
                        ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zherk(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        double alpha, ref byte A, int lda,
                        double beta, ref byte C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zher2k(BlasLayout Layout, BlasUpLo Uplo,
                        BlasTrans Trans, int N, int K,
                        ref byte alpha, ref byte A, int lda,
                        ref byte B, int ldb, double beta,
                        ref byte C, int ldc);

        /*
        * Routines with prefixes S and D only
        */
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ref float cblas_sgemm_alloc(BlasIdentifier identifier, int M, int N, int K);
        
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_pack(BlasLayout Layout, BlasIdentifier identifier,
                        BlasTrans Trans, int M, int N,
                        int K, float alpha, ref float src,
                        int ld, ref float dest);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_compute(BlasLayout Layout, int TransA,
                        int TransB, int M, int N,
                        int K, ref float A,
                        int lda, ref float B, int ldb,
                        float beta, ref float C, int ldc);
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_sgemm_free(ref float dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ref double cblas_dgemm_alloc(BlasIdentifier identifier, int M, int N, int K);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_pack(BlasLayout Layout, BlasIdentifier identifier,
                        BlasTrans Trans, int M, int N,
                        int K, double alpha, ref double src,
                        int ld, ref double dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_compute(BlasLayout Layout, int TransA, int TransB, int M, int N, int K, ref double A,
                        int lda, ref double B, int ldb, double beta, ref double C, int ldc);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_dgemm_free(ref double dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_gemm_s16s16s32(BlasLayout Layout, BlasTrans TransA, BlasTrans TransB, MatrixOffset OffsetC, 
            int M, int N, int K, float alpha, ref short A, int lda, short ao, ref short B, int ldb, short bo, float beta, ref int C, int ldc, ref int cb);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_gemm_s8u8s32(BlasLayout Layout, BlasTrans TransA, BlasTrans TransB, MatrixOffset OffsetC,
            int M, int N, int K, float alpha, ref sbyte A, int lda, sbyte ao, ref byte B, int ldb, sbyte bo, float beta, ref int C, int ldc, ref int cb);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int cblas_gemm_s8u8s32_pack_get_size(BlasIdentifier identifier, int M, int N, int K);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern int cblas_gemm_s16s16s32_pack_get_size(BlasIdentifier identifier, int M, int N, int K);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern void cblas_gemm_s8u8s32_pack(BlasLayout Layout,  BlasIdentifier identifier, BlasTrans Trans, 
            int M, int N, int K, void *src, int ld, void *dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_gemm_s16s16s32_pack(BlasLayout Layout,  BlasIdentifier identifier, BlasTrans Trans, 
            int M, int N, int K, ref short src, int ld, ref short dest);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static unsafe extern void cblas_gemm_s8u8s32_compute(BlasLayout Layout, int TransA, int TransB, MatrixOffset offsetc,
            int M, int N, int K, float alpha, ref sbyte A, int lda, sbyte ao, ref byte B, int ldb, sbyte bo, float beta, ref int C, int ldc, ref int co);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_gemm_s16s16s32_compute(BlasLayout Layout, int TransA, int TransB, MatrixOffset offsetc,
            int M, int N, int K, float alpha, ref short A, int lda, short ao, ref short B, int ldb, short bo, float beta, ref int C, int ldc, ref int co);
    }

}
