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

    public interface IDistributionSpec
    {
        
    }

    public interface IDistribtion<T>
        where T : struct
    {
        IEnumerable<T> Sample(IRandomSource random);
    }

    public interface IDistribtion<S,T> : IDistribtion<T>
        where S : IDistributionSpec
        where T : struct
    {
        
    }

    public abstract class Distribution<S,T> : IDistribtion<S,T>
        where S : IDistributionSpec
        where T : struct
    {
        protected static readonly T Zero = gmath.zero<T>();

        protected static readonly T One = gmath.one<T>();

        public abstract IEnumerable<T> Sample(IRandomSource random);
    }


}