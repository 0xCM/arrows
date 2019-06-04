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
    
    public static class IncDMetrics 
    {
        public static Metrics<T> Inc<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.Inc(int8(src)).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.Inc(uint8(src)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.Inc(int16(src)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.Inc(uint16(src)).As<T>();
            else if(typeof(T) == typeof(int))
                return config.Inc(int32(src)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.Inc(uint32(src)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Inc(int64(src)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.Inc(uint64(src)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Inc(float32(src)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Inc(float64(src)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Inc(this PrimalDConfig config, ReadOnlySpan<sbyte> src)
        {
            var opid = Id<sbyte>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Inc(this PrimalDConfig config, ReadOnlySpan<byte> src)
        {
            var opid = Id<byte>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Inc(this PrimalDConfig config, ReadOnlySpan<short> src)
        {
            var opid = Id<short>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Inc(this PrimalDConfig config, ReadOnlySpan<ushort> src)
        {
            var opid = Id<ushort>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Inc(this PrimalDConfig config, ReadOnlySpan<int> src)
        {
            var opid = Id<int>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Inc(this PrimalDConfig config, ReadOnlySpan<uint> src)
        {
            var opid = Id<uint>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Inc(this PrimalDConfig config, ReadOnlySpan<long> src)
        {
            var opid = Id<long>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Inc(this PrimalDConfig config, ReadOnlySpan<ulong> src)
        {
            var opid = Id<ulong>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Inc(this PrimalDConfig config, ReadOnlySpan<float> src)
        {
            var opid = Id<float>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Inc(this PrimalDConfig config, ReadOnlySpan<double> src)
        {
            var opid = Id<double>(OpKind.Inc);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.inc(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}