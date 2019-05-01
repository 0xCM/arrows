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



}