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


   public class BitDConfig : MetricConfig
    {
        public static BitDConfig Default(MetricKind metric) 
            => BitDConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static BitDConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new BitDConfig(metric, runs, cycles, samples, dops);

        public BitDConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps = true)
            : base(Metric, Runs, Cycles, Samples, DirectOps)
        {
        
        }
                
    }

    public static class BitConfigX
    {
        public static BitDConfig Configure(this MetricKind metric, BitDConfig config = null)
            => config ?? BitDConfig.Default(metric);

        public static BitGConfig Configure(this MetricKind metric, BitGConfig config = null)
            => config ?? BitGConfig.Default(metric);

    }

    public class BitGConfig : MetricConfig
    {
        public static BitGConfig Default(MetricKind metric) 
            => BitGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static BitGConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new BitGConfig(metric, runs, cycles, samples, dops);

        public BitGConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps = true)
            : base(Metric, Runs, Cycles, Samples, DirectOps)
        {
        
        }

        public BitDConfig ToDirect()
            => new BitDConfig(Metric, Runs, Cycles, Samples, DirectOps);
                
    }

}