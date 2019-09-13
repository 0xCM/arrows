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
        public static BernoulliDist<T> Distribution<T>(this BernoulliSpec<T> spec, IPolyrand random)
            where T : unmanaged
                => new BernoulliDist<T>(random, spec);

        /// <summary>
        /// Constructs a Binomial distribution given a specification and random source
        /// </summary>
        /// <param name="spec">A specification that characterizes the distribution</param>
        /// <param name="random">A (uniform) random source</param>
        /// <typeparam name="T">The sample element type</typeparam>
        public static BinomialDist<T> Distribution<T>(this BinomialSpec<T> spec, IPolyrand random)
            where T : unmanaged
                => new BinomialDist<T>(random, spec);
    }

}