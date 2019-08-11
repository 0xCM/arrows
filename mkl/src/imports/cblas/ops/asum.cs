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
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
        [DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_sasum(int n, ref float X, int incX);

        /// <summary>
        /// Computes the sum of the absolute value of each component
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dasum(int n, ref double X, int incX);

        /// <summary>
        /// Computes the sum of the absolute value of each real and imaginary part of each component
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern float cblas_scasum(int n, ref ComplexF32 X, int incX);

        /// <summary>
        /// Computes the sum of the absolute value of each real and imaginary part of each component
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="X">A reference to the vector head</param>
        /// <param name="incX">?</param>
		[DllImport(CBlasDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern double cblas_dzasum(int n, ref ComplexF64 X, int incX);
    }

}