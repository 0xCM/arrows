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
    /// <typeparam name="T"></typeparam>
    public class BinomialDist<T> : Distribution<BinomialSpec,T>
        where T : struct
    {    
        public BinomialDist(IRandomSource random, BinomialSpec spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => from s in Random.SampleBinomial(Spec.Trials, Spec.Success)
                select convert<int,T>(s);            
    }
}