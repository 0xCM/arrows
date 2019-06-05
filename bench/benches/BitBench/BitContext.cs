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
    using static As;
    using static BenchRunner;

    public static class BitDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal);

    }

    public static class BitGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, generic: Genericity.Generic);
    }

    public abstract class BitContext : BenchContext<MetricConfig>         
    {
        public BitContext(MetricConfig config, IRandomizer random = null)
            : base(config, random)
        {

        }

        public BitDContext ToDirect()
            => new BitDContext(Config, Randomizer);

        public BitGContext ToGeneric()
            => new BitGContext(Config, Randomizer);

    }
}