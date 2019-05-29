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

    public class RShiftDMetrics : IBinaryHetOpMetric
    {
       public Metrics<S> Measure<S, T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where S : struct
            where T : struct
                => RShift(lhs,int32(rhs),config);

        public static Metrics<T> RShift<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return RShift(int8(lhs), rhs, config).As<T>();
                case PrimalKind.uint8:
                    return RShift(uint8(lhs), rhs, config).As<T>();
                case PrimalKind.int16:
                    return RShift(int16(lhs), rhs, config).As<T>();
                case PrimalKind.uint16:
                    return RShift(uint16(lhs), rhs, config).As<T>();
                case PrimalKind.int32:
                    return RShift(int32(lhs), rhs, config).As<T>();
                case PrimalKind.uint32:
                    return RShift(uint32(lhs), rhs, config).As<T>();
                case PrimalKind.int64:
                    return RShift(int64(lhs), rhs, config).As<T>();
                case PrimalKind.uint64:
                    return RShift(uint64(lhs), rhs, config).As<T>();
                case PrimalKind.float32:
                    return RShift(float32(lhs), rhs, config).As<T>();
                case PrimalKind.float64:                    
                    return RShift(float64(lhs), rhs, config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }


        public  static Metrics<sbyte> RShift(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] >> rhs[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<byte> RShift(ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<byte>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] >> rhs[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<short> RShift(ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<short>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] >> rhs[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ushort> RShift(ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<ushort>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] >> rhs[it]);
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<int> RShift(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<int>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >> rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<uint> RShift(ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<uint>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >> rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<long> RShift(ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<long>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >> rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }

        public  static Metrics<ulong> RShift(ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, MetricConfig config = null)
        {
            var opid = Id<ulong>(OpKind.RShift);            
            var cycles = Metric.Cycles(config);
            var dst = alloc(lhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.rshift(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >> rhs[it];
            var time = snapshot(sw);

            return Metrics.Capture(opid, cycles*dst.Length, time, dst);
        }
    }
}