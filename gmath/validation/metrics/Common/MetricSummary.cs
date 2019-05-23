//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    public class MetricSummary : IMetricSummary
    {
        public static readonly MetricSummary Zero = new MetricSummary();

        public static MetricSummary<T> Define<T>(Metrics<T> metrics)        
            where T : struct
                => new MetricSummary<T>(metrics);

        public static MetricSummary Define(IMetrics metrics)
            => new MetricSummary(metrics);

        MetricSummary()
        {

        }

        public MetricSummary(IMetrics Metrics)
        {
            this.Metrics = Metrics;
            this.Description = BenchmarkMessages.BenchmarkEnd(Metrics);             
        }

        public IMetrics Metrics {get;}

        public AppMsg Description {get;}

        public OpId OpId 
            => Metrics.OpId;

        public long OpCount 
            => Metrics.OpCount;

        public Duration WorkTime 
            => Metrics.WorkTime;

        public override string ToString()
            => Description.ToString();
    }
}