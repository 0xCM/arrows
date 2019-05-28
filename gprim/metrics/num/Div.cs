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
    
    public class DivNumMetrics : IBinaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
                => Div(lhs,rhs,config);

        public static Metrics<T> Div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var src = lhs.Numbers(rhs);
            var dst = Num.alloc<T>(length(lhs,rhs));
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                     dst[sample] = src.Left[sample] / src.Right[sample];                   
            var time = snapshot(sw);
                    
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

    }

}


