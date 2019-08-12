//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;

    public static class DistFactory
    {
        /// <summary>
        /// Constructs a Bernouli distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static BernoulliDist<T> Distribution<T>(this BernoulliSpec<T> spec, IRandomSource random)
            where T : struct
                => new BernoulliDist<T>(random, spec);

        /// <summary>
        /// Constructs a Binomial distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static BinomialDist<T> Distribution<T>(this BinomialSpec<T> spec, IRandomSource random)
            where T : struct
                => new BinomialDist<T>(random, spec);

        /// <summary>
        /// Constructs a Beta distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static BetaDist<T> Distribution<T>(this BetaSpec<T> spec, IRandomSource random)
            where T : struct
                => new BetaDist<T>(random, spec);

        /// <summary>
        /// Constructs a Gaussian (normal) distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static GaussianDist<T> Distribution<T>(this GaussianSpec<T> spec, IRandomSource random)
            where T : struct
                => new GaussianDist<T>(random, spec);

        /// <summary>
        /// Constructs a Gamma distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static GammaDist<T> Distribution<T>(this GammaSpec<T> spec, IRandomSource random)
            where T : struct
                => new GammaDist<T>(random, spec);

        /// <summary>
        /// Constructs a Poisson distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static PoissonDist<T> Distribution<T>(this PoissonSpec<T> spec, IRandomSource random)
            where T : struct
                => new PoissonDist<T>(random, spec);

        /// <summary>
        /// Constructs a Poisson distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static LaplaceDist<T> Distribution<T>(this LaplaceSpec<T> spec, IRandomSource random)
            where T : struct
                => new LaplaceDist<T>(random, spec);

        /// <summary>
        /// Counts the number of sample points that lie within a specified interval
        /// </summary>
        /// <param name="dist">The distribution to analyze</param>
        /// <param name="domain">The interval within which points will be counted</param>
        /// <param name="count">The number of sample points to use</param>
        /// <typeparam name="T">The distribution point type</typeparam>
        public static Ratio<double> SamplesWithin<T>(this IDistribution<T> dist, Interval<T> domain, int count)
            where T : struct
        {
            var src = dist.Sample().Take(count);
            var counter = 0;
            foreach(var sample in src)
                if(domain.Contains(sample))
                    counter++;
            return new Ratio<double>(counter, count);

        }    
    }

}