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
    using static mfunc;

    public class MetricConfig
    {
        public static readonly MetricConfig Default 
            = MetricConfig.Define(runs: Pow2.T03, cycles: Pow2.T14, samples: Pow2.T12, dops: true);        

        public static MetricConfig Define(int runs, int cycles, int samples, bool dops)
            => new MetricConfig(runs,cycles,samples, dops);

        public MetricConfig(int Runs, int Cycles, int Samples, bool DirectOps)
        {
            this.Runs = Runs;
            this.Cycles = Cycles;
            this.Samples = Samples;
            this.DirectOps = DirectOps;
        }
        
        public int Runs {get;}
        
        public int Cycles {get;}

        public int Samples {get;}

        public bool DirectOps {get;}
    }

    public class InXMetricConfig : MetricConfig
    {
        public static InXMetricConfig<N> Define<N>(int runs, int cycles, int blocks)
            where N : ITypeNat, new()
                => new InXMetricConfig<N>(runs, cycles, blocks);

        public InXMetricConfig(int Runs, int Cycles, int Blocks, ByteSize BlockSize)
            : base(Runs, Cycles, Blocks * BlockSize*Blocks, true)
        {
            this.Blocks = Blocks;
        }

        public int Blocks {get;}

    }

    public class InXMetricConfig<N> : InXMetricConfig
        where N : ITypeNat, new()
    {
        public static readonly ByteSize BlockSize = nfunc.nati<N>() / 8;

        public static new readonly InXMetricConfig<N> Default 
            = InXMetricConfig.Define<N>(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12);        

        public InXMetricConfig(int Runs, int Cycles, int Blocks)
            : base(Runs, Cycles, Blocks, BlockSize)
        {
        
        }
        
    }

    public static class InXMetricConfigX
    {
        public static InXMetricConfig128 Monomorphic(this InXMetricConfig<N128> src)
            => new InXMetricConfig128(src.Runs, src.Cycles, src.Blocks);

        public static InXMetricConfig256 Monomorphic(this InXMetricConfig<N256> src)
            => new InXMetricConfig256(src.Runs, src.Cycles, src.Blocks);

    }
    public class InXMetricConfig128 : InXMetricConfig<N128>
    {
        public static new readonly InXMetricConfig128 Default 
            = InXMetricConfig.Define<N128>(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12).Monomorphic();        

        public InXMetricConfig128(int Runs, int Cycles, int Blocks)
            : base(Runs, Cycles, Blocks)
        {
        
        }

    }

    public class InXMetricConfig256 : InXMetricConfig<N256>
    {
        public static new readonly InXMetricConfig256 Default 
            = InXMetricConfig.Define<N256>(runs: Pow2.T03, cycles: Pow2.T14, blocks: Pow2.T12).Monomorphic();        
        public InXMetricConfig256(int Runs, int Cycles, int Blocks)
            : base(Runs, Cycles, Blocks)
        {
        
        }

    }

}