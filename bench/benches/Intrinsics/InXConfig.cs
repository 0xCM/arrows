//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public abstract class InXConfig : MetricConfig
    {
        protected InXConfig(MetricKind metric, int Runs, int Cycles, int Blocks, Byte BlockSize)
            : base(metric,Runs, Cycles, Blocks * BlockSize)
        {
            this.Blocks = Blocks;
        }

        public int Blocks {get;}

        public InXDConfig128 ToDirect128()
            => new InXDConfig128(Metric, Runs, Cycles, Blocks);

        public InXGConfig128 ToGeneric128()
            => new InXGConfig128(Metric, Runs, Cycles, Blocks);

        public InXDConfig256 ToDirect256()
            => new InXDConfig256(Metric, Runs, Cycles, Blocks);

        public InXGConfig256 ToGeneric256()
            => new InXGConfig256(Metric, Runs, Cycles, Blocks);

    }
    
    public abstract class InXConfig128 : InXConfig
    {
        public InXConfig128(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks, 16)
        {
        
        }
    }

    public abstract class InXConfig256 : InXConfig
    {
        public InXConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks,32)
        {
        
        }
    }    
    public class InXGConfig256 : InXConfig256
    {
        public static new InXGConfig256 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXGConfig256(metric, runs, cycles, blocks);

        public InXGConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
        
        }        
    }    

    public class InXDConfig128 : InXConfig128
    {

        public InXDConfig128(MetricKind Metric, int Runs, int Cycles, int Blocks)
            : base(Metric, Runs, Cycles, Blocks)
        {
        
        }
    }    

    public class InXDConfig256 : InXConfig256
    {
        public InXDConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
        
        }
    }

    public class InXGConfig128 : InXConfig
    {
        public static new InXGConfig128 Define(MetricKind metric, int runs, int cycles, int blocks)
            => new InXGConfig128(metric, runs, cycles, blocks);

        public InXGConfig128(MetricKind Metric, int Runs, int Cycles, int Blocks)
            : base(Metric, Runs, Cycles, Blocks, 16)
        {
        
        }
    }

}
