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

    using static zfunc;
    using static mfunc;

   
    public class BenchComparison  : IBenchComparison
    {
        public static readonly BenchComparison Zero = new BenchComparison(BenchSummary.Zero, BenchSummary.Zero);
        
        public static BenchComparison Define(BenchSummary LeftBench, BenchSummary RightBench)
            => new BenchComparison(LeftBench,RightBench);

        public static BenchComparison<T> Define<T>(BenchSummary<T> LeftBench, BenchSummary<T> RightBench)
            where T : struct
            => new BenchComparison<T>(LeftBench,RightBench);

        public BenchComparison(BenchSummary LeftBench, BenchSummary RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;
            this.Ratio = LeftBench.WorkTime / RightBench.WorkTime;
        }

        public BenchSummary LeftBench {get;}

        public BenchSummary RightBench {get;}    

        public string LeftTitle
            => $"{LeftBench.OpId}";

        public AppMsg LeftMsg
            => LeftBench.Description;

        public IOpMetrics LeftMetrics
            => LeftBench.Metrics;

        public string RightTitle
            => $"{RightBench.OpId}";

        public AppMsg RightMsg
            => RightBench.Description;

        public IOpMetrics RightMetrics
            => RightBench.Metrics;
    
        public double Ratio {get;}
        
        public BenchComparisonRecord ToRecord()
            => new BenchComparisonRecord
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