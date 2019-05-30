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

    public interface IMetricConfig
    {
        MetricKind Metric {get;}

        int Runs {get;}
        
        int Cycles {get;}

        int Samples {get;}
        
    }

    public abstract class MetricConfig : IMetricConfig
    {
        // public static MetricConfig Default(MetricKind metric) 
        //     => MetricConfig.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        // public static MetricConfig Define(MetricKind metric, int runs, int cycles, int samples, bool dops)
        //     => new MetricConfig(metric, runs, cycles, samples, dops);

        public MetricConfig()
        {
            
        }
        
        public MetricConfig(MetricKind Metric, int Runs, int Cycles, int Samples, bool DirectOps =true)
        {
            this.Metric = Metric;
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = DirectOps;
        }
        
        public MetricKind Metric {get; set;}

        public int Runs {get; set;}
        
        public int Cycles {get; set;}

        public int Samples {get; set;}

        public bool DirectOps {get; set;}
    }



}