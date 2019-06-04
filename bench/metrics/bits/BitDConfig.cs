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


    public class BitDConfig : BitConfig
    {
        public static BitDConfig Default(MetricKind metric) 
            => BitDConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12);        

        public static BitDConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new BitDConfig(metric, runs, cycles, samples);

        public BitDConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }
                
    
    }



}