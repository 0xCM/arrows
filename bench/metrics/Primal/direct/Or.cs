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

    public static class OrDMetrics
    {
        public static Metrics<T> Or<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Or(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Or(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Or(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Or(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Or(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Or(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Or(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Or(uint64(lhs), uint64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> Or(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (sbyte)(lhs[it] | rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<byte> Or(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<byte>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (byte)(lhs[it] | rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<short> Or(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, PrimalDConfig config = null)
        {
            var opid = Id<short>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (short)(lhs[it] | rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ushort> Or(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = (ushort)(lhs[it] | rhs[it]);
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<int> Or(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, PrimalDConfig config = null)
        {
            var opid = Id<int>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] | rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<uint> Or(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, PrimalDConfig config = null)
        {
            var opid = Id<uint>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] | rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<long> Or(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, PrimalDConfig config = null)
        {
            var opid = Id<long>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] | rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Or(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Or);            
            var cycles = Cycles(config);
            var dst = alloc(lhs,rhs);
            var dOps = DirectOps(config);
            
            var sw = stopwatch();
            if(dOps)
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = math.or(lhs[it],rhs[it]);
            else
                for(var cycle = 0; cycle < cycles; cycle++)
                for(var it=0; it< dst.Length; it++)
                    dst[it] = lhs[it] | rhs[it];
            var time = snapshot(sw);

            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
    }
}