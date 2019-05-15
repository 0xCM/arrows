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

    public interface IBenchComparison
    {
        string LeftTitle {get;}

        AppMsg LeftMsg {get;}
        
        OpMetrics LeftMeasure{get;}

        string RightTitle {get;}

        AppMsg RightMsg {get;}

        OpMetrics RightMeasure {get;}

        double PerformanceRatio {get;}

        BenchComparisonRecord ToRecord();
    }

    public class BenchComparison<T> : IBenchComparison
    {
        public BenchComparison(BenchSummary<T> LeftBench, BenchSummary<T> RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;   
            var leftTicks = (double)LeftBench.Measure.WorkTime.Ticks;
            var rightTicks = (double)RightBench.Measure.WorkTime.Ticks;
            this.PerformanceRatio = Math.Round(leftTicks / rightTicks, 4);         
        }

        public BenchSummary<T> LeftBench {get;}

        public BenchSummary<T> RightBench {get;}    

        public string LeftTitle
            => $"{LeftBench.Title}";

        public AppMsg LeftMsg
            => LeftBench.Description;

        public OpMetrics LeftMeasure
            => LeftBench.Measure;

        public string RightTitle
            => $"{RightBench.Title}";

        public AppMsg RightMsg
            => RightBench.Description;

        public OpMetrics RightMeasure
            => RightBench.Measure;
    
        public double PerformanceRatio {get;}
        
        public BenchComparisonRecord ToRecord()
            => new BenchComparisonRecord
            (
                LeftTitle,
                RightTitle,
                LeftMeasure.OpCount,
                RightMeasure.OpCount,
                LeftMeasure.WorkTime,
                RightMeasure.WorkTime,
                PerformanceRatio
            );
    }


    public static class Record
    {
        public static IEnumerable<string> Delimited<T>(this IEnumerable<IRecord<T>> records, char delimiter  = ',')
            => records.Select(r => r.Delimited(delimiter));
    }


    public class BenchComparisonRecord : IRecord<BenchComparisonRecord>
    {
        public static IReadOnlyList<string> GetHeaders()
            => type<BenchComparisonRecord>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();

        public BenchComparisonRecord(
            string LeftOpUri, string RightOpUri, 
            long LeftOpCount, long RightOpCount,
            Duration LeftWorkTime, Duration RightWorkTime,
            double PerformanceRatio
            )
        {
            this.LeftOpUri = LeftOpUri;
            this.RightOpUri = RightOpUri;
            
            this.LeftOpCount = LeftOpCount;
            this.RightOpCount = RightOpCount;

            this.LeftWorkTime = LeftWorkTime;
            this.RightWorkTime = RightWorkTime;
            this.PerformanceRatio = PerformanceRatio;
        }

        public string LeftOpUri {get;}

        public string RightOpUri {get;}

        public long LeftOpCount {get;}

        public long RightOpCount {get;}
        
        public Duration LeftWorkTime {get;}

        public Duration RightWorkTime {get;}

        public double PerformanceRatio {get;}

        public string Delimited(char delimiter = ',')
            => string.Join(string.Empty, 
                $"{LeftOpUri.Trim()}{delimiter}".PadRight(50), 
                $"{RightOpUri.Trim()}{delimiter}".PadRight(50), 
                $"{LeftOpCount}{delimiter}".PadRight(12), 
                $"{RightOpCount}{delimiter}".PadRight(12), 
                $"{LeftWorkTime.Ms}{delimiter}".PadRight(8), 
                $"{RightWorkTime.Ms}{delimiter}".PadRight(8), 
                    PerformanceRatio);


        public override string ToString()
            => Delimited();

        public IReadOnlyList<string> Headers()
            => GetHeaders();
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