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
    
    public class BenchSummary
    {
        public static readonly BenchSummary Zero = new BenchSummary(OpId.Zero, 0, 0, Duration.Zero);
        
        public static BenchSummary Define(OpId Operator, int Cycles, long OpCount, Duration Measured)
            => new BenchSummary(Operator, Cycles, OpCount, Measured);

        public BenchSummary(OpId Operator, int Cycles,  long OpCount,  Duration ExecTime)
        {
            this.Operator = Operator;
            this.Cycles = Cycles;
            this.OpCount = OpCount;
            this.ExecTime = ExecTime;
            this.Description = BenchmarkMessages.BenchmarkEnd(Operator, OpCount, ExecTime);
        }

        public OpId Operator {get;}

        public int Cycles {get;}

        public long OpCount {get;}

        public Duration ExecTime {get;}

        public AppMsg Description {get;}

        public string Title 
            => $"{Operator}";

        public override string ToString()
            => Description.ToString();
    }
}