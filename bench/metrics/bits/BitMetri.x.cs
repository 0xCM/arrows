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

    public static class BitMetricX
    {
        public static BitDConfig Configure(this MetricKind metric, BitDConfig config = null)
            => config ?? BitDConfig.Default(metric);

        public static BitGConfig Configure(this MetricKind metric, BitGConfig config = null)
            => config ?? BitGConfig.Default(metric);

    }


}