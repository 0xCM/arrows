//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public class InXDConfig128 : InXConfig128
    {
        public static InXDConfig128 Default(MetricKind metric) 
            => InXDConfig128.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);        

        public static InXDConfig128 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXDConfig128(metric, runs, cycles, blocks);

        public InXDConfig128(MetricKind Metric, int Runs, int Cycles, int Blocks)
            : base(Metric, Runs, Cycles, Blocks)
        {
        
        }
    }


}