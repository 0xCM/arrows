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
    using static BitDMetrics;
    
    [OpMetric(MetricKind.BitD, OpKind.Pop)]
    public class PopDMetrics : IOpMetric
    {
        public static Metrics<ulong> Pop<S>(ReadOnlySpan<S> src, MetricConfig config = null)
            where S : struct
        {
            if(typeof(S) == typeof(sbyte))
                return Pop(int8(src),config);
            else if(typeof(S) == typeof(byte))
                return Pop(uint8(src),config);
            else if(typeof(S) == typeof(short))
                return Pop(int16(src),config);
            else if(typeof(S) == typeof(ushort))
                return Pop(uint16(src),config);
            else if(typeof(S) == typeof(int))
                return Pop(int32(src),config);
            else if(typeof(S) == typeof(uint))
                return Pop(uint32(src),config);
            else if(typeof(S) == typeof(long))
                return Pop(int64(src),config);
            else if(typeof(S) == typeof(ulong))
                return Pop(uint64(src),config);
            throw unsupported(PrimalKinds.kind<S>());
        }

        public Metrics<T> Measure<T>(MetricConfig config, IRandomizer random) where T : struct
        {
            var src = random.Span<T>(config.Samples).ToReadOnlySpan();
            var metrics = Metrics<ulong>.Zero;
            for(var i=0; i<config.Runs; i++)
            {
                var result = Pop(src,config);
                metrics += result;
                print(result.Describe());
            }
            return metrics.As<T>();

        }

        static Metrics<ulong> Pop(ReadOnlySpan<sbyte> src, MetricConfig config = null)
        {
            OpId opid = Id<sbyte>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Pop(ReadOnlySpan<byte> src, MetricConfig config = null)
        {
            OpId opid = Id<byte>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Pop(ReadOnlySpan<short> src, MetricConfig config = null)
        {
            OpId opid = Id<short>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Pop(ReadOnlySpan<ushort> src, MetricConfig config = null)
        {
            OpId opid = Id<ushort>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Pop(ReadOnlySpan<int> src, MetricConfig config = null)
        {
            OpId opid = Id<int>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);

        }

        static Metrics<ulong> Pop(ReadOnlySpan<uint> src, MetricConfig config = null)
        {
            OpId opid = Id<uint>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }


        static Metrics<ulong> Pop(ReadOnlySpan<long> src, MetricConfig config = null)
        {
            OpId opid = Id<long>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Pop(ReadOnlySpan<ulong> src, MetricConfig config = null)
        {
            OpId opid = Id<long>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = Metric.Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

    }
}