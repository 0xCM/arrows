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

    public static class Distributions
    {
        public static IDistribtion<T> Bernoulli<T>(double alpha)   
            where T : struct
                => new BernoulliDist<T>(new BernoulliSpec(alpha));
    }


}