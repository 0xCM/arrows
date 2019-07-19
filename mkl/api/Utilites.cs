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

    public static class mklx
    {
        /// <summary>
        /// Gets the brng identifier associated with a stream
        /// </summary>
        /// <param name="stream">The source stream</param>
        [MethodImpl(Inline)]    
        internal static BRNG Brng(this VslStream stream)
            => mkl.brng(stream);

        /// <summary>
        /// Defines a sample taken from a Gaussian distribution
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="mu">The distribution mean</param>
        /// <param name="sigma">The distribution standard deviation</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static GaussianSample<T> GaussianSample<T>(this BRNG rng, double mu, double sigma, Span<T> data)
            where T : struct
                => new GaussianSample<T>(rng, mu, sigma, data);

        /// <summary>
        /// Defines a uniform bits sample
        /// </summary>
        /// <param name="rng">The generator in use</param>
        /// <param name="data">The sampled data</param>
        /// <typeparam name="T">The primal type of the sample data</typeparam>
        [MethodImpl(Inline)]    
        internal static UniformBitsSample<T> UniformBitsSampled<T>(this BRNG rng, Span<T> data)
            where T : struct
                => new UniformBitsSample<T>(rng,data);

        [MethodImpl(Inline)]    
        internal static UniformRangeSample<T> UniformRangeSampled<T>(this BRNG rng, Interval<T> range, Span<T> data)
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
        internal static IntPtr Handle(this IMklTask src)
            => (src as MklTask);
        

    }


}