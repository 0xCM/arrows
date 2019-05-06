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

    using static zcore;
    using static zfunc;


    public class BenchDelta 
    {
        public static BenchDelta Calc(BenchComparison comparison)
            => new BenchDelta(comparison);

        public BenchDelta(BenchComparison Comparison)
        {
            this.Comparison = Comparison;
            this.Description = Describe(Comparison);
            Claim.eq(Comparison.LeftBench.OpCount, Comparison.RightBench.OpCount);
            Claim.eq(Comparison.LeftBench.Operator.OperandKind, Comparison.RightBench.Operator.OperandKind);
            Claim.eq(Comparison.LeftBench.Operator.OpKind, Comparison.RightBench.Operator.OpKind);
        }

        public BenchComparison Comparison {get;}

        public AppMsg Description {get;}

        public string LeftTitle
            => Comparison.LeftBench.Title;

        public string RightTitle
            => Comparison.RightBench.Title;

        public string DeltaTitle
            => $"{LeftTitle} vs {RightTitle}";

        public long OpCount
            => Comparison.LeftBench.OpCount;

        public OpId OpId
            => Comparison.LeftBench.Operator;

        public Duration LeftDuration
            => Comparison.LeftBench.ExecTime;

        public Duration RightDuration
            => Comparison.RightBench.ExecTime;

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

        static string deltaTitle(BenchComparison c)               
            => $"{c.LeftBench.Title} vs {c.RightBench.Title}";

        static Duration deltaTiming(BenchComparison c)               
            => c.LeftBench.ExecTime - c.RightBench.ExecTime;


        static AppMsg Describe(BenchComparison comparison)
        {
            var title = deltaTitle(comparison);
            var timing = deltaTiming(comparison);
            var width = Math.Abs(timing.Ms);
            var leftDuration = comparison.LeftBench.ExecTime;
            var rightDuration = comparison.RightBench.ExecTime;
            var ratio = Math.Round((double)leftDuration.Ticks / (double)rightDuration.Ticks, 4);
            var opid = comparison.LeftBench.Operator;
            var description = append(
                $"{title} {opid}", 
                $" | Left Time  = {leftDuration.Ms} ms",
                $" | Right Time = {rightDuration.Ms} ms",
                $" | Difference = {timing.Ms} ms",
                $" | Performance Ratio = {ratio}"
                );
            return AppMsg.Define(description,  SeverityLevel.Perform);
        }
    }

    public static class BenchComparisonX
    {
        public static BenchDelta CalcDelta(this BenchComparison comparison)
            => BenchDelta.Calc(comparison);
    }
}