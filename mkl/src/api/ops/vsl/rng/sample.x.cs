//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
	using static zfunc;

    partial class mklx
    {
        /// <summary>
        /// Creates a 64-bit uniform bit sampler
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="dst">The receiving buffer</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<ulong> UniformBits64(this RngStream src, int? bufferLen = null)        
            => new UniformBitsSampler<ulong>(src, bufferLen); 

        /// <summary>
        /// Creates a 32-bit uniform bit sampler
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="dst">The receiving buffer</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<uint> UniformBits32(this RngStream src, int? bufferLen = null)        
            => new UniformBitsSampler<uint>(src, bufferLen); 

        /// <summary>
        /// Creates a 64-bit uniform floating-point sampler
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<double> Uniform(this RngStream src, Interval<double> range, int? bufferLen = null)                    
            => new UniformSampler<double>(src, range, bufferLen); 

        /// <summary>
        /// Creates a 64-bit uniform floating-point sampler
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static ISampler<double> Uniform(this RngStream src, double min, double max, int? bufferLen = null)
            => new UniformSampler<double>(src, (min,max), bufferLen); 

        /// <summary>
        /// Creates a uniform sampler for 64-bit floating point
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="range">The sample domain</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<float> Uniform(this RngStream src, Interval<float> range, int? bufferLen = null)                    
            => new UniformSampler<float>(src, range, bufferLen); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit floating point
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<float> Uniform(this RngStream src, float min, float max, int? bufferLen = null)
            => new UniformSampler<float>(src, (min,max), bufferLen); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<int> Uniform(this RngStream src, Interval<int> range, int? bufferLen = null)
            => new UniformSampler<int>(src, range, bufferLen); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<int> Uniform(this RngStream src, int min, int max, int? bufferLen = null)
            => new UniformSampler<int>(src, (min,max), bufferLen); 

        /// <summary>
        /// Creates a Gaussian sampler for 32-bit floats
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<float> Gaussian(this RngStream src, float mu, float sigma, int? bufferLen = null)
            => new GaussianSampler<float>(src, mu,sigma, bufferLen); 

        /// <summary>
        /// Creates a Gaussian sampler for 64-bit floats
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<double> Gaussian(this RngStream src, double mu, double sigma, int? bufferLen = null)
            => new GaussianSampler<double>(src, mu,sigma, bufferLen); 

        /// <summary>
        /// Creates a Bernoulli sampler
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="p">The probability of trial success</param>
        /// <param name="bufferLen">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<int> Bernoulli(this RngStream src, double p, int? bufferLen = null)
            => new BernoulliSampler<int>(src, p, bufferLen);

        /// <summary>
        /// Creates a geometric sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="p">The probability of trial successes</param>
        /// <param name="bufferLen">The buffer allocation</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ISampler<int> Geometric(this RngStream src, double p, int? bufferLen = null)
            => new BernoulliSampler<int>(src, p, bufferLen);

        /// <summary>
        /// Creates a gamma sampler for 32-bit floats
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> Gamma(this RngStream src, float alpha, float dx, float beta, int? bufferLen = null)
            => new GammaSampler<float>(src, GammaSpec<float>.Define(alpha, dx, beta), bufferLen);

        /// <summary>
        /// Creates a gamma sampler for 64-bit floats
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> Gamma(this RngStream src, double alpha, double dx, double beta, int? bufferLen = null)
            => new GammaSampler<double>(src, GammaSpec<double>.Define(alpha, dx, beta), bufferLen);

        /// <summary>
        /// Samples a single-precision exponential distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ExponentialSample<float> Exponential(this RngStream src, float dx, float beta, MemorySpan<float> dst)
            => mkl.exp(src,dx,beta,dst);

        /// <summary>
        /// Samples a double-precision exponential distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ExponentialSample<double> Exponential(this RngStream src, double dx, double beta, MemorySpan<double> dst)
            => mkl.exp(src,dx,beta,dst);        

        [MethodImpl(Inline)]
        public static PoissonSample<int> Poisson(this RngStream src, double alpha, MemorySpan<int> dst)
            => mkl.poisson(src,alpha, dst);

        [MethodImpl(Inline)]
        public static ChiSquareSample<float> Chi32(this RngStream src, int freedom, MemorySpan<float> dst)
             => mkl.chi2(src,freedom, dst);

        [MethodImpl(Inline)]
        public static ChiSquareSample<double> Chi64(this RngStream src, int freedom, MemorySpan<double> dst)
             => mkl.chi2(src,freedom, dst);

        /// <summary>
        /// Samples a single-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static CauchySample<float> Cauchy(this RngStream src, float a, float b, MemorySpan<float> dst)
            => mkl.cauchy(src,a,b,dst);
 
        /// <summary>
        /// Samples a double-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static CauchySample<double> Cauchy(this RngStream src, float a, float b, MemorySpan<double> dst)
            => mkl.cauchy(src,a,b,dst);

        /// <summary>
        /// Samples a single-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static LaplaceSample<float> Laplace(this RngStream src, float mean, float beta, MemorySpan<float> dst)
            => mkl.laplace(src,mean,beta,dst);
 
        /// <summary>
        /// Samples a double-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The source stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
       [MethodImpl(Inline)]
        public static LaplaceSample<double> Laplace(this RngStream src, double mean, double beta, MemorySpan<double> dst)
            => mkl.laplace(src,mean,beta,dst);
    }
}