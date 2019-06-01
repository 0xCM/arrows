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
    using static PrimalDMetrics;

    public static class GtEqDMetrics
    {
        public static Metrics<T> GtEq<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return GtEq(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return GtEq(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return GtEq(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return GtEq(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return GtEq(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return GtEq(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return GtEq(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return GtEq(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return GtEq(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return GtEq(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        public static Metrics<sbyte> GtEq(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<byte> GtEq(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<byte>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<short> GtEq(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, PrimalDConfig config = null)
        {
            var opid = Id<short>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<ushort> GtEq(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ushort>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<int> GtEq(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, PrimalDConfig config = null)
        {
            var opid = Id<int>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<uint> GtEq(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, PrimalDConfig config = null)
        {
            var opid = Id<uint>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<long> GtEq(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, PrimalDConfig config = null)
        {
            var opid = Id<long>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<ulong> GtEq(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ulong>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<float> GtEq(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, PrimalDConfig config = null)
        {
            var opid = Id<float>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }

        static Metrics<double> GtEq(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, PrimalDConfig config = null)
        {
            var opid = Id<double>(OpKind.GtEq);            
            var cycles = Cycles(config);
            var dst = new bool[length(lhs,rhs)];
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.gteq(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] >= rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));
        }
    }
}