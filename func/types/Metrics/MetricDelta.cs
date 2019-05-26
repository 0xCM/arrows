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

    public class MetricDelta 
    {
        public static MetricDelta Calc(IMetricComparison comparison)
            => new MetricDelta(comparison);

        public MetricDelta(IMetricComparison Comparison)
        {
            this.Comparison = Comparison;
            this.Description = Describe(Comparison);
            if(Comparison.LeftMetrics.OpCount != Comparison.RightMetrics.OpCount)
                throw new Exception("Count mismatch");
        }

        public IMetricComparison Comparison {get;}

        public AppMsg Description {get;}

        public string LeftTitle
            => Comparison.LeftTitle;

        public string RightTitle
            => Comparison.RightTitle;
        
        public long OpCount
            => Comparison.LeftMetrics.OpCount;

        public Duration LeftDuration
            => Comparison.LeftMetrics.WorkTime;

        public Duration RightDuration
            => Comparison.RightMetrics.WorkTime;

        public Duration TimingDelta
            => LeftDuration - RightDuration;

        public bool LeftWins
            => LeftDuration < RightDuration;

        public bool RightWins
            => RightDuration < LeftDuration;

        public bool IsTie
            => LeftDuration == RightDuration;

        public string Winner
            => LeftWins ? LeftTitle :
               RightWins ? RightTitle :
               "tie";
 
       static AppMsg Describe(IMetricComparison comparison)
       {
            var title = $"{comparison.LeftTitle} / {comparison.RightTitle}";
            var delta = comparison.LeftMetrics.WorkTime - comparison.RightMetrics.WorkTime;
            var width = Math.Abs(delta.Ms);
            var leftDuration = comparison.LeftMetrics.WorkTime;
            var rightDuration = comparison.RightMetrics.WorkTime;
            var ratio = Math.Round((double)leftDuration.Ticks / (double)rightDuration.Ticks, 4);
            var description = append(
                $"{title}", 
                $" | Left Time  = {leftDuration.Ms} ms",
                $" | Right Time = {rightDuration.Ms} ms",
                $" | Difference = {delta.Ms} ms",
                $" | Performance Ratio = {ratio}"
                );
            return AppMsg.Define(description,  SeverityLevel.Perform);
        }

    } 
}