//-----------------------------------------------------------------------------
// Copyright   :  Intel
// License     :  See License.txt
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
    static partial class VSL
    {        
        const string VslDll = "z0-vsl-clib.dll";

        /// <summary>
        /// Generates random numbers uniformly distributed over the interval [a, b).
        /// </summary>
        /// <param name="method">Always 0</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="a">The inclusive lower bound of the generated values</param>
        /// <param name="b">The exclusive upper bound of the generated values</param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniform(int method, IntPtr stream, int count, ref int values, int a, int b);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngUniform(int method, IntPtr stream, int count, ref float values, float a, float b);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngUniform(int method, IntPtr stream, int count, ref double values, double a, double b);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniformBits64(int method, IntPtr stream, int count, ref ulong values);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngUniformBits32(int method, IntPtr stream, int count, ref uint values);
        
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngBernoulli(int method, IntPtr stream, int count, ref int values, double p);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngGeometric(int method, IntPtr stream, int count, ref int values, double p);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngCauchy(int method, IntPtr stream, int count, ref double values, double a, double b);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngCauchy(int method, IntPtr stream, int count, ref float values, float a, float b);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngGaussian(VslGaussianMethod method, IntPtr stream, int count, ref float values, float mu, float sigma);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngGaussian(VslGaussianMethod method, IntPtr stream, int count, ref double values, double mu, double sigma);

        /// <summary>
        /// Samples a single-precision Gamma distribution
        /// </summary>
        /// <param name="method">See <see cref='VslGammaMethod'/> for possible values</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="alpha">The shape parameter</param>
        /// <param name="a">The displacement value</param>
        /// <param name="beta">The scalefactor parameter</param>
        /// <remarks>
        /// alpha greater than 1 -  algorithm of Marsaglia is used, nonlinear
        ///                       transformation of gaussian numbers based on
        ///                       acceptance/rejection method with squeezes;
        /// alpha in [0.6, 1) -    rejection from the Weibull distribution is used;
        /// alpha less than .6   - transformation of exponential power distribution
        ///                       (EPD) is used, EPD random numbers are generated
        ///                       by means of acceptance/rejection technique;
        /// alpha==1             - gamma distribution reduces to exponential distribution
        /// </remarks>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngGamma(VslGammaMethod method, IntPtr stream, int count, ref float values, float alpha, float a, float beta);

        /// <summary>
        /// Samples a double-precision Gamma distribution
        /// </summary>
        /// <param name="method">See <see cref='VslGammaMethod'/> for possible values</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="alpha">The shape parameter</param>
        /// <param name="a">The displacement value</param>
        /// <param name="beta">The scalefactor parameter</param>
        /// <remarks>
        /// alpha greater than 1 -  algorithm of Marsaglia is used, nonlinear
        ///                       transformation of gaussian numbers based on
        ///                       acceptance/rejection method with squeezes;
        /// alpha in [0.6, 1) -    rejection from the Weibull distribution is used;
        /// alpha less than .6   - transformation of exponential power distribution
        ///                       (EPD) is used, EPD random numbers are generated
        ///                       by means of acceptance/rejection technique;
        /// alpha==1             - gamma distribution reduces to exponential distribution
        /// </remarks>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngGamma(VslGammaMethod method, IntPtr stream, int count, ref double values, double alpha, double a, double beta);

        /// <summary>
        /// Samples a single-precision Chi^2 distribution
        /// </summary>
        /// <param name="method">Always 0</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="v">The degrees of freedom</param>
        /// <remarks>
        /// v = 1, v = 3               - chi-square distributed random number is
        ///                              generated as a sum of squares of v independent
        ///                              normal random numbers;
        /// v is even and v = 16       - chi-square distributed random number is
        ///                              generated using the following formula:
        ///                              x = -2*ln(u[0]*...*u[v/2-1]),
        ///                              where u[i] - random numbers uniformly
        ///                              distributed over the interval (0,1);
        /// v > 16, v is odd and v > 3 - chi-square distribution reduces to gamma
        ///                              distribution;
        /// </remarks>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngChiSquare(int method, IntPtr stream, int count, ref float values, int v);

        /// <summary>
        /// Samples a double-precision Chi^2 distribution
        /// </summary>
        /// <param name="method">Always 0</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="v">The degrees of freedom</param>
        /// <remarks>
        /// v = 1, v = 3               - chi-square distributed random number is
        ///                              generated as a sum of squares of v independent
        ///                              normal random numbers;
        /// v is even and v = 16       - chi-square distributed random number is
        ///                              generated using the following formula:
        ///                              x = -2*ln(u[0]*...*u[v/2-1]),
        ///                              where u[i] - random numbers uniformly
        ///                              distributed over the interval (0,1);
        /// v > 16, v is odd and v > 3 - chi-square distribution reduces to gamma
        ///                              distribution;
        /// </remarks>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngChiSquare(int method, IntPtr stream, int count, ref double values, int v);

        /// <summary>
        /// POISNORM :  for lambda>=1 method is based on Poisson inverse CDF
        ///            approximation by Gaussian inverse CDF; for lambda < 1
        ///            table lookup method is used.
        /// </summary>
        /// <param name="method">The particular methodology used in the sampling process</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="count">The number of values to sample</param>
        /// <param name="values">The sample-receiving buffer</param>
        /// <param name="lambda"></param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngPoisson(VslPoissonMethod method, IntPtr stream, int count, ref int values, double lambda);

        
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus viRngPoissonV(int method, IntPtr stream, int count, ref int values, ref double p);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method">The particular methodology used in the sampling process</param>
        /// <param name="stream">An intialized brng stream</param>
        /// <param name="vectors">The number of n-dimensional vectors to sample</param>
        /// <param name="components">Target into which vectors will be written</param>
        /// <param name="n">The number of dimensions</param>
        /// <param name="storage">The matrix storage format</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngGaussianMV(VslGaussianMVMethod method, IntPtr stream, int vectors, ref double components, int n, VslMatrixStorage storage, ref double A, ref double B);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngGaussianMV(VslGaussianMVMethod method, IntPtr stream, int vectors, ref float components, int n, VslMatrixStorage storage, ref float A, ref float B);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngExponential(int method, IntPtr stream, int count, ref float values, float dx, float beta);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngExponential(int method, IntPtr stream, int count, ref double values, double dx, double beta);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vsRngLaplace(int method, IntPtr stream, int count, ref float values, float dx, float beta);

        [DllImport(VslDll, CallingConvention=Cdecl, ExactSpelling=true)]
        public static extern VslRngStatus vdRngLaplace(int method, IntPtr stream, int count, ref double values, double dx, double beta);


    }
}


/*

_Mkl_Api(int,vdRngLaplace,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngLaplace,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

_Mkl_Api(int,vdRngWeibull,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  ))
_Mkl_Api(int,vsRngWeibull,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float   ))

_Mkl_Api(int,vdRngRayleigh,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  double [], const double  , const double  ))
_Mkl_Api(int,vsRngRayleigh,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  float [],  const float  ,  const float   ))

_Mkl_Api(int,vdRngLognormal,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  , const double  ))
_Mkl_Api(int,vsRngLognormal,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float  ,  const float   ))

 */