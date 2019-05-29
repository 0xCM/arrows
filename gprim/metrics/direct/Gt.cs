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

    public class GtDMetrics : IBinaryOpMetric
    {
        public Metrics<T> Measure<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
                => Gt(lhs,rhs,config);

        public static Metrics<T> Gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Gt(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Gt(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Gt(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Gt(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Gt(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Gt(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Gt(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Gt(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Gt(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Gt(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<sbyte> Gt(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        public static Metrics<byte> Gt(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<short> Gt(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it], rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<ushort> Gt(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<int> Gt(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<uint> Gt(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<long> Gt(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<ulong> Gt(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<float> Gt(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, MetricConfig config = null)
        {
            var opid = Id<float>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }

        public static Metrics<double> Gt(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, MetricConfig config = null)
        {
            var opid = Id<double>(OpKind.Gt);            
            var cycles = Metric.Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gt(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] > rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst.ToScalars(opid));
        }
    }
}