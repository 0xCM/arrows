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
    using System.Security;

	using static zfunc;
    using static MklImports;

    [SuppressUnmanagedCodeSecurity]
    public static class VML
    {
        const string VmlDll = "z0-vml-clib.dll";

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsAbs(int n, ref float src, ref float dst);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdAbs(int n, ref double src, ref double dst);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsAdd(int n, ref float lhs, ref float rhs, ref float dst);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdAdd(int n, ref double lhs, ref double rhs, ref double dst);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSub(int n, ref float lhs, ref float rhs, ref float dst);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSub(int n, ref double lhs, ref double rhs, ref double dst);		

        /* Error function: r[i] = erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErf(int n, ref float src, ref float dst);		

        /* Error function: r[i] = erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErf(int n, ref double src, ref double dst);		

        /* Inverse error function: r[i] = erfinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfInv(int n, ref float src, ref float dst);		

        /* Inverse error function: r[i] = erfinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfInv(int n, ref double src, ref double dst);		

        /* Complementary error function: r[i] = 1 - erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfc(int n, ref float src, ref float dst);		

        /* Complementary error function: r[i] = 1 - erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErfc(int n, ref double src, ref double dst);		

        /* Inverse complementary error function: r[i] = erfcinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfcInv(int n, ref float src, ref float dst);		

        /* Inverse complementary error function: r[i] = erfcinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfcInv(int n, ref double src, ref double dst);		

        /* Cumulative normal distribution function: r[i] = cdfnorm(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNorm(int n, ref float src, ref float dst);		

        /* Cumulative normal distribution function: r[i] = cdfnorm(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNorm(int n, ref double src, ref double dst);		

        /* Inverse cumulative normal distribution function: r[i] = cdfnorminv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNormInv(int n, ref float src, ref float dst);		

        /* Inverse cumulative normal distribution function: r[i] = cdfnorminv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNormInv(int n, ref double src, ref double dst);		

    }
}
