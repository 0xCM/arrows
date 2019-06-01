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
    
    public static class AbsDMetrics 
    {
        public static Metrics<T> Abs<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Abs(int8(src), config).As<T>();
                case PrimalKind.int16:
                    return Abs(int16(src), config).As<T>();
                case PrimalKind.int32:
                    return Abs(int32(src), config).As<T>();
                case PrimalKind.int64:
                    return Abs(int64(src), config).As<T>();
                case PrimalKind.float32:
                    return Abs(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Abs(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<sbyte> Abs(ReadOnlySpan<sbyte> src, PrimalDConfig config)
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

        static Metrics<short> Abs(ReadOnlySpan<short> src, PrimalDConfig config)
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

        static Metrics<int> Abs(ReadOnlySpan<int> src, PrimalDConfig config)
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

        static Metrics<long> Abs(ReadOnlySpan<long> src, PrimalDConfig config)
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

        static Metrics<float> Abs(ReadOnlySpan<float> src, PrimalDConfig config)
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

        static Metrics<double> Abs(ReadOnlySpan<double> src, PrimalDConfig config)
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