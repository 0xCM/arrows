//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    public class MetricSummary<T> : IMetricSummary
        where T : struct
    {
        public MetricSummary(Metrics<T> Metrics)
        {
            this.Metrics = Metrics;
            this.OpId = Metrics.OpId;
            this.OpCount = Metrics.OpCount;
            this.WorkTime = Metrics.WorkTime;
            this.Description = MetricSummary.BenchmarkEnd(this.OpId, OpCount, WorkTime);
        }

        public IMetrics Metrics {get;}

        public long OpCount {get;}

        public Duration WorkTime {get;}

        public AppMsg Description {get;}

        public OpId OpId {get;}

    }


}