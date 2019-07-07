//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Characterizes a beta distribution
    /// </summary>
    public readonly struct BetaSpec : IDistributionSpec
    {
        public static BetaSpec Define(double alpha, double beta)
            => new BetaSpec(alpha,beta);        
        public BetaSpec(double alpha, double beta)
        {
            this.Alpha = alpha;
            this.Beta = beta;
        }
        
        [Symbol(Greek.alpha)]
        public readonly double Alpha;

        [Symbol(Greek.beta)]
        public readonly double Beta;
    }
}