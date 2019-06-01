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

    public static class VecGX
    {
        public static VecGConfig Configure(this MetricKind metric, VecGConfig config = null)
            => config ?? VecGConfig.Default(metric);

    }
    

    public class VecGConfig : MetricConfig
    {
        public static VecGConfig Default(MetricKind metric) 
            => VecGConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12);        

        public static VecGConfig Define(MetricKind metric, int runs, int cycles, int samples)
            => new VecGConfig(metric, runs, cycles, samples);

        public VecGConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
            : base(Metric, Runs, Cycles, Samples)
        {
        
        }

        public PrimalDConfig ToPrimalD()
            => new PrimalDConfig(MetricKind.PrimalD, Runs, Cycles, Samples);


                
    }

}