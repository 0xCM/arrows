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


    public abstract class MetricConfig : IMetricConfig
    {

        public MetricConfig()
        {
            
        }
        
        public MetricConfig(MetricKind Metric, int Runs, int Cycles, int Samples)
        {
            this.Metric = Metric;
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = true;
        }
        
        public MetricKind Metric {get; set;}

        public int Runs {get; set;}
        
        public int Cycles {get; set;}

        public int Samples {get; set;}

        public bool DirectOps {get; set;}
    }



}