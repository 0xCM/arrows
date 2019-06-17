//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
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

}