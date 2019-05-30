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

    public abstract class InXConfig : MetricConfig
    {

        protected InXConfig(MetricKind metric, int Runs, int Cycles, int Blocks, ByteSize BlockSize)
            : base(metric,Runs, Cycles, Blocks * BlockSize, true)
        {
            this.Blocks = Blocks;
        }

        public int Blocks {get;}

    }

    public class InXConfig128 : InXConfig
    {
        public static InXConfig128 Default(MetricKind metric) 
            => new InXConfig128(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);

        public static InXConfig128 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXConfig128(metric, runs, cycles, blocks);

        public InXConfig128(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,16)
        {
        
        }
    }

    public class InXConfig256 : InXConfig
    {
        public static InXConfig256 Default(MetricKind metric)
            => new InXConfig256(metric, runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);

        public static InXConfig256 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXConfig256(metric, runs, cycles, blocks);

        public InXConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,32)
        {
        
        }
    }



}