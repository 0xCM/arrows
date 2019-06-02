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


    public class InXDConfig256 : InXConfig256
    {
        public static InXDConfig256 Default(MetricKind metric)
            => new InXDConfig256(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);

        public static InXDConfig256 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXDConfig256(metric, runs, cycles, blocks);

        public InXDConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
        
        }
    }



}