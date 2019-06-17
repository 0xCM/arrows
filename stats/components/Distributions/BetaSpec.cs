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

    public class BetaSpec : IDistributionSpec
    {
        public static BetaSpec Define(double alpha, double beta)
            => new BetaSpec(alpha,beta);
        
        public BetaSpec(double alpha, double beta)
        {
            this.Alpha = alpha;
            this.Beta = beta;
        }
        
        [Symbol(Greek.alpha)]
        public double Alpha {get;}

        [Symbol(Greek.beta)]
        public double Beta {get;}
    }
}