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

    public static partial class mklx
    {
        [MethodImpl(Inline)]    
        internal static IntPtr Handle(this IMklTask src)
            => (src as MklTask);

        /// <summary>
        /// Defines a sample taken from a Gaussian distribution
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="mu">The distribution mean</param>
        /// <param name="sigma">The distribution standard deviation</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static GaussianSample<T> GaussianSample<T>(this BRNG rng, double mu, double sigma, Memory<T> data)
            where T : struct
                => new GaussianSample<T>(rng, mu, sigma, data);

        /// <summary>
        /// Defines a uniform bits sample
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static UniformBitsSample<T> UniformBitsSampled<T>(this BRNG rng, T[] data)
            where T : struct
                => new UniformBitsSample<T>(rng,data);

        [MethodImpl(Inline)]    
        internal static UniformRangeSample<T> UniformRangeSampled<T>(this BRNG rng, Interval<T> range, Memory<T> data)
            where T : struct
                => new UniformRangeSample<T>(rng, range, data);

        [MethodImpl(Inline)]    
        internal static GeometricSample<T> GeometricSampled<T>(this BRNG rng, double p, Span<T> data)
            where T : struct
                => new GeometricSample<T>(rng, p, data);

        [MethodImpl(Inline)]    
        internal static ChiSquareSample<T> ChiSquareSampled<T>(this BRNG rng, int freedom, Span<T> data)
            where T : struct
                => new ChiSquareSample<T>(rng, freedom, data);

        [MethodImpl(Inline)]    
        internal static GammaSample<T> GammaSample<T>(this BRNG rng, T alpha, T dx, T beta, Span<T> data)
            where T : struct
                => new GammaSample<T>(rng, alpha, dx, beta, data);

        [MethodImpl(Inline)]    
        internal static ExponentialSample<T> ExponentialSample<T>(this BRNG rng, T dx, T beta, Span<T> data)
            where T : struct
                => new ExponentialSample<T>(rng, dx, beta, data);

        [MethodImpl(Inline)]    
        internal static PoissonSample<T> PoissonSample<T>(this BRNG rng, double lambda, Span<T> data)
            where T : struct
                => new PoissonSample<T>(rng, lambda, data);


        /// <summary>
        /// Defines a sample taken from a Laplace distribution
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="mean">The distribution mean</param>
        /// <param name="beta">The distribution scale</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static LaplaceSample<T> LaplaceSample<T>(this BRNG rng, T mean, T beta, Memory<T> data)
            where T : struct
                => new LaplaceSample<T>(rng, mean, beta, data);


        [MethodImpl(Inline)]    
        internal static CauchySample<T> CauchySample<T>(this BRNG rng, T mean, T beta, Memory<T> data)
            where T : struct
                => new CauchySample<T>(rng, mean, beta, data);

    }

}