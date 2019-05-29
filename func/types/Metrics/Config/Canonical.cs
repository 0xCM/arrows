//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class MetricConfig
    {
        public static MetricConfig Default(MetricKind metric) 
            => MetricConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static MetricConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
            => new MetricConfig(metric, runs, cycles, samples, dops);

        public MetricConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps =true)
        {
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = DirectOps;
        }
        
        public MetricKind Metric {get;}

        public int Runs {get;}
        
        public int Cycles {get;}

        public int Samples {get;}

        public bool DirectOps {get;}
    }



}