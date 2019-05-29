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
    

    public static class IncNumGMetrics
    {
       public static Metrics<T> Inc<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var numSrc = src.Numbers();
            var dst = Num.alloc<T>(src.Length);
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
                for(var sample = 0; sample < dst.Length; sample++)
                {
                    var x = numSrc[sample];
                    dst[sample] = ++x;
                }
            var time = snapshot(sw);
            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

    }


}