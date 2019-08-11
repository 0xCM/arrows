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
        /// <summary>
        /// Computes Y = aX + Y for a scalar a and vectors X, Y
        /// </summary>
        /// <param name="n">The common number of components in x and y</param>
        /// <param name="a">The scalar that will be applied to X</param>
        /// <param name="x">The vector to be scaled</param>
        /// <param name="incx"></param>
        /// <param name="y">The second vector to be used as both input and output</param>
        /// <param name="incy"></param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_saxpy (int n, float a, ref float x, int incx, ref float y, int incy);

        /// <summary>
        /// Computes Y = aX + Y for a scalar a and vectors X, Y
        /// </summary>
        /// <param name="n">The common number of components in x and y</param>
        /// <param name="a">The scalar that will be applied to X</param>
        /// <param name="x">The vector to be scaled</param>
        /// <param name="incx"></param>
        /// <param name="y">The second vector to be used as both input and output</param>
        /// <param name="incy"></param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_daxpy (int n, double a, ref double x, int incx, ref double y, int incy);

        /// <summary>
        /// Computes Y = aX + Y for a scalar a and vectors X, Y
        /// </summary>
        /// <param name="n">The common number of components in x and y</param>
        /// <param name="a">The scalar that will be applied to X</param>
        /// <param name="x">The vector to be scaled</param>
        /// <param name="incx"></param>
        /// <param name="y">The second vector to be used as both input and output</param>
        /// <param name="incy"></param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_caxpy (int n, ref ComplexF32 a, ref ComplexF32 x, int incx, ref ComplexF32 y, int incy);

        /// <summary>
        /// Computes Y = aX + Y for a scalar a and vectors X, Y
        /// </summary>
        /// <param name="n">The common number of components in x and y</param>
        /// <param name="a">The scalar that will be applied to X</param>
        /// <param name="x">The vector to be scaled</param>
        /// <param name="incx"></param>
        /// <param name="y">The second vector to be used as both input and output</param>
        /// <param name="incy"></param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void cblas_zaxpy (int n, ref ComplexF64 a, ref ComplexF64 x, int incx, ref ComplexF64 y, int incy);        


    }

}