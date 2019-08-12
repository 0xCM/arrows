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

        [MethodImpl(Inline)]    
        internal static BRNG ToBrng(this RngKind src)
            => (BRNG)src;

        [MethodImpl(Inline)]    
        internal static RngKind ToRngKind(this BRNG src)
            => (RngKind)src;

        /// <summary>
        /// Defines a sample taken from a Gaussian distribution
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="mu">The distribution mean</param>
        /// <param name="sigma">The distribution standard deviation</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static GaussianSample<T> GaussianSample<T>(this BRNG rng, T mu, T sigma, Memory<T> data)
            where T : struct
                => new GaussianSample<T>(rng.ToRngKind(), new GaussianSpec<T>(mu, sigma), data);

        /// <summary>
        /// Defines a uniform bits sample
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static UniformBitsSample<T> UniformBitsSampled<T>(this BRNG rng, Memory<T> data)
            where T : struct
                => new UniformBitsSample<T>(rng.ToRngKind(),data);

        [MethodImpl(Inline)]    
        internal static UniformSample<T> UniformRangeSampled<T>(this BRNG rng, Interval<T> range, Memory<T> data)
            where T : struct
                => new UniformSample<T>(rng.ToRngKind(), range, data);

        [MethodImpl(Inline)]    
        internal static GeometricSample<T> GeometricSample<T>(this BRNG rng, double p, Memory<T> data)
            where T : struct
                => new GeometricSample<T>(rng.ToRngKind(), p, data);

        [MethodImpl(Inline)]    
        internal static BernoulliSample<T> BernoulliSample<T>(this BRNG rng, double p, Memory<T> data)
            where T : struct
                => new BernoulliSample<T>(rng.ToRngKind(), p, data);

        [MethodImpl(Inline)]    
        internal static ChiSquareSample<T> ChiSquareSample<T>(this BRNG rng, int freedom, Memory<T> data)
            where T : struct
                => new ChiSquareSample<T>(rng.ToRngKind(), freedom, data);

        [MethodImpl(Inline)]    
        internal static GammaSample<T> GammaSample<T>(this BRNG rng, T alpha, T dx, T beta, Memory<T> data)
            where T : struct
                => new GammaSample<T>(rng.ToRngKind(), alpha, dx, beta, data);

        [MethodImpl(Inline)]    
        internal static ExponentialSample<T> ExponentialSample<T>(this BRNG rng, T dx, T beta, Memory<T> data)
            where T : struct
                => new ExponentialSample<T>(rng.ToRngKind(), dx, beta, data);

        [MethodImpl(Inline)]    
        internal static PoissonSample<T> PoissonSample<T>(this BRNG rng, double lambda, Memory<T> data)
            where T : struct
                => new PoissonSample<T>(rng.ToRngKind(), lambda, data);


        /// <summary>
        /// Defines a sample taken from a Laplace distribution
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="loc">The distribution mean</param>
        /// <param name="scale">The distribution scale</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static LaplaceSample<T> LaplaceSample<T>(this BRNG rng, T loc, T scale, Memory<T> data)
            where T : struct
                => new LaplaceSample<T>(rng.ToRngKind(), new LaplaceSpec<T>(loc,scale), data);


        [MethodImpl(Inline)]    
        internal static CauchySample<T> CauchySample<T>(this BRNG rng, T loc, T scale, Memory<T> data)
            where T : struct
                => new CauchySample<T>(rng.ToRngKind(), new CauchySpec<T>(loc,scale), data);


        [MethodImpl(Inline)]    
        internal static CauchySample<T> CauchySample<T>(this BRNG rng, CauchySpec<T> spec, Memory<T> data)
            where T : struct
                => new CauchySample<T>(rng.ToRngKind(), spec, data);


    }

}