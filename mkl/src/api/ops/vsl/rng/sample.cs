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

    partial class mkl
    {            
        /// <summary>
        /// Samples a discrete uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<int> uniform(RngStream stream, Interval<int> range, MemorySpan<int> dst)
        {
            VSL.viRngUniform(0,stream.VslSource, dst.Length, ref dst.Span[0], range.Left, range.Right).ThrowOnError();
            return new UniformSample<int>(stream.RngKind, range,dst);
        }

        /// <summary>
        /// Samples a discrete uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<int> uniform(RngStream stream, int min, int max, MemorySpan<int> dst)
        {
            VSL.viRngUniform(0,stream.VslSource, dst.Length, ref dst.Span[0], min, max).ThrowOnError();
            return new UniformSample<int>(stream.RngKind, (min,max) ,dst);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<float> uniform(RngStream stream, float min, float max, MemorySpan<float> dst)
        {
            VSL.vsRngUniform(0,stream.VslSource, dst.Length, ref dst.Span[0], min, max).ThrowOnError();
            return new UniformSample<float>(stream.RngKind, (min,max), dst);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<float> uniform(RngStream stream, Interval<float> range, MemorySpan<float> dst)
        {
            VSL.vsRngUniform(0,stream.VslSource, dst.Length, ref dst.Span[0], range.Left, range.Right).ThrowOnError();
            return new UniformSample<float>(stream.RngKind, range, dst);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<double> uniform(RngStream stream, Interval<double> range, MemorySpan<double> dst)
        {
            VSL.vdRngUniform(0, stream.VslSource, dst.Length, ref dst.Span[0], range.Left, range.Right).ThrowOnError();
            return new UniformSample<double>(stream.RngKind, range, dst);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformSample<double> uniform(RngStream stream, double min, double max, MemorySpan<double> dst)
        {
            VSL.vdRngUniform(0, stream.VslSource, dst.Length, ref dst.Span[0], min, max).ThrowOnError();
            return new UniformSample<double>(stream.RngKind, (min,max), dst);
        }

        /// <summary>
        /// Samples uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<uint> bits(RngStream stream, MemorySpan<uint> dst)
        {            
            VSL.viRngUniformBits32(0,stream.VslSource, dst.Length, ref dst.Span[0]).ThrowOnError();
            return new UniformBitsSample<uint>(stream.RngKind, dst);
        }

        /// <summary>
        /// Samples uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<ulong> bits(RngStream stream, MemorySpan<ulong> dst)
        {
            VSL.viRngUniformBits64(0, stream.VslSource, dst.Length, ref dst.Span[0]).ThrowOnError();
            return new UniformBitsSample<ulong>(stream.RngKind, dst);
        }

        /// <summary>
        /// Samples a single-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static CauchySample<float> cauchy(RngStream stream, float a, float b, MemorySpan<float> dst)
        {
            VSL.vsRngCauchy(0, stream.VslSource, dst.Length, ref dst.Span[0], a, b).ThrowOnError();
            return new CauchySample<float>(stream.RngKind, a,b, dst);            
        }

        /// <summary>
        /// Samples a double-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static CauchySample<double> cauchy(RngStream stream, double a, double b, MemorySpan<double> dst)
        {
            VSL.vdRngCauchy(0, stream.VslSource, dst.Length, ref dst.Span[0], a, b).ThrowOnError();
            return new CauchySample<double>(stream.RngKind, a,b, dst);            
        }

        /// <summary>
        /// Samples a geometric distributions
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static GeometricSample<int> geometric(RngStream stream, double p, MemorySpan<int> dst)
        {
            VSL.viRngGeometric(0, stream.VslSource, dst.Length, ref dst.Span[0], p).ThrowOnError();
            return new GeometricSample<int>(stream.RngKind, p, dst);
        }

        /// <summary>
        /// Samples a Bernoulli distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The probability of trial success</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static BernoulliSample<int> bernoulli(RngStream stream, double p, MemorySpan<int> dst)
        {
            VSL.viRngBernoulli(0, stream.VslSource, dst.Length, ref dst.Span[0],p).ThrowOnError();
            return new BernoulliSample<int>(stream.RngKind, p, dst);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<float> chi2(RngStream stream, int freedom, MemorySpan<float> dst)
        {
            VSL.vsRngChiSquare(0, stream.VslSource, dst.Length, ref dst.Span[0], freedom).ThrowOnError();
            return new ChiSquareSample<float>(stream.RngKind, freedom, dst);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<double> chi2(RngStream stream, int freedom, MemorySpan<double> dst)
        {
            VSL.vdRngChiSquare(0, stream.VslSource, dst.Length, ref dst.Span[0], freedom).ThrowOnError();
            return new ChiSquareSample<double>(stream.RngKind, freedom, dst);
        }

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<float> gaussian(RngStream stream, float mu, float sigma, MemorySpan<float> dst)
        {
            VSL.vsRngGaussian(VslGaussianMethod.BoxMuller1, stream.VslSource, dst.Length, ref dst.Span[0], mu, sigma).ThrowOnError();
            return new GaussianSample<float>(stream.RngKind,  mu, sigma, dst);
        }

        /// <summary>
        /// Samples a double-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<double> gaussian(RngStream stream, double mu, double sigma, MemorySpan<double> dst)
        {
            VSL.vdRngGaussian(VslGaussianMethod.BoxMuller1, stream.VslSource, dst.Length, ref dst.Span[0], mu, sigma).ThrowOnError();
            return new GaussianSample<double>(stream.RngKind,  mu, sigma, dst);
        }

        /// <summary>
        /// Samples a single-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static GammaSample<float> gamma(RngStream stream, float alpha, float dx, float beta, MemorySpan<float> dst)
        {
            VSL.vsRngGamma(VslGammaMethod.GNorm, stream.VslSource, dst.Length, ref dst.Span[0], alpha, dx, beta).ThrowOnError();
            return new GammaSample<float>(stream.RngKind, alpha, dx, beta, dst);
        }

        /// <summary>
        /// Samples a double-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static GammaSample<double> gamma(RngStream stream, double alpha, double dx, double beta, MemorySpan<double> dst)
        {
            VSL.vdRngGamma(VslGammaMethod.GNorm, stream.VslSource, dst.Length, ref dst.Span[0], alpha, dx, beta).ThrowOnError();
            return new GammaSample<double>(stream.RngKind, alpha, dx, beta, dst);
        }

        /// <summary>
        /// Samples a single-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static ExponentialSample<float> exp(RngStream stream, float dx, float beta, MemorySpan<float> dst)
        {
            VSL.vsRngExponential(0, stream.VslSource, dst.Length, ref dst.Span[0], dx, beta).ThrowOnError();
            return new ExponentialSample<float>(stream.RngKind, dx, beta, dst);
        }

        /// <summary>
        /// Samples a double-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static ExponentialSample<double> exp(RngStream stream, double dx, double beta, MemorySpan<double> dst)
        {
            VSL.vdRngExponential(0, stream.VslSource, dst.Length, ref dst.Span[0], dx, beta).ThrowOnError();
            return new ExponentialSample<double>(stream.RngKind, dx, beta, dst);
        }

        /// <summary>
        /// Samples a poisson distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static PoissonSample<int> poisson(RngStream stream, double alpha, MemorySpan<int> dst)
        {
            VSL.viRngPoisson(0, stream.VslSource, dst.Length, ref dst.Span[0], alpha).ThrowOnError();
            return new PoissonSample<int>(stream.RngKind, alpha, dst);
        }
 
        /// <summary>
        /// Samples a single-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static LaplaceSample<float> laplace(RngStream stream, float mean, float beta, MemorySpan<float> dst)
        {
            VSL.vsRngLaplace(0, stream.VslSource, dst.Length, ref dst.Span[0], mean, beta).ThrowOnError();
            return new LaplaceSample<float>(stream.RngKind,  mean, beta, dst);
        }

        /// <summary>
        /// Samples a double-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]    
        public static LaplaceSample<double> laplace(RngStream stream, double mean, double beta, MemorySpan<double> dst)
        {
            VSL.vdRngLaplace(0, stream.VslSource, dst.Length, ref dst.Span[0], mean, beta).ThrowOnError();
            return new LaplaceSample<double>(stream.RngKind,  mean, beta, dst);
       }
    }
}