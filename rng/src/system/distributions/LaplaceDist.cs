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
    /// Realizes a Laplace distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LaplaceDist<T> : Distribution<LaplaceSpec<T>,T>
        where T : unmanaged
    {    
        public LaplaceDist(IPolyrand random, LaplaceSpec<T> spec)
            : base(random, spec)
        {

        }

        public override IEnumerable<T> Sample()
            => Polyrand.SampleLaplace(Spec.Location, Spec.Scale);
    }
}