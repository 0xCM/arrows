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


    public class InXGConfig256 : InXConfig256
    {
        public static InXGConfig256 Default(MetricKind metric)
            => new InXGConfig256(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);

        public static InXGConfig256 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXGConfig256(metric, runs, cycles, blocks);

        public InXGConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
        
        }
    
        public InXDConfig256 ToDirect()
            => new InXDConfig256(Metric, Runs, Cycles, Blocks);
    
    }



}