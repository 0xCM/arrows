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
        where T : unmanaged
        where S : IDistributionSpec<T>

    {

        protected IPolyrand Polyrand {get;}

        public S Spec {get;}

        protected Distribution(IPolyrand random, S Spec)
        {
            this.Polyrand = random;
            this.Spec =Spec;
        }
        
        public abstract IEnumerable<T> Sample();

        public IEnumerator<T> GetEnumerator()
            => Sample().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}