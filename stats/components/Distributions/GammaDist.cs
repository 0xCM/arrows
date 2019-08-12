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
    public class GammaDist<T> : Distribution<GammaSpec<T>,T>
        where T : struct
    {    
        public GammaDist(IRandomSource random, GammaSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => Random.SampleGamma(Spec.Shape, Spec.Scale);
    }
}