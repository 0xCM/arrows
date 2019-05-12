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

    public partial class PrimalGenericBench : PrimalBench
    {
        public static PrimalGenericBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalGenericBench(random, config);

        protected int Baseline = 2;
        
        PrimalGenericBench(IRandomizer random, BenchConfig config = null)
            : base(random, config)
        {
            this.Baselines = BaselineMetrics.Create(LeftSrc, RightSrc, NonZeroSrc, Z0.Randomizer.define(RandSeeds.BenchSeed), config);
        }

        protected BaselineMetrics Baselines {get;}

        protected override OpId<T> Id<T>(OpKind op, bool generic = false)
            => op.PrimalAtomic<T>(generic);

    }

}