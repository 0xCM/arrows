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
    /// Realizes a Poisson distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PoissonDist<T> : Distribution<PoissonSpec<T>,T>
        where T : struct
    {    
        public PoissonDist(IRandomSource random, PoissonSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => Random.SamplePoisson(Spec.Success);
    }
}