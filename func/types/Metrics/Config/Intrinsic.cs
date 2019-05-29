//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class InXMetricConfig : MetricConfig
    {

        public InXMetricConfig(MetricKind metric, int Runs, int Cycles, int Blocks, ByteSize BlockSize)
            : base(metric,Runs, Cycles, Blocks * BlockSize, true)
        {
            this.Blocks = Blocks;
        }

        public int Blocks {get;}

    }

    public class InXMetricConfig128 : InXMetricConfig
    {
        public static InXMetricConfig128 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXMetricConfig128(metric, runs, cycles, blocks);

        public static new readonly InXMetricConfig128 Default 
            = new InXMetricConfig128(MetricKind.InX128GFused, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);

        public InXMetricConfig128(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,16)
        {
        
        }
    }

    public class InXMetricConfig256 : InXMetricConfig
    {
        public static InXMetricConfig256 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXMetricConfig256(metric, runs, cycles, blocks);

        public static new readonly InXMetricConfig256 Default 
            = new InXMetricConfig256(MetricKind.InX256GFused, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);
        public InXMetricConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,32)
        {
        
        }
    }



}