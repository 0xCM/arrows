//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;
    using static As;


    /// <summary>
    /// Realizes a Bernoulli distribution
    /// </summary>
    /// <typeparam name="T">The sample element type</typeparam>
    public class BernoulliDist<T> : Distribution<BernoulliSpec<T>,T>
        where T : unmanaged
    {    
        static readonly T Zero = gmath.zero<T>();

        static readonly T One = gmath.one<T>();

        public BernoulliDist(IPolyrand random, BernoulliSpec<T> spec)
            : base(random, spec)
        {
        }

        public override IEnumerable<T> Sample()
        {
            while(true)
            {
                var success = math.lt(Polyrand.Next<double>(), Spec.Success) ? One : Zero;
                yield return success;
            }            
        }
            
    }

}