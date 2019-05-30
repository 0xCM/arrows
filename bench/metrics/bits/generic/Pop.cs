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
    using static BitGMetrics;

    [OpMetric(MetricKind.BitG, OpKind.Pop)]
    public class PopGMetrics
    {
        public static Metrics<ulong> Pop<T>(ReadOnlySpan<T> src, BitGConfig config = null)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Pop);
            var dst = span<ulong>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gbits.pop(src[sample]);
            
            var time = snapshot(sw);            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
 
        // public static void Validate<T>(ReadOnlySpan<T> src, BitGConfig config = null)
        //     where T : struct
        // {
        //     var baseline = PopDMetrics.Pop(src,config).Result.ToReadOnlySpan();
        //     var generic = PopDMetrics.Pop(src, config).Result.ToReadOnlySpan();
        //     var delta = gmath.sub(baseline, generic);
        //     Claim.@true(delta.All(x => x == 0));                
        // }
        public Metrics<T> Measure<T>(BitGConfig config, IRandomizer random) where T : struct
        {
            var src = random.ReadOnlySpan<T>(config.Samples);
            //Validate(src,config);

            var metrics = Metrics<ulong>.Zero;            
            for(var i=0; i<config.Runs; i++)
            {
                var result = Pop(src,config);
                metrics += result;
                print(result.Describe());
            }
            return metrics.As<T>();
        }
    }
}