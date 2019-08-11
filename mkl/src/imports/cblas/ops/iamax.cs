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
        /// Finds the index of the vector component with maximum absoute value
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_isamax(int n, ref float X, int incX);

        /// <summary>
        /// Finds the index of the vector component with maximum absoute value
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
        /// <returns></returns>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_idamax(int n, ref double X, int incX);

        /// <summary>
        /// Finds the index of the complex vector component such that the sum of the
        /// absolute value of the real and imaginary parts are maximial
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
        /// <returns></returns>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_icamax(int n, ref ComplexF32 X, int incX);

        /// <summary>
        /// Finds the index of the complex vector component such that the sum of the
        /// absolute value of the real and imaginary parts is maximial
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_izamax(int n, ref ComplexF64 X, int incX);

    }

}