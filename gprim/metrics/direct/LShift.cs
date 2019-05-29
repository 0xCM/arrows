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

    public class LShiftDMetrics : IBinaryHetOpMetric
    {
       public Metrics<S> Measure<S, T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where S : struct
            where T : struct
                => LShift(lhs,int32(rhs),config);

        public static Metrics<T> LShift<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return LShift(int8(lhs), rhs, config).As<T>();
                case PrimalKind.uint8:
                    return LShift(uint8(lhs), rhs, config).As<T>();
                case PrimalKind.int16:
                    return LShift(int16(lhs), rhs, config).As<T>();
                case PrimalKind.uint16:
                    return LShift(uint16(lhs), rhs, config).As<T>();
                case PrimalKind.int32:
                    return LShift(int32(lhs), rhs, config).As<T>();
                case PrimalKind.uint32:
                    return LShift(uint32(lhs), rhs, config).As<T>();
                case PrimalKind.int64:
                    return LShift(int64(lhs), rhs, config).As<T>();
                case PrimalKind.uint64:
                    return LShift(uint64(lhs), rhs, config).As<T>();
                case PrimalKind.float32:
                    return LShift(float32(lhs), rhs, config).As<T>();
                case PrimalKind.float64:                    
                    return LShift(float64(lhs), rhs, config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public  static Metrics<sbyte> LShift(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] << rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> LShift(ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] << rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> LShift(ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] << rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> LShift(ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] << rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> LShift(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] << rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> LShift(ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] << rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> LShift(ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] << rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> LShift(ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.LShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.lshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] << rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

    }
}