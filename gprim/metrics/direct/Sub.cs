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

    public class SubDMetrics : IBinaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
                => Sub(lhs,rhs,config);

        public static Metrics<T> Sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Sub(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Sub(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Sub(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Sub(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Sub(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Sub(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Sub(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Sub(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Sub(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Sub(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public  static Metrics<sbyte> Sub(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (sbyte)(lhs[it] - rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> Sub(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (byte)(lhs[it] - rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> Sub(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (short)(lhs[it] - rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> Sub(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = (ushort)(lhs[it] - rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> Sub(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] - rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> Sub(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] - rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> Sub(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] - rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> Sub(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] - rhs[it];            
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<float> Sub(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                    for(var it=0; it< dst.Length; it++)
                        dst[it] = lhs[it] - rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<double> Sub(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Sub);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs,rhs);
             var dOps = DirectOps(config);
           
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.sub(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] - rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

    }
}