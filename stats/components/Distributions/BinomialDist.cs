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
    /// Realizes a Binomial distribution
    /// </summary>
    /// <typeparam name="T">The primal integral type</typeparam>
    public class BinomialDist<T> : Distribution<BinomialSpec<T>,T>
        where T : struct
    {    
        public BinomialDist(IPolyrand random, BinomialSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => Polyrand.SampleBinomial(Spec.Trials, Spec.Success);
    }
     
}