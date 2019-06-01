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

    public static class BitDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal);

        public const MetricKind Metric = MetricKind.BitD;

        public static int Runs(BitDConfig config)
            => Metric.Configure(config).Runs;

        public static int Cycles(BitDConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(BitDConfig config)
            => Metric.Configure(config).Samples;
    }

    public static class BitGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, generic: Genericity.Generic);
    
        public const MetricKind Metric = MetricKind.BitG;

        public static int Runs(BitGConfig config)
            => Metric.Configure(config).Runs;

        public static int Cycles(BitGConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(BitGConfig config)
            => Metric.Configure(config).Samples;

    }

}