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
    
    public static class XOrDMetrics
    {
        public static Metrics<T> XOr<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            
            if(typeof(T) == typeof(sbyte))
                    return config.XOr(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.XOr(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.XOr(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.XOr(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.XOr(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.XOr(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.XOr(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.XOr(uint64(lhs), uint64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
            
        }

        static Metrics<sbyte> XOr(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> XOr(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> XOr(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
        {
            var opid = Id<short>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> XOr(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> XOr(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> XOr(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> XOr(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var opid = Id<long>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> XOr(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.XOr);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.xor(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}