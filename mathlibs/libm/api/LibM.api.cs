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
    
    public static class libm
    {
        [MethodImpl(Inline)]
        public static double cbrt(double x)
            => LibMc.cbrt(x);

        [MethodImpl(Inline)]
        public static double ceil(double x)
            => LibMc.ceil(x);

        [MethodImpl(Inline)]
        public static double copysign(double x, double y)
            => LibMc.copysign(x,y);

        [MethodImpl(Inline)]
        public static double erfc(double x)
            => LibMc.erfc(x);

        [MethodImpl(Inline)]
        public static double erf(double x)
            => LibMc.erf(x);

        [MethodImpl(Inline)]
        public static double exp2(double x)
            => LibMc.exp2(x);

        [MethodImpl(Inline)]
        public static double exp(double x)
            => LibMc.exp(x);

        [MethodImpl(Inline)]
        public static double expm1(double x)
            => LibMc.expm1(x);

        [MethodImpl(Inline)]
        public static double fabs(double x)
            => LibMc.fabs(x);

        [MethodImpl(Inline)]
        public static double fdim(double x, double y)
            => LibMc.fdim(x,y);

        [MethodImpl(Inline)]
        public static double floor(double x)
            => LibMc.floor(x);

        [MethodImpl(Inline)]
        public static double fma(double x, double y, double z)
            => LibMc.fma(x,y,z);
            
        [MethodImpl(Inline)]
        public static double fmax(double x, double y)
            => LibMc.fmax(x,y);

        [MethodImpl(Inline)]
        public static double fmin(double x, double y)
            => LibMc.fmin(x,y);

        [MethodImpl(Inline)]
        public static double fmod(double x, double y)
            => LibMc.fmod(x,y);

        [MethodImpl(Inline)]
        public static double frexp(double x, ref int y)
            => LibMc.frexp(x,ref y);

        [MethodImpl(Inline)]
        public static double hypot(double x, double y)
            => LibMc.hypot(x,y);

        [MethodImpl(Inline)]
        public static int ilogb(double x)
            => LibMc.ilogb(x);

        [MethodImpl(Inline)]
        public static double ldexp(double x, int y)
            => LibMc.ldexp(x,y);

        [MethodImpl(Inline)]
        public static double lgamma(double x)
            => LibMc.lgamma(x);

        [MethodImpl(Inline)]
        public static long llrint(double x)
            => LibMc.llrint(x);

        [MethodImpl(Inline)]
        public static long llround(double x)
            => LibMc.llround(x);

        [MethodImpl(Inline)]
        public static double log10(double x)
            => LibMc.log10(x);

        [MethodImpl(Inline)]
        public static double log1p(double x)
            => LibMc.log1p(x);

        [MethodImpl(Inline)]
        public static double log2(double x)
            => LibMc.log2(x);

        [MethodImpl(Inline)]
        public static double log(double x)
            => LibMc.log(x);

        [MethodImpl(Inline)]
        public static long lrint(double x)
            => LibMc.lrint(x);

        [MethodImpl(Inline)]
        public static long lround(double x)
            => LibMc.lround(x);

        [MethodImpl(Inline)]
        public static double modf(double x, ref double y)
            => LibMc.modf(x, ref y);

        [MethodImpl(Inline)]
        public static double nan(ref char x)
            => LibMc.nan(ref x);

        [MethodImpl(Inline)]
        public static double nearbyint(double x)
            => LibMc.nearbyint(x);

        [MethodImpl(Inline)]
        public static double nextafter(double x, double y)
            => LibMc.nextafter(x,y);

        [MethodImpl(Inline)]
        public static double pow(double x, double y)
            => LibMc.pow(x,y);

        [MethodImpl(Inline)]
        public static double remainder(double x, double y)
            => LibMc.remainder(x,y);

        [MethodImpl(Inline)]
        public static double remquo(double x, double y, ref int z)
            => LibMc.remquo(x,y, ref z);

        [MethodImpl(Inline)]
        public static double rint(double x)
            => LibMc.rint(x);

        [MethodImpl(Inline)]
        public static double round(double x)
            => LibMc.round(x);

        [MethodImpl(Inline)]
        public static double scalbln(double x, long y)
            => LibMc.scalbln(x,y);

        [MethodImpl(Inline)]
        public static double scalbn(double x, int y)
            => LibMc.scalbn(x,y);

        [MethodImpl(Inline)]
        public static double sqrt(double x)
            => LibMc.sqrt(x);

        [MethodImpl(Inline)]
        public static double tgamma(double x)
            => LibMc.tgamma(x);

        [MethodImpl(Inline)]
        public static double trunc(double x)
            => LibMc.trunc(x);

        #region Trig

        [MethodImpl(Inline)]
        public static double acosh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double acos(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double asinh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double asin(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double atan2(double x, double y)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double atanh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double atan(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double cosh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double cos(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double sinh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double sin(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double tanh(double x)
            => LibMc.id();

        [MethodImpl(Inline)]
        public static double tan(double x)
            => LibMc.id();
        #endregion
    }
}