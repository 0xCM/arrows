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
    /// Realizes a Beta distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BetaDist<T> : Distribution<BetaSpec,T>
        where T : struct
    {    
        public BetaDist(IRandomSource random, BetaSpec spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => from s in Random.SampleBeta(Spec.Alpha, Spec.Beta)
                select convert<double,T>(s);            
    }
}