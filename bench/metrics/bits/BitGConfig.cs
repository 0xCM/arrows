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



    public class BitGConfig : MetricConfig
    {
        public static BitGConfig Default(MetricKind metric) 
            => BitGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12);        

        public static BitGConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new BitGConfig(metric, runs, cycles, samples);

        public BitGConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }

        public BitDConfig ToDirect()
            => new BitDConfig(Metric, Runs, Cycles, Samples);
                
    }

}