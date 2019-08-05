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
        /// Allocates a stream predicated on a specified RNG and a seed
        /// </summary>
        /// <param name="brng">The RNG through which the data points will be constructed</param>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream stream(BRNG brng, uint seed)
        {
            IntPtr stream = IntPtr.Zero;
            VSL.vslNewStream(ref stream, brng, seed).ThrowOnError();
            return stream;
        }
                
        /// <summary>
        /// Gets the brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        [MethodImpl(Inline)]    
        public static BRNG brng(VslStream stream)
            => VSL.vslGetStreamStateBrng(stream);

        /// <summary>
        /// Creates a stream predicated on the VSL_BRNG_MCG31, A 31-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMcg31(uint seed)
            => stream(BRNG.VSL_BRNG_MCG31, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_R250, A generalized feedback shift register generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gR250(uint seed)
            => stream(BRNG.VSL_BRNG_R250, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MCG59, A 59-bit multiplicative congruential generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMcg59(uint seed)
            => stream(BRNG.VSL_BRNG_MCG59, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MRG32K3A, A combined multiple recursive generator with two components of order 3.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMrg32K31(uint seed)
            => stream(BRNG.VSL_BRNG_MRG32K3A, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_NONDETERM, A non-deterministic random number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gRandom(uint seed)
            => stream(BRNG.VSL_BRNG_NONDETERM, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT19937, A SIMD-oriented Fast Mersenne Twister pseudorandom number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gMt19937(uint seed)
            => stream(BRNG.VSL_BRNG_MT19937, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_SOBOL, A 32-bit Gray code-based generator producing low-discrepancy sequences for dimensions 1 ≤ s ≤ 40
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gSobol(uint seed)
            => stream(BRNG.VSL_BRNG_SOBOL, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_PHILOX4X32X10, A Philox4x32-10 counter-based pseudorandom number generator.
        /// </summary>
        /// <param name="seed">A seed</param>
        [MethodImpl(Inline)]    
        public static VslStream gPhilox(uint seed)
            => stream(BRNG.VSL_BRNG_PHILOX4X32X10, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_WH, A set of 273 Wichmann-Hill combined multiplicative congruential generators.
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 272 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static VslStream gWh(uint seed, int index = 0)
            => stream(BRNG.VSL_BRNG_WH + index, seed);

        /// <summary>
        /// Creates a stream predicated on VSL_BRNG_MT2203, A set of 6024 Mersenne Twister pseudorandom number generators
        /// </summary>
        /// <param name="seed">A seed</param>
        /// <param name="index">A value between 0 and 6023 that identifies the desired generator</param>
        [MethodImpl(Inline)]    
        public static VslStream gMt2203(uint seed, int index = 0)
            => stream(BRNG.VSL_BRNG_MT2203 + index, seed);

        /// <summary>
        /// Generates a discrete uniform distribution confined to a specified range
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="range">The range of possible values</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformRangeSample<int> uniform(VslStream stream, Interval<int> range, Span<int> buffer)
        {
            VSL.viRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static UniformRangeSample<float> uniform(VslStream stream, Interval<float> range, Span<float> buffer)
        {
            VSL.vsRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static UniformRangeSample<double> uniform(VslStream stream, Interval<double> range, Span<double> buffer)
        {
            VSL.vdRngUniform(0,stream, buffer.Length, ref buffer[0], range.Left, range.Right).ThrowOnError();
            return stream.Brng().UniformRangeSampled(range,buffer);
        }

        [MethodImpl(Inline)]    
        public static Span<float> cauchy(VslStream stream, float a, float b, Span<float> buffer)
        {
            VSL.vsRngCauchy(0, stream, buffer.Length, ref buffer[0], a, b).ThrowOnError();
            return buffer;
        }

        [MethodImpl(Inline)]    
        public static Span<double> cauchy(VslStream stream, double a, double b, Span<double> buffer)
        {
            VSL.vdRngCauchy(0, stream, buffer.Length, ref buffer[0], a, b).ThrowOnError();
            return buffer;
        }

        /// <summary>
        /// Generates uniformly distributed bits in 32-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<uint> ubits(VslStream stream, Span<uint> buffer)
        {
            
            VSL.viRngUniformBits32(0,stream, buffer.Length, ref buffer[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// Generates uniformly distributed bits in 64-bit chunks.
        /// </summary>
        /// <param name="stream">The brng state stream</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static UniformBitsSample<ulong> ubits(VslStream stream, Span<ulong> buffer)
        {
            VSL.viRngUniformBits64(0,stream, buffer.Length, ref buffer[0]).ThrowOnError();
            return stream.Brng().UniformBitsSampled(buffer);
        }

        /// <summary>
        /// Samples a geometric distributions
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="p">The proability of a trial succeeding</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GeometricSample<int> geometric(VslStream stream, double p, Span<int> buffer)
        {
            VSL.viRngGeometric(0, stream, buffer.Length, ref buffer[0], p).ThrowOnError();
            return stream.Brng().GeometricSampled(p, buffer);
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
        public static Span<int> bernoulli(VslStream stream, double p, Span<int> buffer)
        {
            VSL.viRngBernoulli(0, stream, buffer.Length, ref buffer[0],p).ThrowOnError();
            return buffer;
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<float> chi2(VslStream stream, int freedom, Span<float> buffer)
        {
            VSL.vsRngChiSquare(0, stream, buffer.Length, ref buffer[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSampled(freedom,buffer);
        }

        [MethodImpl(Inline)]    
        public static ChiSquareSample<double> chi2(VslStream stream, int freedom, Span<double> buffer)
        {
            VSL.vdRngChiSquare(0, stream, buffer.Length, ref buffer[0], freedom).ThrowOnError();
            return stream.Brng().ChiSquareSampled(freedom,buffer);
        }

        /// <summary>
        /// Samples a single-precision Gaussian distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="mu">The mean of the disribution</param>
        /// <param name="sigma">The distribution's standard deviation</param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static GaussianSample<float> gaussian(VslStream stream, float mu, float sigma, Span<float> buffer)
        {
            VSL.vsRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer[0], mu, sigma).ThrowOnError();
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
        public static GaussianSample<double> gaussian(VslStream stream, double mu, double sigma, Span<double> buffer)
        {
            VSL.vdRngGaussian(VslGaussianMethod.BoxMuller1, stream, buffer.Length, ref buffer[0], mu, sigma).ThrowOnError();
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
        public static GammaSample<float> gamma(VslStream stream, float alpha, float dx, float beta, Span<float> buffer)
        {
            VSL.vsRngGamma(VslGammaMethod.GNorm, stream, buffer.Length, ref buffer[0], alpha, dx, beta).ThrowOnError();
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
        public static GammaSample<double> gamma(VslStream stream, double alpha, double dx, double beta, Span<double> buffer)
        {
            VSL.vdRngGamma(VslGammaMethod.GNorm, stream, buffer.Length, ref buffer[0], alpha, dx, beta).ThrowOnError();
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
        public static ExponentialSample<float> exp(VslStream stream, float dx, float beta, Span<float> buffer)
        {
            VSL.vsRngExponential(0, stream, buffer.Length, ref buffer[0], dx, beta).ThrowOnError();
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
        public static ExponentialSample<double> exp(VslStream stream, double dx, double beta, Span<double> buffer)
        {
            VSL.vdRngExponential(0, stream, buffer.Length, ref buffer[0], dx, beta).ThrowOnError();
            return stream.Brng().ExponentialSample(dx, beta, buffer);
        }

        /// <summary>
        /// Samples a poisson distribution
        /// </summary>
        /// <param name="stream">The state stream</param>
        /// <param name="alpha"></param>
        /// <param name="buffer">The reception buffer</param>
        [MethodImpl(Inline)]    
        public static PoissonSample<int> poisson(VslStream stream, double alpha, Span<int> buffer)
        {
            VSL.viRngPoisson(0, stream, buffer.Length, ref buffer[0], alpha).ThrowOnError();
            return stream.Brng().PoissonSample(alpha,  buffer);
        }
    }

}