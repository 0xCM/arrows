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
            : base(metric,Runs, Cycles, Blocks * BlockSize)
        {
            this.Blocks = Blocks;
        }

        public int Blocks {get;}

        public InXDConfig128 ToDirect128()
            => new InXDConfig128(Metric, Runs, Cycles, Samples);

        public InXGConfig128 ToGeneric128()
            => new InXGConfig128(Metric, Runs, Cycles, Samples);

        public InXDConfig256 ToDirect256()
            => new InXDConfig256(Metric, Runs, Cycles, Samples);

        public InXGConfig256 ToGeneric256()
            => new InXGConfig256(Metric, Runs, Cycles, Samples);

    }
}