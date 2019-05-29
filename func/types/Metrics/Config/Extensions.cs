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


    public static class MetricConfigX
    {
        public static MetricConfig Configure(this MetricKind metric, MetricConfig config = null)
            => config ?? MetricConfig.Default(metric);

        public static int Cycles(this MetricKind metric, MetricConfig config = null)
            => metric.Configure(config).Cycles;

        public static int Runs(this MetricKind metric, MetricConfig config = null)
            => metric.Configure(config).Runs;

        public static int Samples(this MetricKind metric, MetricConfig config = null)
            => metric.Configure(config).Samples;
    }



}