//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;

    public interface ISampleDefaults
    {
        /// <summary>
        /// The default sample size
        /// </summary>
        int SampleSize {get;}

    }
    
    public interface ISampleDefaults<T> : ISampleDefaults
        where T : struct
    {
        /// <summary>
        /// The domain of potential values
        /// </summary>
        Interval<T> SampleDomain {get;}
    }

}