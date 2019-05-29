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
    using static NumGMetrics;

    public class GtNumMetrics : IBinaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
                => Gt(lhs,rhs,config);
        public static Metrics<T> Gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Gt);
            var src = lhs.Numbers(rhs);
            var dst = new bool[(length(lhs,rhs))];
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] > src.Right[sample];                   
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst.ToScalars<T>());
                
        }

    }


}