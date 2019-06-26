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
    
    public static class NegateDMetrics 
    {
        public static Metrics<T> Negate<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.Negate(int8(src)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.Negate(int16(src)).As<T>();
            else if(typeof(T) == typeof(int))
                return config.Negate(int32(src)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Negate(int64(src)).As<T>();
            else if(typeof(T) == typeof(float))
                return config.Negate(float32(src)).As<T>();
            else if(typeof(T) == typeof(double))
                return config.Negate(float64(src)).As<T>();
            else
                throw unsupported<T>();
        }

        static Metrics<sbyte> Negate(this PrimalDConfig config, ReadOnlySpan<sbyte> src)
        {
            var opid = Id<sbyte>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Negate(this PrimalDConfig config, ReadOnlySpan<short> src)
        {
            var opid = Id<short>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Negate(this PrimalDConfig config, ReadOnlySpan<int> src)
        {
            var opid = Id<int>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Negate(this PrimalDConfig config, ReadOnlySpan<long> src)
        {
            var opid = Id<long>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Negate(this PrimalDConfig config, ReadOnlySpan<float> src)
        {
            var opid = Id<float>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Negate(this PrimalDConfig config, ReadOnlySpan<double> src)
        {
            var opid = Id<double>(OpKind.Negate);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.negate(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}