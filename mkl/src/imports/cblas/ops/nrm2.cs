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
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="n">The length of the vector</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_snrm2(int n, ref float X, int incX);

        /// <summary>
        /// Computes the Euclidean norm of the source vector
        /// </summary>
        /// <param name="n">The length of the vector</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dnrm2(int n, ref double X, int incX);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float  cblas_scnrm2(int n, ref ComplexF32 X, int incX);

		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dznrm2(int n, ref ComplexF64 X, int incX);

    }

}