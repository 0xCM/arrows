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
            
            if(typeof(T) == typeof(sbyte))
                    return config.Add(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Add(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Add(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Add(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.Add(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Add(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.Add(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.Add(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Add(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Add(float64(lhs), float64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
            
        }

        static Metrics<sbyte> Add(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
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

        static Metrics<byte> Add(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
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

        static Metrics<short> Add(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
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

        static Metrics<ushort> Add(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
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

        static Metrics<int> Add(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
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

        static Metrics<uint> Add(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
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

        static Metrics<long> Add(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
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

        static Metrics<ulong> Add(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
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

        static Metrics<float> Add(this PrimalDConfig config, ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
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

        static Metrics<double> Add(this PrimalDConfig config, ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
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