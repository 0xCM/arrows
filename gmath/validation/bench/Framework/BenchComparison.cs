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
        
    public interface IBenchComparison
    {
        string LeftTitle {get;}

        AppMsg LeftMsg {get;}
        
        OpMeasure LeftMeasure{get;}


        string RightTitle {get;}

        AppMsg RightMsg {get;}

        OpMeasure RightMeasure {get;}
    }

    public class BenchComparison<T> : IBenchComparison
    {
        public BenchComparison(BenchSummary<T> LeftBench, BenchSummary<T> RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;            
        }

        public BenchSummary<T> LeftBench {get;}

        public BenchSummary<T> RightBench {get;}    

        public string LeftTitle
            => $"{LeftBench.Title}";

        public AppMsg LeftMsg
            => LeftBench.Description;

        public OpMeasure LeftMeasure
            => LeftBench.Measure;

        public string RightTitle
            => $"{RightBench.Title}";

        public AppMsg RightMsg
            => RightBench.Description;

        public OpMeasure RightMeasure
            => RightBench.Measure;
    }

    public class BenchComparison : BenchComparison<OpId>
    {
        public static readonly BenchComparison Zero = new BenchComparison(BenchSummary.Zero, BenchSummary.Zero);
        
        public static BenchComparison Define(BenchSummary LeftBench, BenchSummary RightBench)
            => new BenchComparison(LeftBench,RightBench);

        public static BenchComparison<T> Define<T>(BenchSummary<T> LeftBench, BenchSummary<T> RightBench)
            => new BenchComparison<T>(LeftBench,RightBench);

        public BenchComparison(BenchSummary LeftBench, BenchSummary RightBench)
            : base(LeftBench, RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;
        }

        public new BenchSummary LeftBench {get;}

        public new BenchSummary RightBench {get;}    
    }
}