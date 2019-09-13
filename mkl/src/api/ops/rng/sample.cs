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

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Defines distribution sample operations
    /// </summary>
    public static class sample
    {
        /// <summary>
        /// Samples a discrete uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, Interval<int> range, Span<int> dst)
            => VSL.viRngUniform(0,stream.Source, dst.Length, ref head(dst), range.Left, range.Right).ThrowOnError();

        /// <summary>
        /// Samples a discrete uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, int min, int max, Span<int> dst)
            => VSL.viRngUniform(0,stream.Source, dst.Length, ref head(dst), min, max).ThrowOnError();

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, float min, float max, Span<float> dst)
            => VSL.vsRngUniform(0,stream.Source, dst.Length, ref head(dst), min, max).ThrowOnError();

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, Interval<float> range, Span<float> dst)
            => VSL.vsRngUniform(0,stream.Source, dst.Length, ref head(dst), range.Left, range.Right).ThrowOnError();

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, Interval<double> range, Span<double> dst)
            => VSL.vdRngUniform(0, stream.Source, dst.Length, ref head(dst), range.Left, range.Right).ThrowOnError();

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void uniform(MklRng stream, double min, double max, Span<double> dst)
            => VSL.vdRngUniform(0, stream.Source, dst.Length, ref head(dst), min, max).ThrowOnError();

        /// <summary>
        /// Samples uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void bits(MklRng stream, Span<uint> dst)
            => VSL.viRngUniformBits32(0,stream.Source, dst.Length, ref head(dst)).ThrowOnError();

        /// <summary>
        /// Samples uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void bits(MklRng stream, Span<ulong> dst)
            => VSL.viRngUniformBits64(0, stream.Source, dst.Length, ref head(dst)).ThrowOnError();

        /// <summary>
        /// Samples a single-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void cauchy(MklRng stream, float a, float b, Span<float> dst)
            => VSL.vsRngCauchy(0, stream.Source, dst.Length, ref head(dst), a, b).ThrowOnError();

        /// <summary>
        /// Samples a double-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void cauchy(MklRng stream, double a, double b, Span<double> dst)
            => VSL.vdRngCauchy(0, stream.Source, dst.Length, ref head(dst), a, b).ThrowOnError();

        /// <summary>
        /// Samples a geometric distributions
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void geometric(MklRng stream, double p, Span<int> dst)
            => VSL.viRngGeometric(0, stream.Source, dst.Length, ref head(dst), p).ThrowOnError();

        /// <summary>
        /// Samples a Bernoulli distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="p">The probability of trial success</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void bernoulli(MklRng stream, double p, Span<int> dst)
            => VSL.viRngBernoulli(0, stream.Source, dst.Length, ref head(dst), p).ThrowOnError();

        /// <summary>
        /// Samples a single-precision chi2 distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dof">Degrees of freedom</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void chi2(MklRng stream, int dof, Span<float> dst)
            => VSL.vsRngChiSquare(0, stream.Source, dst.Length, ref head(dst), dof).ThrowOnError();

        /// <summary>
        /// Samples a double-precision chi2 distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dof">Degrees of freedom</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void chi2(MklRng stream, int dof, Span<double> dst)
            => VSL.vdRngChiSquare(0, stream.Source, dst.Length, ref head(dst), dof).ThrowOnError();

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void gaussian(MklRng stream, float mu, float sigma, Span<float> dst)
            => VSL.vsRngGaussian(VslGaussianMethod.BoxMuller1, stream.Source, dst.Length, ref head(dst), mu, sigma).ThrowOnError();

        /// <summary>
        /// Samples a double-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void gaussian(MklRng stream, double mu, double sigma, Span<double> dst)
            => VSL.vdRngGaussian(VslGaussianMethod.BoxMuller1, stream.Source, dst.Length, ref head(dst), mu, sigma).ThrowOnError();

        /// <summary>
        /// Samples a single-precision gamma distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void gamma(MklRng stream, float alpha, float dx, float beta, Span<float> dst)
            => VSL.vsRngGamma(VslGammaMethod.GNorm, stream.Source, dst.Length, ref head(dst), alpha, dx, beta).ThrowOnError();

        /// <summary>
        /// Samples a double-precision gamma distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void gamma(MklRng stream, double alpha, double dx, double beta, Span<double> dst)
            => VSL.vdRngGamma(VslGammaMethod.GNorm, stream.Source, dst.Length, ref head(dst), alpha, dx, beta).ThrowOnError();

        /// <summary>
        /// Samples a single-precision exponential distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void exp(MklRng stream, float dx, float beta, Span<float> dst)
            => VSL.vsRngExponential(0, stream.Source, dst.Length, ref head(dst), dx, beta).ThrowOnError();

        /// <summary>
        /// Samples a double-precision exponential distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void exp(MklRng stream, double dx, double beta, Span<double> dst)
            => VSL.vdRngExponential(0, stream.Source, dst.Length, ref head(dst), dx, beta).ThrowOnError();

        /// <summary>
        /// Samples a poisson distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void poisson(MklRng stream, double alpha, Span<int> dst)
            => VSL.viRngPoisson(0, stream.Source, dst.Length, ref head(dst), alpha).ThrowOnError();
 
        /// <summary>
        /// Samples a single-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="a">The disribution mean</param>
        /// <param name="b">The distribution scale</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void laplace(MklRng stream, float a, float b, Span<float> dst)
            => VSL.vsRngLaplace(0, stream.Source, dst.Length, ref head(dst), a, b).ThrowOnError();

        /// <summary>
        /// Samples a double-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static void laplace(MklRng stream, double mean, double beta, Span<double> dst)
            => VSL.vdRngLaplace(0, stream.Source, dst.Length, ref head(dst), mean, beta).ThrowOnError();         
    }
}