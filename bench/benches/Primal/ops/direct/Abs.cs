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
    
    public static class AbsDMetrics 
    {
        public static Metrics<T> Abs<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.Abs(int8(src)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.Abs(int16(src)).As<T>();
            else if(typeof(T) == typeof(int))
                return config.Abs(int32(src)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Abs(int64(src)).As<T>();
            else if(typeof(T) == typeof(float))
                return config.Abs(float32(src)).As<T>();
            else if(typeof(T) == typeof(double))
                return config.Abs(float64(src)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Abs(this PrimalDConfig config, ReadOnlySpan<sbyte> src)
        {
            var opid = Id<sbyte>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Abs(this PrimalDConfig config, ReadOnlySpan<short> src)
        {
            var opid = Id<short>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Abs(this PrimalDConfig config, ReadOnlySpan<int> src)
        {
            var opid = Id<int>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Abs(this PrimalDConfig config, ReadOnlySpan<long> src)
        {
            var opid = Id<long>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Abs(this PrimalDConfig config, ReadOnlySpan<float> src)
        {
            var opid = Id<float>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Abs(this PrimalDConfig config, ReadOnlySpan<double> src)
        {
            var opid = Id<double>(OpKind.Abs);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.abs(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}