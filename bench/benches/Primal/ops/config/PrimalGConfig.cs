//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public sealed class PrimalGConfig : PrimalConfig
    {
        public static new PrimalGConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new PrimalGConfig(metric, runs, cycles, samples);

        public PrimalGConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }
    }

}