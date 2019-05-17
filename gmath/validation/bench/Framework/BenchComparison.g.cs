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


    public class BenchComparison<T> : IBenchComparison
        where T : struct 
    {
        public BenchComparison(BenchSummary<T> LeftBench, BenchSummary<T> RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;
            if(LeftBench.OpCount != RightBench.OpCount)   
                throw new Exception("OpCount mismatch");

            var leftTicks = (double)LeftBench.Metrics.WorkTime.Ticks;
            var rightTicks = (double)RightBench.Metrics.WorkTime.Ticks;
            this.Ratio = Math.Round(leftTicks / rightTicks, 4);         
        }

        public BenchSummary<T> LeftBench {get;}

        public BenchSummary<T> RightBench {get;}    

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