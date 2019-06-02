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

    public class PrimalDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal);

        public const MetricKind Metric = MetricKind.PrimalD;

        public static PrimalDConfig Configure(PrimalDConfig config)
            => PrimalDConfig.Default(Metric);

        public static bool DirectOps(PrimalDConfig config)
            => Configure(config).DirectOps;

        public static int Runs(PrimalDConfig config)
            => Configure(config).Runs;

        public static int Cycles(PrimalDConfig config)
            => Configure(config).Cycles;

        public static int Samples(PrimalDConfig config)
            => Configure(config).Samples;
    }

    public static class PrimalConfigX
    {
        public static PrimalDConfig Configure(this MetricKind metric, PrimalDConfig config = null)
            => config ?? PrimalDConfig.Default(metric);

        public static PrimalGConfig Configure(this MetricKind metric, PrimalGConfig config = null)
            => config ?? PrimalGConfig.Default(metric);

    }


}