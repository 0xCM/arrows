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
    
    using static InXGMetrics256;

    abstract class InXMetricContext : IMetricConfig
    {
        public IRandomizer Random {get;}

        protected InXMetricContext(IRandomizer random)
        {
            this.Random = Random(random);
        }

        protected abstract InXConfig UntypedConfig {get;}

        public MetricKind Metric 
            => UntypedConfig.Metric;
        
        public int Blocks 
            => UntypedConfig.Blocks;
        
        public int Runs
            => UntypedConfig.Runs;

        public int Cycles
            => UntypedConfig.Cycles;

        public int Samples
            => UntypedConfig.Samples;


    }
    
    class InXMetricContext<T> : InXMetricContext
        where T : InXConfig
    {

        public InXMetricContext(T Config, IRandomizer random = null)
            : base(random)
        {
            this.Config = Config;      
        }
        
        public T Config {get;}

        protected override InXConfig UntypedConfig
            => Config;

    }

}