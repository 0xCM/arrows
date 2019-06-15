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


    public static class stats
    {
        public static Ratio<T> ratio<T>(T value, T max)
            where T : struct 
                => new Ratio<T>(value,max);

        public static Bin<T> bin<T>(Interval<T> domain, int count = 0)
            where T : struct 
                => Bin.Define(domain,count);

        public static Histogram<T> histogram<T>(Interval<T> domain, T binWidth)
            where T : struct 
                => Histogram.Define(domain,binWidth);
    
        public static IDistribution<T> bernoulli<T>(IRandomSource random, double alpha)
            where T : struct 
                => BernoulliSpec.Define(alpha).Distribution<T>(random);

        public static IDistribution<T> gaussian<T>(IRandomSource random, double mean, double stddev)
            where T : struct 
                => new GaussianSpec(mean, stddev).Distribution<T>(random);

    }

}
