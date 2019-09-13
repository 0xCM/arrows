//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using static zfunc;

    public interface IDistributionSpec
    {
        DistKind Kind {get;}
        
    }

    /// <summary>
    /// Characterizes a distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    public interface IDistributionSpec<T> : IDistributionSpec
        where T : unmanaged
    {

        
    }

}