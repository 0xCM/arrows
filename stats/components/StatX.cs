//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class StatX
    {
        /// <summary>
        /// Produces a stream of random values conforming to a Bernoulli distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="spec">The distribution specification</param>
        public static IEnumerable<bool> BernoulliStream(this IRandomSource random, BernoulliSpec spec)
        {
            var dist = spec.Distribution<byte>(random);
            while(true)
            {
                foreach(var value in dist.Sample())
                    yield return (value == 1);
            }
        }

        /// <summary>
        /// Produces a stream of random values conforming to a Bernoulli distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="p">The probability of a given trial succeeding</param>
        public static IEnumerable<bool> BernoulliStream(this IRandomSource random, double p = 0.5)
            =>random.BernoulliStream(new BernoulliSpec(p));
 
        /// <summary>
        /// Produces a stream of random values conforming to a Binomial distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="spec">The distribution specification</param>
        public static IEnumerable<T> BinomialStream<T>(this IRandomSource random, BinomialSpec spec)
            where T : struct
        {            
            var dist = spec.Distribution<T>(random);
            while(true)
                foreach(var value in dist.Sample())
                    yield return value;
        } 

        /// <summary>
        /// Produces a stream of random values conforming to a Binomial distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The number of independent experiments</param>
        /// <param name="p">The probability of a given trial succeeding</param>
        public static IEnumerable<T> BinomialStream<T>(this IRandomSource random, int n, double p = 0.5)
            where T : struct
                => random.BinomialStream<T>(new BinomialSpec(n,p));

        /// <summary>
        /// Produces a stream of random values conforming to a Gaussian distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="spec">The distribution specification</param>
        public static IEnumerable<T> GaussianStream<T>(this IRandomSource random, GaussianSpec spec)
            where T : struct
        {            
            var dist = spec.Distribution<T>(random);
            while(true)
                foreach(var value in dist.Sample())
                    yield return value;
        } 

        /// <summary>
        /// Produces a stream of random values conforming to a Gaussian distribution
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="spec">The distribution specification</param>
        public static IEnumerable<T> GaussianStream<T>(this IRandomSource random, double mean, double deviation)
            where T : struct
            => random.GaussianStream<T>(new GaussianSpec(mean, deviation));
        public static IEnumerable<SeriesTerm<T>> Terms<T>(this TimeSeries<T> series)
            where T : struct
                => TimeSeries.Evolve(series);

        [MethodImpl(Inline)]
        public static SeriesTerm<T> NextTerm<T>(this TimeSeries<T> series)
            where T : struct
                => TimeSeries.NextTerm(series);
    }
}