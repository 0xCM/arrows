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
    public static class VmlImport
    {
        const string VmlDll = "z0-vml-clib.dll";

		// Addition: r[i] = a[i] + b[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsAdd(int n, ref float a, ref float b, ref float r);		

        // Addition: r[i] = a[i] + b[i] */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdAdd(int n, ref double a, ref double b, ref double r);		

		//Subtraction:  r[i] = a[i] - b[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSub(int n, ref float a, ref float b, ref float r);		

		//Subtraction: r[i] = a[i] - b[i] */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSub(int n, ref double a, ref double b, ref double r);		

		// Multiplicaton: r[i] = a[i] * b[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsMul(int n, ref float a, ref float b, ref float r);		

        // Multiplicaton: r[i] = a[i] * b[i] */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdMul(int n, ref double a, ref double b, ref double r);		

		// Division: r[i] = a[i] / b[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsDiv(int n, ref float a, ref float b, ref float r);		

        // Division: r[i] = a[i] / b[i] */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdDiv(int n, ref double a, ref double b, ref double r);		

		// Modulus function: r[i] = fmod(a[i], b[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFmod(int n, ref float a, ref float b, ref float r);		

        // Modulus function: r[i] = fmod(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFmod(int n, ref double a, ref double b, ref double r);		

		// Remainder function: r[i] = remainder(a[i], b[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsRemainder(int n, ref float a, ref float b, ref float r);		

        // Remainder function: r[i] = remainder(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdRemainder(int n, ref double a, ref double b, ref double r);		

        // Reciprocal: r[i] = 1.0 / a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsInv(int n, ref float a, ref float r);		

        // Reciprocal: r[i] = 1.0 / a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdInv(int n, ref double a, ref double r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsAbs(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdAbs(int n, ref double a, ref double r);		

        // Copy sign function: r[i] = copysign(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCopySign(int n, ref float a, ref float b, ref float r);		

        // Copy sign function: r[i] = copysign(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCopySign(int n, ref double a, ref double b, ref double r);		

        /// <summary>
        /// Computes the square of each component: r[i] = a[i]^2
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The input vector</param>
        /// <param name="r">The output vector</param>
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSqr(int n, ref float a, ref float r);		

        /// <summary>
        /// Computes the square of each component: r[i] = a[i]^2
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The input vector</param>
        /// <param name="r">The output vector</param>
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSqr(int n, ref double a, ref double r);		

        /// <summary>
        /// Computes the square root of each component: r[i] = a[i]^0.5
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The input vector</param>
        /// <param name="r">The output vector</param>
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSqrt(int n, ref float a, ref float r);		

        /// <summary>
        /// Computes the square root of each component: r[i] = a[i]^0.5
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The input vector</param>
        /// <param name="r">The output vector</param>
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSqrt(int n, ref double a, ref double r);		

        /// <summary>
        /// Raises each component of the first vector to the corresponcing component in the 
        /// second vector: r[i] = a[i]^b[i] 
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="r">The output vector</param>
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPow(int n, ref float a, ref float b, ref float r);		

        /// <summary>
        /// Raises each component of the first vector to the corresponcing component in the 
        /// second vector: r[i] = a[i]^b[i] 
        /// </summary>
        /// <param name="n">The number of vector components</param>
        /// <param name="a">The first input vector</param>
        /// <param name="b">The second input vector</param>
        /// <param name="r">The output vector</param>
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPow(int n, ref double a, ref double b, ref double r);		

        // Power function: r[i] = a[i]^(3/2) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPow3o2(int n, ref float a, ref float r);		

        // Power function: r[i] = a[i]^(3/2) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPow3o2(int n, ref double a, ref double r);		

        // Power function: r[i] = a[i]^(2/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPow2o3(int n, ref float a, ref float r);		

        // Power function: r[i] = a[i]^(2/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPow2o3(int n, ref double a, ref double r);		

        // Power function with fixed degree: r[i] = a[i]^b */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPowx(int n, ref float a, float b, ref float r);		

        // Power function with fixed degree: r[i] = a[i]^b */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPowx(int n, ref double a, double b, ref double r);		

		// Power function with a[i]>=0: r[i] = a[i]^b[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPowr(int n, ref float a, ref float b, ref float r);		

        // Power function with a[i]>=0: r[i] = a[i]^b[i] */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPowr(int n, ref double a, ref double b, ref double r);		

        // Reciprocal square root: r[i] = 1/a[i]^0.5 */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsInvSqrt(int n, ref float a, ref float r);		

        // Reciprocal square root: r[i] = 1/a[i]^0.5 */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdInvSqrt(int n, ref double a, ref double r);		

        // Cube root: r[i] = a[i]^(1/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCbrt(int n, ref float a, ref float r);		

        // Cube root: r[i] = a[i]^(1/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCbrt(int n, ref double a, ref double r);		

        // Reciprocal cube root: r[i] = 1/a[i]^(1/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsInvCbrt(int n, ref float a, ref float r);		

        // Reciprocal cube root: r[i] = 1/a[i]^(1/3) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdInvCbrt(int n, ref double a, ref double r);		

        // Exponential function: r[i] = e^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsExp(int n, ref float a, ref float r);		

        // Exponential function: r[i] = e^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdExp(int n, ref double a, ref double r);		

        // Exponential function (base 2): r[i] = 2^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsExp2(int n, ref float a, ref float r);		

        // Exponential function (base 2): r[i] = 2^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdExp2(int n, ref double a, ref double r);		

        // Exponential function (base 10): r[i] = 10^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsExp10(int n, ref float a, ref float r);		

        // Exponential function (base 10): r[i] = 10^a[i] */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdExp10(int n, ref double a, ref double r);		

        // Exponential of arguments decreased by 1: r[i] = e^(a[i]-1) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsExpm1(int n, ref float a, ref float r);		

        // Exponential of arguments decreased by 1: r[i] = e^(a[i]-1) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdExpm1(int n, ref double a, ref double r);		

        // Exponential integral of real vector elements: r[i] = E1(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsExpInt1(int n, ref float a, ref float r);		

        // Exponential integral of real vector elements: r[i] = E1(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdExpInt1(int n, ref double a, ref double r);		

        // Logarithm (base e): r[i] = ln(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLn(int n, ref float a, ref float r);		

        // Logarithm (base e): r[i] = ln(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLn(int n, ref double a, ref double r);		

        // Logarithm (base 2): r[i] = lb(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLog2(int n, ref float a, ref float r);		

        // Logarithm (base 2): r[i] = lb(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLog2(int n, ref double a, ref double r);		

        // Logarithm (base 10): r[i] = lg(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLog10(int n, ref float a, ref float r);		

        // Logarithm (base 10): r[i] = lg(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLog10(int n, ref double a, ref double r);		

        // Logarithm (base e) of arguments increased by 1: r[i] = log(1+a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLog1p(int n, ref float a, ref float r);		

        // Logarithm (base e) of arguments increased by 1: r[i] = log(1+a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLog1p(int n, ref double a, ref double r);		

        // Computes the exponent: r[i] = logb(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLogb(int n, ref float a, ref float r);		

        // Computes the exponent: r[i] = logb(a[i]) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLogb(int n, ref double a, ref double r);		

        // Error function: r[i] = erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErf(int n, ref float a, ref float r);		

        // Error function: r[i] = erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErf(int n, ref double a, ref double r);		

        // Inverse error function: r[i] = erfinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfInv(int n, ref float a, ref float r);		

        // Inverse error function: r[i] = erfinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErfInv(int n, ref double a, ref double r);		

        // Somputes the square root of the sum of two squared elements: r[i] = hypot(a[i],b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsHypot(int n, ref float a, ref float b, ref float r);		

        // Square root of the sum of the squares: r[i] = hypot(a[i],b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdHypot(int n, ref double a, ref double b, ref double r);		

        // Complementary error function: r[i] = 1 - erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfc(int n, ref float a, ref float r);		

        // Complementary error function: r[i] = 1 - erf(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErfc(int n, ref double a, ref double r);		

        // Inverse complementary error function: r[i] = erfcinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsErfcInv(int n, ref float a, ref float r);		

        // Inverse complementary error function: r[i] = erfcinv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdErfcInv(int n, ref double a, ref double r);		

        // Cumulative normal distribution function: r[i] = cdfnorm(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNorm(int n, ref float a, ref float r);		

        // Cumulative normal distribution function: r[i] = cdfnorm(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCdfNorm(int n, ref double a, ref double r);		

        // Inverse cumulative normal distribution function: r[i] = cdfnorminv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCdfNormInv(int n, ref float a, ref float r);		

        // Inverse cumulative normal distribution function: r[i] = cdfnorminv(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCdfNormInv(int n, ref double a, ref double r);		

        // Logarithm (base e) of the absolute value of gamma function: r[i] = lgamma(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLGamma(int n, ref float a, ref float r);		

        // Logarithm (base e) of the absolute value of gamma function: r[i] = lgamma(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLGamma(int n, ref double a, ref double r);		

        // Gamma function: r[i] = tgamma(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsTGamma(int n, ref float a, ref float r);		

        /* Gamma function: r[i] = tgamma(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdTGamma(int n, ref double a, ref double r);		

        /* Linear fraction: r[i] = (a[i]*scalea + shifta)/(b[i]*scaleb + shiftb) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsLinearFrac(int n, ref float a, ref float b, float scalea, float shifta, float scaleb, float shiftb, ref float r);

		/* Linear fraction: r[i] = (a[i]*scalea + shifta)/(b[i]*scaleb + shiftb) */
        [DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdLinearFrac(int n, ref double a, ref double b, double scalea, double shifta, double scaleb, double shiftb, ref double r);

        /* Integer value rounded towards plus infinity: r[i] = ceil(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCeil(int n, ref float a, ref float r);		

        /* Integer value rounded towards plus infinity: r[i] = ceil(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCeil(int n, ref double a, ref double r);		

        /* Integer value rounded towards plus infinity: r[i] = ceil(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFloor(int n, ref float a, ref float r);		

        /* Integer value rounded towards plus infinity: r[i] = ceil(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFloor(int n, ref double a, ref double r);		

        /* Signed fraction part: r[i] = a[i] - |a[i]| */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFrac(int n, ref float a, ref float r);		

        /* Signed fraction part: r[i] = a[i] - |a[i]| */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFrac(int n, ref double a, ref double r);		

        /* Truncated integer value and the remaining fraction part: r1[i] = |a[i]|, r2[i] = a[i] - |a[i]| */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsModf(int n, ref float a, ref float r1, ref float r2);		

        /* Truncated integer value and the remaining fraction part: r1[i] = |a[i]|, r2[i] = a[i] - |a[i]| */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdModf(int n, ref double a, ref double r1, ref double r2);		

        /* Next after function: r[i] = nextafter(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsNextAfter(int n, ref float a, ref float b, ref float r);		

        /* Next after function: r[i] = nextafter(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdNextAfter(int n, ref double a, ref double b, ref double r);		

        /* Positive difference function: r[i] = fdim(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFdim(int n, ref float a, ref float b, ref float r);		

        /* Positive difference function: r[i] = fdim(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFdim(int n, ref double a, ref double b, ref double r);		

        /* Maximum function: r[i] = fmax(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFmax(int n, ref float a, ref float b, ref float r);		

        /* Maximum function: r[i] = fmax(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFmax(int n, ref double a, ref double b, ref double r);		

        /* Minimum function: r[i] = fmin(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsFmin(int n, ref float a, ref float b, ref float r);		

        /* Minimum function: r[i] = fmin(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdFmin(int n, ref double a, ref double b, ref double r);		

        /* Maximum magnitude function: r[i] = maxmag(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsMaxMag(int n, ref float a, ref float b, ref float r);		

        /* Maximum magnitude function: r[i] = maxmag(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdMaxMag(int n, ref double a, ref double b, ref double r);		

        /* Minimum magnitude function: r[i] = minmag(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsMinMag(int n, ref float a, ref float b, ref float r);		

        /* Minimum magnitude function: r[i] = minmag(a[i], b[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdMinMag(int n, ref double a, ref double b, ref double r);		

        /* Value rounded to the nearest integer: r[i] = round(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsRound(int n, ref float a, ref float r);		

        /* Value rounded to the nearest integer: r[i] = round(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdRound(int n, ref double a, ref double r);		

        /* Integer value rounded towards zero: r[i] = trunc(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsTrunc(int n, ref float a, ref float r);		

        /* Integer value rounded towards zero: r[i] = trunc(a[i]) */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdTrunc(int n, ref double a, ref double r);		

        /* Positive Increment Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPackI(int n, ref float a, int incra, ref float y);		

        /* Positive Increment Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPackI(int n, ref double a, int incra, ref double y);		

        /* Index Vector Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPackV(int n, ref float a, ref int ia, ref float y);		

        /* Index Vector Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPackV(int n, ref double a, ref int ia, ref double y);		

        /* Mask Vector Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsPackM(int n, ref float a, ref int ma, ref float y);		

        /* Mask Vector Indexing */
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdPackM(int n, ref double a, ref int ma, ref double y);		


		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCos(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCos(int n, ref double a, ref double r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSin(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSin(int n, ref double a, ref double r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsTan(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdTan(int n, ref double a, ref double r);		

        // Cosine PI: r[i] = cos(a[i]*PI)
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCospi(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCospi(int n, ref double a, ref double r);		


        // Sine PI: r[i] = sin(a[i]*PI)
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSinpi(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSinpi(int n, ref double a, ref double r);		

        // Tangent PI: r[i] = tan(a[i]*PI)
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsTanpi(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdTanpi(int n, ref double a, ref double r);		

        // Cosine degree: r[i] = cos(a[i]*PI/180)
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsCosd(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdCosd(int n, ref double a, ref double r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSind(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSind(int n, ref double a, ref double r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsTand(int n, ref float a, ref float r);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdTand(int n, ref double a, ref double r);		

        // Sine & cosine: r1[i] = sin(a[i]), r2[i]=cos(a[i])
		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vsSinCos(int n, ref float a, ref float r1, ref float r2);		

		[DllImport(VmlDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern void vdSinCos(int n, ref double a, ref double r1, ref double r2);		


    /*  Remaining

        // Hyperbolic cosine: r[i] = ch(a[i])
        _Mkl_Api(void,vsCosh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdCosh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsCosh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdCosh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex hyperbolic cosine: r[i] = ch(a[i])
        _Mkl_Api(void,vcCosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzCosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcCosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzCosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Hyperbolic sine: r[i] = sh(a[i])
        _Mkl_Api(void,vsSinh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdSinh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsSinh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdSinh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex hyperbolic sine: r[i] = sh(a[i])
        _Mkl_Api(void,vcSinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzSinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcSinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzSinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Hyperbolic tangent: r[i] = th(a[i])
        _Mkl_Api(void,vsTanh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdTanh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsTanh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdTanh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex hyperbolic tangent: r[i] = th(a[i])
        _Mkl_Api(void,vcTanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzTanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcTanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzTanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Arc cosine: r[i] = arccos(a[i])
        _Mkl_Api(void,vsAcos,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAcos,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAcos,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAcos,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex arc cosine: r[i] = arccos(a[i])
        _Mkl_Api(void,vcAcos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAcos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAcos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAcos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Arc sine: r[i] = arcsin(a[i])
        _Mkl_Api(void,vsAsin,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAsin,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAsin,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAsin,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex arc sine: r[i] = arcsin(a[i])
        _Mkl_Api(void,vcAsin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAsin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAsin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAsin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Arc tangent: r[i] = arctan(a[i])
        _Mkl_Api(void,vsAtan,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAtan,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAtan,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAtan,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex arc tangent: r[i] = arctan(a[i])
        _Mkl_Api(void,vcAtan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAtan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAtan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAtan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Arc cosine PI: r[i] = arccos(a[i])/PI
        _Mkl_Api(void, vsAcospi, (const MKL_INT n, const float  a[], float  r[]))
        _Mkl_Api(void, vdAcospi, (const MKL_INT n, const double a[], double r[]))

        _Mkl_Api(void, vmsAcospi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void, vmdAcospi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

        // Arc sine PI: r[i] = arcsin(a[i])/PI
        _Mkl_Api(void, vsAsinpi, (const MKL_INT n, const float  a[], float  r[]))
        _Mkl_Api(void, vdAsinpi, (const MKL_INT n, const double a[], double r[]))

        _Mkl_Api(void, vmsAsinpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void, vmdAsinpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

        // Arc tangent PI: r[i] = arctan(a[i])/PI
        _Mkl_Api(void, vsAtanpi, (const MKL_INT n, const float  a[], float  r[]))
        _Mkl_Api(void, vdAtanpi, (const MKL_INT n, const double a[], double r[]))

        _Mkl_Api(void, vmsAtanpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void, vmdAtanpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

        // Hyperbolic arc cosine: r[i] = arcch(a[i])
        _Mkl_Api(void,vsAcosh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAcosh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAcosh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAcosh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex hyperbolic arc cosine: r[i] = arcch(a[i])
        _Mkl_Api(void,vcAcosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAcosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAcosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAcosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Hyperbolic arc sine: r[i] = arcsh(a[i])
        _Mkl_Api(void,vsAsinh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAsinh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAsinh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAsinh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Complex hyperbolic arc sine: r[i] = arcsh(a[i])
        _Mkl_Api(void,vcAsinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAsinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAsinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAsinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

        // Hyperbolic arc tangent: r[i] = arcth(a[i])
        _Mkl_Api(void,vsAtanh,(const MKL_INT n,  const float  a[], float  r[]))
        _Mkl_Api(void,vdAtanh,(const MKL_INT n,  const double a[], double r[]))

        _Mkl_Api(void,vmsAtanh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAtanh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

        // Arc tangent of a/b: r[i] = arctan(a[i]/b[i])
        _Mkl_Api(void,vsAtan2,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
        _Mkl_Api(void,vdAtan2,(const MKL_INT n,  const double a[], const double b[], double r[]))

        _Mkl_Api(void,vmsAtan2,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmdAtan2,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

        // Arc tangent of a/b divided by PI: r[i] = arctan(a[i]/b[i])/PI
        _Mkl_Api(void, vsAtan2pi, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
        _Mkl_Api(void, vdAtan2pi, (const MKL_INT n, const double a[], const double b[], double r[]))

        _Mkl_Api(void, vmsAtan2pi, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
        _Mkl_Api(void, vmdAtan2pi, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

        // Complex hyperbolic arc tangent: r[i] = arcth(a[i])
        _Mkl_Api(void,vcAtanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
        _Mkl_Api(void,vzAtanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

        _Mkl_Api(void,vmcAtanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
        _Mkl_Api(void,vmzAtanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

    */
    }
}
