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

    public static class MulDMetrics
    {
        public static Metrics<T> Mul<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Mul(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Mul(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Mul(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Mul(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Mul(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Mul(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Mul(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Mul(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Mul(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Mul(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> Mul(ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<sbyte>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Mul(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs, PrimalDConfig config = null)
        {
            var opid = Id<byte>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Mul(ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs, PrimalDConfig config = null)
        {
            var opid = Id<short>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Mul(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ushort>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Mul(ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, PrimalDConfig config = null)
        {
            var opid = Id<int>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Mul(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, PrimalDConfig config = null)
        {
            var opid = Id<uint>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Mul(ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs, PrimalDConfig config = null)
        {
            var opid = Id<long>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Mul(ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs, PrimalDConfig config = null)
        {
            var opid = Id<ulong>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Mul(ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs, PrimalDConfig config = null)
        {
            var opid = Id<float>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Mul(ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs, PrimalDConfig config = null)
        {
            var opid = Id<double>(OpKind.Mul);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.mul(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}