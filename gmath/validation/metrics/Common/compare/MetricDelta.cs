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
            this.Description = Comparison.Describe();
            Claim.eq(Comparison.LeftMetrics.OpCount, Comparison.RightMetrics.OpCount);
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
    } 
}