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
    
    public static class AddDMetrics
    {
        public static Metrics<T> Add<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Add(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Add(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Add(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Add(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Add(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Add(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Add(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Add(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Add(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Add(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }


        static Metrics<sbyte> Add(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, PrimalDConfig config)
        {
            var opid = Id<sbyte>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Add(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, PrimalDConfig config)
        {
            var opid = Id<byte>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Add(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, PrimalDConfig config)
        {
            var opid = Id<short>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Add(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, PrimalDConfig config)
        {
            var opid = Id<ushort>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Add(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, PrimalDConfig config)
        {
            var opid = Id<int>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Add(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, PrimalDConfig config)
        {
            var opid = Id<uint>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Add(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, PrimalDConfig config)
        {
            var opid = Id<long>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Add(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, PrimalDConfig config)
        {
            var opid = Id<ulong>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Add(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, PrimalDConfig config)
        {
            var opid = Id<float>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Add(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, PrimalDConfig config)
        {
            var opid = Id<double>(OpKind.Add);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.add(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}