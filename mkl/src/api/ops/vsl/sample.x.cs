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
        /// Draws 64-bit samples from a bit-level uniform distribution
        /// </summary>
        /// <param name="vsls">The vsl source stream</param>
        /// <param name="dst">The receiving buffer</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformBitsSample<ulong> UniformBits(this RngStream vsls, MemorySpan<ulong> dst)        
            => mkl.bits(vsls, dst);

        /// <summary>
        /// Draws 32-bit samples from a bit-level uniform distribution
        /// </summary>
        /// <param name="vsls">The vsl source stream</param>
        /// <param name="dst">The receiving buffer</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformBitsSample<uint> UniformBits(this RngStream vsls, MemorySpan<uint> dst)        
            => mkl.bits(vsls, dst);

        /// <summary>
        /// Samples a continuous uniform distribution of 64-bit floats
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<double> Uniform(this RngStream vsls, Interval<double> range, MemorySpan<double> dst)                    
            => mkl.uniform(vsls,range,dst);        

        /// <summary>
        /// Samples a continuous uniform distribution of 64-bit floats
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<double> Uniform(this RngStream vsls, double min, double max, MemorySpan<double> dst)                    
            => mkl.uniform(vsls,(min,max),dst);        

        /// <summary>
        /// Samples a continuous uniform distribution of 32-bit floats
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<float> Uniform(this RngStream vsls, Interval<float> range, MemorySpan<float> dst)
            => mkl.uniform(vsls,range,dst);

        /// <summary>
        /// Samples a continuous uniform distribution of 32-bit floats
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<float> Uniform(this RngStream vsls, float min, float max, MemorySpan<float> dst)
            => mkl.uniform(vsls,(min,max),dst);

        /// <summary>
        /// Samples a discrete uniform distribution of 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<int> Uniform(this RngStream vsls, Interval<int> range, MemorySpan<int> dst)
            => mkl.uniform(vsls,range,dst);

        /// <summary>
        /// Samples a discrete uniform distribution of 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]
        public static UniformSample<int> Uniform(this RngStream vsls, int min, int max, MemorySpan<int> dst)
            => mkl.uniform(vsls,(min,max),dst);

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static GaussianSample<float> Gaussian(this RngStream vsls, float mu, float sigma, MemorySpan<float> dst)
            => mkl.gaussian(vsls,mu,sigma,dst);

        /// <summary>
        /// Samples a double-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static GaussianSample<double> Gaussian(this RngStream vsls, double mu, double sigma, MemorySpan<double> dst)
            => mkl.gaussian(vsls,mu,sigma,dst);

        /// <summary>
        /// Samples a single-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static GammaSample<float> Gamma(this RngStream vsls, float alpha, float dx, float beta, MemorySpan<float> dst)
            => mkl.gamma(vsls,alpha,dx,beta,dst);

        /// <summary>
        /// Samples a double-precision gamma distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static GammaSample<double> Gamma(this RngStream vsls, double alpha, double dx, double beta, MemorySpan<double> dst)
            => mkl.gamma(vsls,alpha,dx,beta,dst);

        /// <summary>
        /// Samples a single-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ExponentialSample<float> Exponential(this RngStream vsls, float dx, float beta, MemorySpan<float> dst)
            => mkl.exp(vsls,dx,beta,dst);

        /// <summary>
        /// Samples a double-precision exponential distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ExponentialSample<double> Exponential(this RngStream vsls, double dx, double beta, MemorySpan<double> dst)
            => mkl.exp(vsls,dx,beta,dst);
        
        /// <summary>
        /// Samples a Bernoulli distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The probability of trial success</param>
        /// <param name="dst">The receiving buffer</param>
        [MethodImpl(Inline)]
        public static BernoulliSample<int> Bernoulli(this RngStream vsls, double p, MemorySpan<int> dst)
            => mkl.bernoulli(vsls,p, dst);

        [MethodImpl(Inline)]
        public static GeometricSample<int> Geometric(this RngStream vsls, double p, MemorySpan<int> dst)
            => mkl.geometric(vsls,p, dst);

        [MethodImpl(Inline)]
        public static PoissonSample<int> Poisson(this RngStream vsls, double alpha, MemorySpan<int> dst)
            => mkl.poisson(vsls,alpha, dst);

        [MethodImpl(Inline)]
        public static ChiSquareSample<float> Chi32(this RngStream vsls, int freedom, MemorySpan<float> dst)
             => mkl.chi2(vsls,freedom, dst);

        [MethodImpl(Inline)]
        public static ChiSquareSample<double> Chi64(this RngStream vsls, int freedom, MemorySpan<double> dst)
             => mkl.chi2(vsls,freedom, dst);

        /// <summary>
        /// Samples a single-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static CauchySample<float> Cauchy(this RngStream vsls, float a, float b, MemorySpan<float> dst)
            => mkl.cauchy(vsls,a,b,dst);
 
        /// <summary>
        /// Samples a double-precision Cauchy distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="buffer">The reception buffer</param>
       [MethodImpl(Inline)]
        public static CauchySample<double> Cauchy(this RngStream vsls, float a, float b, MemorySpan<double> dst)
            => mkl.cauchy(vsls,a,b,dst);

        /// <summary>
        /// Samples a single-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static LaplaceSample<float> Laplace(this RngStream vsls, float mean, float beta, MemorySpan<float> dst)
            => mkl.laplace(vsls,mean,beta,dst);
 
        /// <summary>
        /// Samples a double-precision Laplace distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mean">The disribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="buffer">The reception buffer</param>
       [MethodImpl(Inline)]
        public static LaplaceSample<double> Laplace(this RngStream vsls, double mean, double beta, MemorySpan<double> dst)
            => mkl.laplace(vsls,mean,beta,dst);
    }
}