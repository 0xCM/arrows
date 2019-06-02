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



    public class InXGConfig128 : InXConfig
    {
        public static InXGConfig128 Default(MetricKind metric) 
            => InXGConfig128.Define(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);        

        public static InXGConfig128 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXGConfig128(metric, runs, cycles, blocks);

        public InXGConfig128(MetricKind Metric, int Runs, int Cycles, int Blocks)
            : base(Metric, Runs, Cycles, Blocks, 16)
        {
        
        }

        public InXDConfig128 ToDirect()
            => new InXDConfig128(Metric, Runs, Cycles, Blocks);

    }


}