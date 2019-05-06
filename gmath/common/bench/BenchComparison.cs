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


    public class BenchComparison
    {
        public static readonly BenchComparison Zero = new BenchComparison(BenchSummary.Zero, BenchSummary.Zero);
        
        public static BenchComparison Define(BenchSummary LeftBench, BenchSummary RightBench)
            => new BenchComparison(LeftBench,RightBench);

        public BenchComparison(BenchSummary LeftBench, BenchSummary RightBench)
        {
            this.LeftBench = LeftBench;
            this.RightBench = RightBench;

            
        }

        public BenchSummary LeftBench {get;}

        public BenchSummary RightBench {get;}
    
    }


}