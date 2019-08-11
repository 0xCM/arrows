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
    /// Characterizes a Poisson distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Poisson_distribution</remarks>
    public readonly struct PoissonSpec : IDistributionSpec
    {
        public static PoissonSpec Define(double p)
            => new PoissonSpec(p);
        
        public PoissonSpec(double lambda)
        {
            this.Lambda = lambda;
        }
        
        /// <summary>
        /// Specifies a value within the unit interval [0,1] that represents
        /// the probability of success
        /// </summary>
        [Symbol(Greek.lambda)]
        public readonly double Lambda;
    }
}