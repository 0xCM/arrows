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

    /// <summary>
    /// Characterizes a bernouli distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Bernoulli_distribution</remarks>
    public class BernoulliSpec : IDistributionSpec
    {
        public static BernoulliSpec Define(double p)
            => new BernoulliSpec(p);
        
        public BernoulliSpec(double p)
        {
            this.p = p;
        }
        
        /// <summary>
        /// Specifies a value within the unit interval [0,1] that represents
        /// the probability of success
        /// </summary>
        [Symbol(AsciLower.p)]
        public double p {get;}
    }

    /// <summary>
    /// Realizes a Bernoulli distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BernoulliDist<T> : Distribution<BernoulliSpec,T>
        where T : struct
    {    
        public BernoulliDist(IRandomSource random, BernoulliSpec spec)
            : base(random)
        {
            this.Spec = spec;
        }

        public BernoulliSpec Spec {get;}

        public override IEnumerable<T> Sample()
        {
            while(true)
            {
                var success = Random.NextDouble() < Spec.p ? One : Zero;
                yield return success;
            }            
        }
            
    }
}