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


    public class BenchDelta 
    {
        public BenchDelta(BenchComparison Comparison)
        {
            this.Comparison = Comparison;
            this.Description = Describe(Comparison);
            Claim.eq(Comparison.LeftBench.OpCount, Comparison.RightBench.OpCount);
            Claim.eq(Comparison.LeftBench.Operator.Primitive, Comparison.RightBench.Operator.Primitive);
            Claim.eq(Comparison.LeftBench.Operator.Kind, Comparison.RightBench.Operator.Kind);
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
            => Comparison.LeftBench.Measured;

        public Duration RightDuration
            => Comparison.RightBench.Measured;

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
               

        static AppMsg Describe(BenchComparison comparison)
        {
            var delta = comparison.CalcDelta();            
            var width = Math.Abs(delta.TimingDelta.Ms);
            var percent = Math.Round((width / ((double) Math.Min(delta.LeftDuration.Ms, delta.RightDuration.Ms)))* 100.0,4) ;
            var description = append(
                $"{delta.DeltaTitle} {delta.OpId}", 
                $" | Left Time  = {delta.LeftDuration.Ms} ms",
                $" | Right Time = {delta.RightDuration.Ms} ms",
                $" | Difference = {delta.TimingDelta.Ms} ms",
                $" | Winner = {delta.Winner} by {width} ms = {percent} %"
                );
            return AppMsg.Define(description,  delta.LeftWins ? SeverityLevel.Warning : SeverityLevel.Info);            
        }

    }


}