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
        int SampleSize {get;}

    }
    
    public interface ISampleDefaults<T> : ISampleDefaults
        where T : struct
    {
        Interval<T> SampleDomain {get;}
    }

}