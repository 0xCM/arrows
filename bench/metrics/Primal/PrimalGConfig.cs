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


    public class PrimalGConfig : MetricConfig
    {
        public static PrimalGConfig Default(MetricKind metric) 
            => PrimalGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12);        

        public static PrimalGConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new PrimalGConfig(metric, runs, cycles, samples);

        public PrimalGConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }

        public PrimalDConfig ToDirect()
            => new PrimalDConfig(Metric, Runs, Cycles, Samples);

    }

}