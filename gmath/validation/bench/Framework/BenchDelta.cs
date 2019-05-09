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

    public class BenchDelta 
    {
        public static BenchDelta Calc(IBenchComparison comparison)
            => new BenchDelta(comparison);

        public BenchDelta(IBenchComparison Comparison)
        {
            this.Comparison = Comparison;
            this.Description = Comparison.Describe();
            Claim.eq(Comparison.LeftMeasure.OpCount, Comparison.RightMeasure.OpCount);
        }

        public IBenchComparison Comparison {get;}

        public AppMsg Description {get;}

        public string LeftTitle
            => Comparison.LeftTitle;

        public string RightTitle
            => Comparison.RightTitle;
        
        public long OpCount
            => Comparison.LeftMeasure.OpCount;

        public Duration LeftDuration
            => Comparison.LeftMeasure.WorkTime;

        public Duration RightDuration
            => Comparison.RightMeasure.WorkTime;

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

    public static class BenchComparisonX
    {
        public static BenchDelta CalcDelta(this IBenchComparison comparison)
            => BenchDelta.Calc(comparison);
    }
}