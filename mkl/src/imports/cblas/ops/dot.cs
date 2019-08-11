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
		/// Computes the canonical dot product of two vectors
		/// </summary>
		/// <param name="n">The common number of components in each vectorr</param>
		/// <param name="X">The first vector</param>
		/// <param name="incX"></param>
		/// <param name="Y">The second vector</param>
		/// <param name="incY"></param>
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_sdot(int n, ref float X, int incX, ref float Y, int incY);

		/// <summary>
		/// Computes the canonical dot product of two vectors
		/// </summary>
		/// <param name="n">The common number of components in each vectorr</param>
		/// <param name="X">The first vector</param>
		/// <param name="incX"></param>
		/// <param name="Y">The second vector</param>
		/// <param name="incY"></param>
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_ddot(int n, ref double X, int incX, ref double Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dsdot(int n, ref float X, int incX, ref float Y, int incY);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_sdsdot(int n, ref float sb, ref float X, int incX, ref float Y, int incY);

    }

}