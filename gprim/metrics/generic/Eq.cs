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
    using static PrimalGMetrics;
    

    public class EqGMetrics : IBinaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
                => Eq(lhs,rhs,config);

        public static Metrics<T> Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Eq);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.eq(lhs[sample], rhs[sample]);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, 
                map(dst, x => x ? gmath.one<T>() : gmath.zero<T>()));
        }

    }

}