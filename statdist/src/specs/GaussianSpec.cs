//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a Gaussian (normal) distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Normal_distribution</remarks>
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct GaussianSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static GaussianSpec<T> Define(T mu, T sigma)
            => new GaussianSpec<T>(mu,sigma);        

        [MethodImpl(Inline)]
        public static implicit operator (T mu, T sigma)(GaussianSpec<T> spec)
            => (spec.Mean, spec.StdDev);

        [MethodImpl(Inline)]
        public static implicit operator GaussianSpec<T>((T mu, T sigma) x )
            => Define(x.mu, x.sigma);

        [MethodImpl(Inline)]
        public GaussianSpec(T mean, T stddev)
        {
            this.Mean = mean;
            this.StdDev = stddev;
        }

        /// <summary>
        /// The mean of the distribtion that serves as the location parameter
        /// </summary>
        public readonly T Mean;

        /// <summary>
        /// The standard deviation
        /// </summary>
        public readonly T StdDev;

        public T Variance 
        {
            [MethodImpl(Inline)]
            get
            {
                var sig = convert<T,double>(StdDev);
                require(sig != 0);

                return convert<T>(sig*sig);
            }            
        }

        public T Precision 
        {
            [MethodImpl(Inline)]
            get
            {
                var sig = convert<T,double>(StdDev);
                require(sig != 0);

                var prec = MathUtil.recip(sig*sig);
                return convert<T>(prec);
            }
        }

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind Kind 
            => DistKind.Gaussian;

        [MethodImpl(Inline)]
        public GaussianSpec<float> ToFloat32()
            => new GaussianSpec<float>(convert<T,float>(Mean), convert<T,float>(StdDev));

        [MethodImpl(Inline)]
        public GaussianSpec<double> ToFloat64()
            => new GaussianSpec<double>(convert<T,double>(Mean), convert<T,double>(StdDev));

    }

}