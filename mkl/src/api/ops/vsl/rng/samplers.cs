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

    /// <summary>
    /// Defines factory methods for creating distribution samplers
    /// </summary>
    public static class samplers
    {
        /// <summary>
        /// Creates a bitwise uniform 32-bit sampler
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="dst">The receiving buffer</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<uint> bits32(MklRng src, int? capacity = null)        
            => new UniformBitsSampler<uint>(src, capacity); 

        /// <summary>
        /// Creates a bitwise uniform 64-bit sampler
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="dst">The receiving buffer</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<ulong> bits64(MklRng src, int? capacity = null)        
            => new UniformBitsSampler<ulong>(src, capacity); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<int> uniform(MklRng src, Interval<int> range, int? capacity = null)
            => new UniformSampler<int>(src, range, capacity); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit integers
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<int> uniform(MklRng src, int min, int max, int? capacity = null)
            => new UniformSampler<int>(src, (min,max), capacity); 

        /// <summary>
        /// Creates a uniform sampler for 32-bit floating point
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> uniform(MklRng src, float min, float max, int? capacity = null)
            => new UniformSampler<float>(src, (min,max), capacity); 

        /// <summary>
        /// Creates a uniform sampler for 64-bit floating point
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="range">The sample domain</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> uniform(MklRng src, Interval<float> range, int? capacity = null)                    
            => new UniformSampler<float>(src, range, capacity); 

        /// <summary>
        /// Creates a 64-bit uniform floating-point sampler
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> uniform(MklRng src, double min, double max, int? capacity = null)
            => new UniformSampler<double>(src, (min,max), capacity); 

        /// <summary>
        /// Creates a 64-bit uniform floating-point sampler
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> uniform(MklRng src, Interval<double> range, int? capacity = null)                    
            => new UniformSampler<double>(src, range, capacity); 

        /// <summary>
        /// Creates a Bernoulli sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="p">The probability of trial success</param>
        /// <param name="capacity">The buffer allocation</param>
        [MethodImpl(Inline)]
        public static ISampler<int> bernoulli(MklRng src, double p, int? capacity = null)
            => new BernoulliSampler<int>(src, p, capacity);

        /// <summary>
        /// Creates a single-precision Gaussian sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> gaussian(MklRng src, float mu, float sigma, int? capacity = null)
            => new GaussianSampler<float>(src, mu,sigma, capacity); 

        /// <summary>
        /// Creates a double-precision Gaussian sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> gaussian(MklRng src, double mu, double sigma, int? capacity = null)
            => new GaussianSampler<double>(src, mu,sigma, capacity); 


        /// <summary>
        /// Creates a geometric sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="p">The probability of trial successes</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<int> geometric(MklRng src, double p, int? capacity = null)
            => new BernoulliSampler<int>(src, p, capacity);

        /// <summary>
        /// Creates single-precision gamma sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> gamma(MklRng src, float alpha, float dx, float beta, int? capacity = null)
            => new GammaSampler<float>(src, GammaSpec<float>.Define(alpha, dx, beta), capacity);

        /// <summary>
        /// Creates a double-precision gamma sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dx">The displacement</param>
        /// <param name="beta"></param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> gamma(MklRng src, double alpha, double dx, double beta, int? capacity = null)
            => new GammaSampler<double>(src, GammaSpec<double>.Define(alpha, dx, beta), capacity);

        /// <summary>
        /// Creates a single-precisiion exponential sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> exponential(MklRng src, float a, float b, int? capacity = null)
            => new ExponentialSampler<float>(src, (a,b), capacity);

        /// <summary>
        /// Creates a double-precisiion exponential sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> exponential(MklRng src, double a, double b, int? capacity = null)
            => new ExponentialSampler<double>(src, (a,b), capacity);

        /// <summary>
        /// Creates a Poisson sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="alpha"></param>
        /// <param name="dst"></param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<int> poisson(MklRng src, double alpha, int? capacity = null)
            => new PoissonSampler<int>(src, alpha, capacity);

        /// <summary>
        /// Creates a single-precision chi2 sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dof">Degrees of freedom</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> chisquare32(MklRng src, int dof, int? capacity = null)
            => new ChiSquareSampler<float>(src, dof, capacity);

        /// <summary>
        /// Creates a double-precision chi2 sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dof">Degrees of freedom</param>
        /// <param name="capacity">The length of the sampler's buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> chisquare64(MklRng src, int dof, int? capacity = null)
            => new ChiSquareSampler<double>(src, dof, capacity);

        /// <summary>
        /// Creates a single-precision Cauchy sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="location">The distribution mean</param>
        /// <param name="scale">The scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> cauchy(MklRng src, float location, float scale, int? capacity = null)
            => new CauchySampler<float>(src, location, scale, capacity); 
 
        /// <summary>
        /// Creates a double-precision Cauchy sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="location">The distribution mean</param>
        /// <param name="scale">The scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<double> cauchy(MklRng src, double location, double scale, int? capacity = null)
            => new CauchySampler<double>(src, location, scale, capacity); 

        /// <summary>
        /// Creates a single-precision Laplace sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="location">The distribution mean</param>
        /// <param name="scale">The scale</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]
        public static ISampler<float> laplace(MklRng src, float location, float scale, int? capacity = null)
            => new LaplaceSampler<float>(src, location, scale, capacity); 
 
        /// <summary>
        /// Creates a double-precision Laplace sampler
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="location">The distribution mean</param>
        /// <param name="scale">The scale</param>
        /// <param name="buffer">The reception buffer</param>
       [MethodImpl(Inline)]
        public static ISampler<double> laplace(MklRng src, double location, double scale, int? capacity = null)
            => new LaplaceSampler<double>(src, location, scale, capacity); 
 
    }
 
}