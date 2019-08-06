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
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformRangeSample<int> uniform(VslStream stream, Interval<int> range, Memory<int> buffer)
        {
            VSL.viRngUniform(0,stream, buffer.Length, ref buffer.Span[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformRangeSample<float> uniform(VslStream stream, Interval<float> range, Memory<float> buffer)
        {
            VSL.vsRngUniform(0,stream, buffer.Length, ref buffer.Span[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        /// <summary>
        /// Samples a continuous uniform distribution over specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformRangeSample<double> uniform(VslStream stream, Interval<double> range, Memory<double> buffer)
        {
            VSL.vdRngUniform(0,stream, buffer.Length, ref buffer.Span[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        /// <summary>
        /// Samples a Cauchy distribution
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static CauchySample<float> cauchy(VslStream stream, float a, float b, Memory<float> buffer)
        {
            VSL.vsRngCauchy(0, stream, buffer.Length, ref buffer.Span[0], a, b).ThrowOnError();
            return stream.Brng().CauchySample(a,b,buffer);
        }

        [MethodImpl(Inline)]    
        public static CauchySample<double> cauchy(VslStream stream, double a, double b, Memory<double> buffer)
        {
            VSL.vdRngCauchy(0, stream, buffer.Length, ref buffer.Span[0], a, b).ThrowOnError();
            return stream.Brng().CauchySample(a,b,buffer);
        }

        /// <summary>
        /// Samples uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<uint> bits(VslStream stream, Memory<uint> buffer)
        {            
            VSL.viRngUniformBits32(0,stream, buffer.Length, ref buffer.Span[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// Samples uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<ulong> bits(VslStream stream, Memory<ulong> buffer)
        {
            VSL.viRngUniformBits64(0,stream, buffer.Length, ref buffer.Span[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// Samples a geometric distributions
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GeometricSample<int> geometric(VslStream stream, double p, Memory<int> buffer)
        {
            VSL.viRngGeometric(0, stream, buffer.Length, ref buffer.Span[0], p).ThrowOnError();
            return stream.Brng().GeometricSample(p, buffer);
        }

        /// <summary>
        /// Samples a bBernoulli distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="buffer">The reception buffer</param>
        public static Span<Bit> bernoulli(VslStream stream, double p, Span<Bit> buffer)
        {
            Span<int> tmp = stackalloc int[buffer.Length];
            VSL.viRngBernoulli(0, stream, buffer.Length, ref tmp[0],p).ThrowOnError();
            for(var i=0; i < buffer.Length; i++)
                buffer[i] =tmp[i];
            return buffer;
        }

        [MethodImpl(Inline)]    
        public static BernoulliSample<int> bernoulli(VslStream stream, double p, Memory<int> buffer)
        {
            VSL.viRngBernoulli(0, stream, buffer.Length, ref buffer.Span[0],p).ThrowOnError();
            return stream.Brng().BernoulliSample(p, buffer);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<float> chi2(VslStream stream, int freedom, Memory<float> buffer)
        {
            VSL.vsRngChiSquare(0, stream, buffer.Length, ref buffer.Span[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSample(freedom,buffer);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<double> chi2(VslStream stream, int freedom, Memory<double> buffer)
        {
            VSL.vdRngChiSquare(0, stream, buffer.Length, ref buffer.Span[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSample(freedom,buffer);
        }

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<float> gaussian(VslStream stream, float mu, float sigma, Memory<float> buffer)
        {
            VSL.vsRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer.Span[0], mu, sigma).ThrowOnError();
            return stream.Brng().GaussianSample(mu,sigma,buffer);
        }

        /// <summary>
        /// Samples a double-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<double> gaussian(VslStream stream, double mu, double sigma, Memory<double> buffer)
        {
            VSL.vdRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer.Span[0], mu, sigma).ThrowOnError();
            return stream.Brng().GaussianSample(mu,sigma,buffer);
        }

        /// <summary>
        /// Samples a single-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GammaSample<float> gamma(VslStream stream, float alpha, float dx, float beta, Memory<float> buffer)
        {
            VSL.vsRngGamma(VslGammaMethod.GNorm, stream, buffer.Length, ref buffer.Span[0], alpha, dx, beta).ThrowOnError();
            return stream.Brng().GammaSample(alpha, dx, beta, buffer);
        }

        /// <summary>
        /// Samples a double-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GammaSample<double> gamma(VslStream stream, double alpha, double dx, double beta, Memory<double> buffer)
        {
            VSL.vdRngGamma(VslGammaMethod.GNorm, stream, buffer.Length, ref buffer.Span[0], alpha, dx, beta).ThrowOnError();
            return stream.Brng().GammaSample(alpha, dx, beta, buffer);
        }

        /// <summary>
        /// Samples a single-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static ExponentialSample<float> exp(VslStream stream, float dx, float beta, Memory<float> buffer)
        {
            VSL.vsRngExponential(0, stream, buffer.Length, ref buffer.Span[0], dx, beta).ThrowOnError();
            return stream.Brng().ExponentialSample(dx, beta, buffer);
        }

        /// <summary>
        /// Samples a double-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static ExponentialSample<double> exp(VslStream stream, double dx, double beta, Memory<double> buffer)
        {
            VSL.vdRngExponential(0, stream, buffer.Length, ref buffer.Span[0], dx, beta).ThrowOnError();
            return stream.Brng().ExponentialSample(dx, beta, buffer);
        }

        /// <summary>
        /// Samples a poisson distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static PoissonSample<int> poisson(VslStream stream, double alpha, Memory<int> buffer)
        {
            VSL.viRngPoisson(0, stream, buffer.Length, ref buffer.Span[0], alpha).ThrowOnError();
            return stream.Brng().PoissonSample(alpha, buffer);
        }
 
        /// <summary>
        /// Samples a single-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static LaplaceSample<float> laplace(VslStream stream, float mean, float beta, Memory<float> buffer)
        {
            VSL.vsRngLaplace(0, stream, buffer.Length, ref buffer.Span[0], mean, beta).ThrowOnError();
            return stream.Brng().LaplaceSample(mean,beta,buffer);
        }

        /// <summary>
        /// Samples a double-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static LaplaceSample<double> laplace(VslStream stream, double mean, double beta, Memory<double> buffer)
        {
            VSL.vdRngLaplace(0, stream, buffer.Length, ref buffer.Span[0], mean, beta).ThrowOnError();
            return stream.Brng().LaplaceSample(mean,beta,buffer);
        }
    }
}