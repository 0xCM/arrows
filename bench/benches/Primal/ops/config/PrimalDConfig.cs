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


    public sealed class PrimalDConfig : PrimalConfig
    {

        public static PrimalDConfig Define(MetricConfig src)
            => new PrimalDConfig(src.Metric, src.Runs, src.Cycles, src.Samples);

        public static new PrimalDConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new PrimalDConfig(metric, runs, cycles, samples);

        public PrimalDConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }                
    }

}