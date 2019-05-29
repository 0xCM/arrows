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
    using static PrimalGMetrics;


    public class SqrtGMetrics : IUnaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
                => Sqrt(src, config);

        public static Metrics<T> Sqrt<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sqrt);
            var dst = alloc<T>(src.Length);
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.sqrt(src[sample]);
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

    }


}