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


    public class BlockedConfig<N> : MetricConfig
        where N : ITypeNat, new()
    {
        public static readonly BitSize Bits = new N().value;
        
        public static readonly ByteSize Bytes = Bits.ToBytes();

        public BlockedConfig(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks * Bytes)
        {
            this.Blocks = blocks;
        }

        public int Blocks {get;}

    }

    public sealed class BlockedConfig128 : BlockedConfig<N128>
    {
        public BlockedConfig128(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
            
        }

    }

    public sealed class BlockedConfig256 : BlockedConfig<N256>
    {
        public BlockedConfig256(MetricKind metric, int runs, int cycles, int blocks)
            : base(metric, runs, cycles, blocks)
        {
            
        }

    }

}