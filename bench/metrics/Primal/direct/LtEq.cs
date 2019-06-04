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


    public static class LtEqDMetrics 
    {
        public static Metrics<T> LtEq<T>(this PrimalDConfig config, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                    return config.LtEq(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                    return config.LtEq(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                    return config.LtEq(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                    return config.LtEq(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                    return config.LtEq(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                    return config.LtEq(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                    return config.LtEq(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                    return config.LtEq(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.LtEq(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.LtEq(float64(lhs), float64(rhs)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<sbyte> LtEq(this PrimalDConfig config, ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
        {
            var opid = Id<sbyte>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<byte> LtEq(this PrimalDConfig config, ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
        {
            var opid = Id<byte>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<short> LtEq(this PrimalDConfig config, ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
        {
            var opid = Id<short>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ushort> LtEq(this PrimalDConfig config, ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
        {
            var opid = Id<ushort>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<int> LtEq(this PrimalDConfig config, ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
        {
            var opid = Id<int>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<uint> LtEq(this PrimalDConfig config, ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
        {
            var opid = Id<uint>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<long> LtEq(this PrimalDConfig config, ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
        {
            var opid = Id<long>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<ulong> LtEq(this PrimalDConfig config, ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
        {
            var opid = Id<ulong>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<float> LtEq(this PrimalDConfig config, ReadOnlySpan<float> lhs, ReadOnlySpan<float> rhs)
        {
            var opid = Id<float>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }

        static Metrics<double> LtEq(this PrimalDConfig config, ReadOnlySpan<double> lhs, ReadOnlySpan<double> rhs)
        {
            var opid = Id<double>(OpKind.LtEq);            
            var cycles = config.Cycles;
            var dst = new bool[length(lhs,rhs)];            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.lteq(lhs[it],rhs[it]);
            var time = snapshot(sw);        
            return opid.CaptureMetrics(cycles*dst.Length, time, dst.ToScalars(opid));                
        }
    }
}