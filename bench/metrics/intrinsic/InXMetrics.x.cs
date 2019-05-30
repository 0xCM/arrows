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

    }
}