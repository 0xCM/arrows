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
    using System.Collections;

    public abstract class Distribution<S,T> : IDistribution<T>
        where T : struct
        where S : IDistributionSpec<T>

    {

        protected IRandomSource Random {get;}

        public S Spec {get;}

        protected Distribution(IRandomSource random, S Spec)
        {
            this.Random = random;
            this.Spec =Spec;
        }
        
        public abstract IEnumerable<T> Sample();

        public IEnumerator<T> GetEnumerator()
            => Sample().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}