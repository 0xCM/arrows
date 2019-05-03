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
        public BenchSummary(OpId Operator, long OpCount, Duration Measured, Duration Runtime)
        {
            this.Title = Title;
            this.Operator = Operator;
            this.OpCount = OpCount;
            this.Measured = Measured;
            this.Runtime = Runtime;
            this.Description = BenchmarkMessages.BenchmarkEnd(Operator, OpCount, Measured);
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



    public class BenchDetail : BenchSummary
    {
        public static BenchDetail Define(OpId Operator, int Cycles, int Reps, int Samples, long OpCount, Duration Measured, Duration Runtime)
            => new BenchDetail(Operator, Cycles, Reps, Samples, OpCount, Measured, Runtime);
        
        BenchDetail(OpId Operator, int Cycles, int Reps, int Samples, long OpCount, Duration Measured, Duration Runtime)
            : base(Operator, OpCount, Measured,Runtime)
        {
            this.Cycles = Cycles;
            this.Reps = Reps;
            this.Samples = Samples;
        }
        
        public int Cycles {get;}

        public int Reps {get;}

        public int Samples {get;}

    }

    
}