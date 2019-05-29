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

    public static class BitDMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, numSystem: NumericSystem.Primal);

        public const MetricKind Metric = MetricKind.BitD;

        public static MetricConfig Configure(MetricConfig config)
            => Metric.Configure(config);

        public static int Cycles(MetricConfig config)
            => Metric.Configure(config).Cycles;

        public static int Samples(MetricConfig config)
            => Metric.Configure(config).Samples;
    }

    public static class BitGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, generic:true);
    
        public static MetricConfig Configure(MetricConfig config)
            => Metric.Configure(config);

        public const MetricKind Metric = MetricKind.BitG;
    }


}