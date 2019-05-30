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


    public static class MetricConfigX
    {
        // public static MetricConfig Configure(this MetricKind metric, MetricConfig config = null)
        //     => config ?? MetricConfig.Default(metric);

        // public static int Cycles(this MetricKind metric, MetricConfig config = null)
        //     => metric.Configure(config).Cycles;

        // public static int Runs(this MetricKind metric, MetricConfig config = null)
        //     => metric.Configure(config).Runs;


        public static PrimalDConfig Configure(this MetricKind metric, PrimalDConfig config = null)
            => config ?? PrimalDConfig.Default(metric);

        public static PrimalGConfig Configure(this MetricKind metric, PrimalGConfig config = null)
            => config ?? PrimalGConfig.Default(metric);

        public static BitDConfig Configure(this MetricKind metric, BitDConfig config = null)
            => config ?? BitDConfig.Default(metric);

        public static BitGConfig Configure(this MetricKind metric, BitGConfig config = null)
            => config ?? BitGConfig.Default(metric);

        public static InXConfig128 Configure(this MetricKind metric, InXConfig128 config = null)
            => config ?? InXConfig128.Default(metric);

        public static InXConfig256 Configure(this MetricKind metric, InXConfig256 config = null)
            => config ?? InXConfig256.Default(metric);


        public static NumGConfig Configure(this MetricKind metric, NumGConfig config = null)
            => config ?? NumGConfig.Default(metric);

    }



}