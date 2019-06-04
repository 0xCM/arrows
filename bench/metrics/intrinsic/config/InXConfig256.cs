//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public abstract class InXConfig256 : InXConfig
    {

        public InXConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,32)
        {
        
        }
    }



}