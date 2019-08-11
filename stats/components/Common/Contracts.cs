//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;

    public interface IDistribution<T>
        where T : struct
    {
        IEnumerable<T> Sample();
    }

    public interface IDistribution<S,T> : IDistribution<T>
        where S : IDistributionSpec
        where T : struct
    {
        
    }
}