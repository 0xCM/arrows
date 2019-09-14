//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
    using System.Security;

	using static zfunc;
    
    [SuppressUnmanagedCodeSecurity]
    static class LibMc
    {
        internal const CallingConvention Cdecl = CallingConvention.Cdecl;

        public static double id()
            => 1.0;

        const string LibMDll = "libopenlibm.dll";

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double cbrt(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double ceil(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double copysign(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double erfc(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double erf(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double exp2(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double exp(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double expm1(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fabs(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fdim(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double floor(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fma(double x, double y, double z);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fmax(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fmin(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double fmod(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double frexp(double x, ref int y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double hypot(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern int ilogb(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double ldexp(double x, int y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double lgamma(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern long llrint(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern long llround(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl, ExactSpelling = true, CharSet = CharSet.Ansi)]
        public static extern double log10(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double log1p(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double log2(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double log(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern long lrint(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern long lround(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double modf(double x, ref double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double nan(ref char x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double nearbyint(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double nextafter(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double pow(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double remainder(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double remquo(double x, double y, ref int z);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double rint(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double round(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double scalbln(double x, long y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double scalbn(double x, int y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double sqrt(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double tgamma(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double trunc(double x);

        #region Trig

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double cos(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double sin(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double tan(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double acos(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double asin(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double atan(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double atan2(double x, double y);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double cosh(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double sinh(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double tanh(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double acosh(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double asinh(double x);

        [DllImport(LibMDll, CallingConvention=Cdecl)]
        public static extern double atanh(double x);

        #endregion
    }
}
