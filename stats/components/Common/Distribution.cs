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

    public abstract class Distribution<S,T> : IDistribution<S,T>
        where S : IDistributionSpec
        where T : struct
    {
        protected static readonly T Zero = gmath.zero<T>();

        protected static readonly T One = gmath.one<T>();

        protected IRandomSource Random {get;}

        public S Spec {get;}

        protected Distribution(IRandomSource random, S Spec)
        {
            this.Random = random;
            this.Spec =Spec;
        }
        
        public abstract IEnumerable<T> Sample();
    }
}