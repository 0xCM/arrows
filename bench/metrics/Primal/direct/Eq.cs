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


    public static class EqDMetrics 
    {
        public static Metrics<T> Eq<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                    return config.Eq(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Eq(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Eq(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Eq(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.Eq(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Eq(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.Eq(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.Eq(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Eq(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Eq(float64(lhs), float64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<sbyte> Eq(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<byte> Eq(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<short> Eq(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
        {
            var opid = Id<short>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ushort> Eq(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<int> Eq(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<uint> Eq(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<long> Eq(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var opid = Id<long>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ulong> Eq(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<float> Eq(this PrimalDConfig config, ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var opid = Id<float>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<double> Eq(this PrimalDConfig config, ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var opid = Id<double>(OpKind.Eq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.eq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }
    }
}