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
    
    public static class SubDMetrics
    {
        public static Metrics<T> Sub<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            
            if(typeof(T) == typeof(sbyte))
                    return config.Sub(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Sub(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Sub(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Sub(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.Sub(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Sub(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.Sub(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.Sub(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Sub(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Sub(float64(lhs), float64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
            
        }

        static Metrics<sbyte> Sub(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Sub(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Sub(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
        {
            var opid = Id<short>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Sub(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Sub(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Sub(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Sub(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var opid = Id<long>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Sub(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Sub(this PrimalDConfig config, ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var opid = Id<float>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Sub(this PrimalDConfig config, ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var opid = Id<double>(OpKind.Sub);            
            var cycles = config.Cycles;
            var dst = alloc(lhs,rhs);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.sub(lhs[it],rhs[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}