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
    using static As;
    using static PrimalDMetrics;
    
    public class AbsDMetrics : IUnaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
                => Abs(src, config);

        public static Metrics<T> Abs<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Abs(int8(src), config).As<T>();
                case PrimalKind.int16:
                    return Abs(int16(src), config).As<T>();
                case PrimalKind.int32:
                    return Abs(int32(src), config).As<T>();
                case PrimalKind.int64:
                    return Abs(int64(src), config).As<T>();
                case PrimalKind.float32:
                    return Abs(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Abs(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public  static Metrics<sbyte> Abs(ReadOnlySpan<sbyte> src, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = Configure(config).DirectOps;
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
                var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Abs(ReadOnlySpan<short> src, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);

            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }


        public static Metrics<int> Abs(ReadOnlySpan<int> src, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Abs(ReadOnlySpan<long> src, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Abs(ReadOnlySpan<float> src, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = MathF.Abs(src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Abs(ReadOnlySpan<double> src, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Abs);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.abs(src[it]);
            else                
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = Math.Abs(src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
    }
}