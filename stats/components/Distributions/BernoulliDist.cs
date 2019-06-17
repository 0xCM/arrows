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


    /// <summary>
    /// Realizes a Bernoulli distribution
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BernoulliDist<T> : Distribution<BernoulliSpec,T>
        where T : struct
    {    
        public BernoulliDist(IRandomSource random, BernoulliSpec spec)
            : base(random, spec)
        {
        }

        public override IEnumerable<T> Sample()
        {
            while(true)
            {
                var success = Random.NextDouble() < Spec.p ? One : Zero;
                yield return success;
            }            
        }
            
    }

}