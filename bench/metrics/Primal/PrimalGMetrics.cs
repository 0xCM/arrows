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

    public class PrimalGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, generic: Genericity.Generic);

        public const MetricKind Metric = MetricKind.PrimalG;

        public static PrimalGConfig Configure(PrimalGConfig config)
            => Metric.Configure(config);

        public static int Runs(PrimalGConfig config)
            => Metric.Configure(config).Runs;

        public static int Cycles(PrimalGConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(PrimalGConfig config)
            => Metric.Configure(config).Samples;

        public static bool DirectOps(PrimalGConfig config)
            => Metric.Configure(config).DirectOps;

    }


}