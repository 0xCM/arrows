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
    
    public class BenchSummary : IBenchSummary
    {
        public static readonly BenchSummary Zero = new BenchSummary();

        public static BenchSummary<T> Define<T>(OpMetrics<T> metrics)        
            where T : struct
                => new BenchSummary<T>(metrics);

        public static BenchSummary Define(IOpMetrics metrics)
            => new BenchSummary(metrics);

        BenchSummary()
        {

        }

        public BenchSummary(IOpMetrics Metrics)
        {
            this.Metrics = Metrics;
            this.Description = BenchmarkMessages.BenchmarkEnd(Metrics);             
        }

        public IOpMetrics Metrics {get;}

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