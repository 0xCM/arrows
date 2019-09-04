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
        /// <param name="p">The probability of a given trial succeeding</param>
        public static BernoulliDist<T> Bernoulli<T>(this IPolyrand random, double p = 0.5)
            where T : unmanaged
                => new BernoulliSpec<T>(p).Distribution(random);
 
        
        public static IEnumerable<SeriesTerm<T>> Terms<T>(this TimeSeries<T> series)
            where T : struct
                => TimeSeries.Evolve(series);

        [MethodImpl(Inline)]
        public static SeriesTerm<T> NextTerm<T>(this TimeSeries<T> series)
            where T : struct
                => TimeSeries.NextTerm(series);
    }
}