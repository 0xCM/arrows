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
    
    public interface IBenchSummary
    {
        int Cycles {get;}

        OpMetrics Measure {get;}

        AppMsg Description {get;}

    }
    
    public class BenchSummary<T> : IBenchSummary
    {
        public BenchSummary(T Title, int Cycles,  long OpCount,  Duration ExecTime)
        {
            this.Title = Title;
            this.Cycles = Cycles;
            this.OpCount = OpCount;
            this.ExecTime = ExecTime;
            this.Measure = OpMetrics.Define(OpCount, ExecTime);
            this.Description = BenchmarkMessages.BenchmarkEnd(Title, OpCount, ExecTime);
        }

        public BenchSummary(T Title, int Cycles,  OpMetrics Measure)
        {
            this.Title = Title;
            this.Cycles = Cycles;
            this.OpCount = Measure.OpCount;
            this.ExecTime = Measure.WorkTime;
            this.Measure = Measure;
            this.Description = BenchmarkMessages.BenchmarkEnd(Title, OpCount, ExecTime);
        }

        public int Cycles {get;}

        public OpMetrics Measure {get;}

        public long OpCount {get;}

        public Duration ExecTime {get;}

        public AppMsg Description {get;}

        public T Title {get;}

    }
    
    public class BenchSummary : BenchSummary<OpId>
    {
        public static readonly BenchSummary Zero = new BenchSummary(OpId.Zero, 0, 0, Duration.Zero);

        public static BenchSummary<T> Define<T>(T title, int Cycles, long OpCount, Duration Measured)
            => new BenchSummary<T>(title, Cycles, OpCount, Measured);

        public static BenchSummary<T> Define<T>(T title, int Cycles, OpMetrics Measure)
            => new BenchSummary<T>(title, Cycles, Measure);

        public static BenchSummary Define(OpId Operator, int Cycles, long OpCount, Duration Measured)
            => new BenchSummary(Operator, Cycles, OpCount, Measured);

        public BenchSummary(OpId Operator, int Cycles,  long OpCount,  Duration ExecTime)
            : base(Operator, Cycles, OpCount, ExecTime)
        {
            this.Operator = Operator;
        }

        public OpId Operator {get;}


        public override string ToString()
            => Description.ToString();
    }
}