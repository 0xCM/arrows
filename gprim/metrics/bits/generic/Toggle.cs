//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Measure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static BitGMetrics;

    [OpMetric(MetricKind.BitG, OpKind.ToggleBit)]
    public class ToggleGMetrics : IOpMetric
    {
        public static Metrics<T> Toggle<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> positions,  MetricConfig config = null)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.ToggleBit);
            var dst = span<T>(Metric.Samples(config));
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 dst[sample] = gbits.toggle(dst[sample], positions[sample]);            
            
            var time = snapshot(sw);            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> ToggleInPlace<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> positions,  MetricConfig config = null)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.ToggleBit);
            var dst = src.Replicate();        
            var cycles = Metric.Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 gbits.toggle(ref dst[sample], positions[sample]);            
            
            var time = snapshot(sw);            
            return opid.DefineMetrics(cycles*dst.Length, time, dst);
        }

        public static void Validate<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> pos, MetricConfig config = null)
            where T : struct
        {
            var baseline = ToggleDMetrics.Toggle(src, pos, config).Result.ToReadOnlySpan();
            var generic = ToggleDMetrics.Toggle(src, pos, config).Result.ToReadOnlySpan();
            var delta = gmath.sub(baseline, generic);
            Claim.@true(delta.All(x => gmath.eq(x, gmath.zero<T>())));
        }

        public Metrics<T> Measure<T>(MetricConfig config, IRandomizer random)
            where T : struct
        {
            var src = random.Span<T>(config.Samples).ToReadOnlySpan();
            var positions = random.Span<int>(config.Samples, closed(0,7));
            Validate(src,positions,config);
            
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<config.Runs; i++)
            {
                var result = Toggle(src,positions,config);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }
    }

}