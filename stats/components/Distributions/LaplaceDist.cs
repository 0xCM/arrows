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
    public class LaplaceDist<T> : Distribution<LaplaceSpec,T>
        where T : struct
    {    
        public LaplaceDist(IRandomSource random, LaplaceSpec spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => from s in Random.SampleLaplace(Spec.Mean, Spec.Scale)
                select convert<double,T>(s);            
    }
}