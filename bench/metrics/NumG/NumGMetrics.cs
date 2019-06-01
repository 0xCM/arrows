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


    public static class NumGMetrics
    {
        public static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericSystem.Primal, numKind : NumericKind.NumG, generic: Genericity.Generic);

        public const MetricKind Metric = MetricKind.NumG;

        public static int Cycles(NumGConfig config)
            => Metric.Configure(config).Cycles;
    }


}