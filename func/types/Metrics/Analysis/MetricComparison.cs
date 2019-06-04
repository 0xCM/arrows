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

   
    public class MetricComparison  : IMetricComparison
    {
        public static readonly MetricComparison Zero = new MetricComparison(MetricSummary.Zero, MetricSummary.Zero);
        
        public static MetricComparison Define(MetricSummary LeftBench, MetricSummary RightBench)
            => new MetricComparison(LeftBench,RightBench);

        public static MetricComparison<T> Define<T>(MetricSummary<T> LeftBench, MetricSummary<T> RightBench)
            where T : struct
            => new MetricComparison<T>(LeftBench,RightBench);

        public MetricComparison(MetricSummary LeftSummary, MetricSummary RightSummary)
        {
            this.LeftSummary = LeftSummary;
            this.RightSummary = RightSummary;
            this.Ratio = LeftSummary.WorkTime / RightSummary.WorkTime;
        }

        public MetricSummary LeftSummary {get;}

        public MetricSummary RightSummary {get;}    

        public string LeftTitle
            => $"{LeftSummary.OpId}";

        public AppMsg LeftMsg
            => LeftSummary.Description;

        public IMetrics LeftMetrics
            => LeftSummary.Metrics;

        public string RightTitle
            => $"{RightSummary.OpId}";

        public AppMsg RightMsg
            => RightSummary.Description;

        public IMetrics RightMetrics
            => RightSummary.Metrics;
    
        public double Ratio {get;}
        
        public MetricComparisonRecord ToRecord()
            => new MetricComparisonRecord
            (
                LeftTitle,
                RightTitle,
                LeftMetrics.OpCount,
                LeftMetrics.WorkTime,
                RightMetrics.WorkTime,
                Ratio
            );


    }
}