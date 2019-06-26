//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static PrimalDMetrics;


    public static class LtDMetrics 
    {
        public static Metrics<T> Lt<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                    return config.Lt(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.Lt(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.Lt(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.Lt(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.Lt(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.Lt(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.Lt(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.Lt(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Lt(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Lt(float64(lhs), float64(rhs)).As<T>();
            else
                throw unsupported<T>();
        }

        static Metrics<sbyte> Lt(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<byte> Lt(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<short> Lt(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
        {
            var opid = Id<short>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ushort> Lt(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<int> Lt(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<uint> Lt(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<long> Lt(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var opid = Id<long>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ulong> Lt(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<float> Lt(this PrimalDConfig config, ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var opid = Id<float>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<double> Lt(this PrimalDConfig config, ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var opid = Id<double>(OpKind.Lt);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lt(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }
    }
}