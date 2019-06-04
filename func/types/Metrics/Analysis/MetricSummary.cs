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
    using static zfunc;
    
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
            this.Description = BenchmarkEnd(Metrics);             
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

        public MetricSummaryRecord ToRecord()
            => new MetricSummaryRecord(OpId, OpCount, WorkTime);
        

        static string Pipe = $" | ";
        
        static string Eq = $" = ";

        internal static AppMsg BenchmarkEnd(OpId opid,  long totalOpCount, Duration totalDuration)
            => AppMsg.Define(concat(
                    $"{opid} summary".PadRight(28), 
                     Pipe, "Total Op Count", Eq, $"{totalOpCount}".PadRight(12),
                     Pipe, "Total Duration", Eq, $"{totalDuration}"), 
                        SeverityLevel.HiliteCL);

        static AppMsg BenchmarkEnd(IMetrics metrics)
            => BenchmarkEnd(metrics.OpId, metrics.OpCount, metrics.WorkTime);
    }
}