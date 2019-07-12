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
        /// Finds the index of the vector component with minimal absoute value
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_isamin(int n, ref float X, int incX);

        /// <summary>
        /// Finds the index of the vector component with minimal absoute value
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_idamin(int n, ref double X, int incX);


        /// <summary>
        /// Finds the index of the complex vector component such that the sum of the
        /// absolute value of the real and imaginary parts is minimal
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
        /// <returns></returns>
		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_icamin(int n, ref ComplexF32 X, int incX);

        /// <summary>
        /// Finds the index of the complex vector component such that the sum of the
        /// absolute value of the real and imaginary parts is minimal
        /// </summary>
        /// <param name="n">The number of cmponents in the source vector</param>
        /// <param name="X">A reference the source vector head</param>
        /// <param name="incX"></param>
        /// <returns></returns>
		[DllImport(MklDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern ulong cblas_izamin(int n, ref ComplexF64 X, int incX);


    }

}