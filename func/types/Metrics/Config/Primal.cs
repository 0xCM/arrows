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



    public class PrimalDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, numSystem: NumericSystem.Primal);

        public const MetricKind Metric = MetricKind.PrimalD;

        public static MetricConfig Configure(MetricConfig config)
            => Metric.Configure(config);

        public static bool DirectOps(MetricConfig config)
            => Metric.Configure(config).DirectOps;

        public static int Cycles(MetricConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(MetricConfig config)
            => Metric.Configure(config).Samples;
    }

    public class PrimalGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, generic:true);

        public const MetricKind Metric = MetricKind.PrimalG;

        public static MetricConfig Configure(MetricConfig config)
            => Metric.Configure(config);

        public static bool DirectOps(MetricConfig config)
            => Metric.Configure(config).DirectOps;

        public static int Cycles(MetricConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(MetricConfig config)
            => Metric.Configure(config).Samples;

    }

}