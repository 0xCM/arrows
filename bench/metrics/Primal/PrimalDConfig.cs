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

    public class PrimalDConfig : MetricConfig
    {
        public static PrimalDConfig Default(MetricKind metric) 
            => PrimalDConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12);        

        public static PrimalDConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new PrimalDConfig(metric, runs, cycles, samples);

        public PrimalDConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }                
    }

}