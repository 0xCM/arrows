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
    using static As;

    static class InXMetricX
    {
        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, InXConfig config, Duration WorkTime, Span128<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());

        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, InXConfig config, Duration WorkTime, Span256<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());

        // public static InXDConfig128 Configure(this MetricKind metric, InXDConfig128 config = null)
        //     => config ?? InXDConfig128.Default(metric);

        // public static InXGConfig128 Configure(this MetricKind metric, InXGConfig128 config = null)
        //     => config ?? InXGConfig128.Default(metric);

        // public static InXGConfig256 Configure(this MetricKind metric, InXGConfig256 config = null)
        //     => config ?? InXGConfig256.Default(metric);

        // public static InXDConfig256 Configure(this MetricKind metric, InXDConfig256 config = null)
        //     => config ?? InXDConfig256.Default(metric);

    }
}