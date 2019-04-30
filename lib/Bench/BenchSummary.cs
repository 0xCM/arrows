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

    public class BenchSummary
    {
        public BenchSummary(string Title, OpId Operator, long OpCount, Duration Measured, Duration Runtime)
        {
            this.Title = Title;
            this.Operator = Operator;
            this.OpCount = OpCount;
            this.Measured = Measured;
            this.Runtime = Runtime;
            this.Description = BenchmarkMessages.BenchmarkEnd(Title, Operator, OpCount, Measured);
        }
        public string Title {get;}

        public OpId Operator {get;}
        
        public long OpCount {get;}

        public Duration Measured {get;}

        public Duration Runtime {get;}

        public AppMsg Description {get;}

        public override string ToString()
            => Description.ToString();
    }

    public class BenchComparison
    {
        public static BenchComparison Define(BenchSummary LeftBench, BenchSummary RightBench)
            => new BenchComparison(LeftBench,RightBench);

        public BenchComparison(BenchSummary LeftBench, BenchSummary RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;
        }


        public BenchSummary LeftBench {get;}

        public BenchSummary RightBench {get;}

        public BenchDelta CalcDelta()
            => new BenchDelta(this);
    
    }

    public class BenchDelta 
    {
        public BenchDelta(BenchComparison Comparison)
        {
            this.Comparison = Comparison;
            Claim.eq(Comparison.LeftBench.OpCount, Comparison.RightBench.OpCount);
            Claim.eq(Comparison.LeftBench.Operator.Primitive, Comparison.RightBench.Operator.Primitive);
            Claim.eq(Comparison.LeftBench.Operator.Kind, Comparison.RightBench.Operator.Kind);
        }

        public BenchComparison Comparison {get;}

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
               
        
    }
}