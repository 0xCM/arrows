//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using MsInfer.Distributions;

    /// <summary>
    /// Exposes desired operations
    /// </summary>
    public static class MsApi
    {   

        public static IEnumerable<double> SampleGaussian(this IRandomSource random, double μ, double σ)
        {
            var dist = Gaussian.FromMeanAndVariance(μ, σ*σ);
            while(true)
                yield return dist.Sample();
        }

        public static IEnumerable<bool> SampleBernoulli(this IRandomSource random, double p)
        {
            var dist = new Bernoulli(p);
            while(true)
                yield return dist.Sample();

        }
        
    }

}