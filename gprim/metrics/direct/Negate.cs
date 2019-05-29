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

    public class NegateDMetrics : IUnaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
                => Negate(src, config);

        public static Metrics<T> Negate<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Negate(int8(src), config).As<T>();
                case PrimalKind.int16:
                    return Negate(int16(src), config).As<T>();
                case PrimalKind.int32:
                    return Negate(int32(src), config).As<T>();
                case PrimalKind.int64:
                    return Negate(int64(src), config).As<T>();
                case PrimalKind.float32:
                    return Negate(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Negate(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public  static Metrics<sbyte> Negate(ReadOnlySpan<sbyte> src, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte) (-src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }


        public  static Metrics<short> Negate(ReadOnlySpan<short> src, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short) (-src[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }


        public static Metrics<int> Negate(ReadOnlySpan<int> src, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = -src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Negate(ReadOnlySpan<long> src, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = -src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Negate(ReadOnlySpan<float> src, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = -src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Negate(ReadOnlySpan<double> src, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Negate);            
            var cycles = Metric.Cycles(config);
            var dOps = DirectOps(config);
            var dst = alloc(src);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.negate(src[it]);
            else
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = -src[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
    }
}