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


    public class BenchSummary<T> : IBenchSummary
        where T : struct
    {
        public BenchSummary(OpMetrics<T> Metrics)
        {
            this.Metrics = Metrics;
            this.OpId = Metrics.OpId;
            this.OpCount = Metrics.OpCount;
            this.WorkTime = Metrics.WorkTime;
            this.Description = BenchmarkMessages.BenchmarkEnd(this.OpId, OpCount, WorkTime);
        }

        public IOpMetrics Metrics {get;}

        public long OpCount {get;}

        public Duration WorkTime {get;}

        public AppMsg Description {get;}

        public OpId<T> OpId {get;}

    }


}