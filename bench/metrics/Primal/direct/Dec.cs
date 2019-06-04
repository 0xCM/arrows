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
    
    public static class DecDMetrics 
    {
        public static Metrics<T> Dec<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.Dec(int8(src)).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.Dec(uint8(src)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.Dec(int16(src)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.Dec(uint16(src)).As<T>();
            else if(typeof(T) == typeof(int))
                return config.Dec(int32(src)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.Dec(uint32(src)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Dec(int64(src)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.Dec(uint64(src)).As<T>();
            else if(typeof(T) == typeof(float))
                    return config.Dec(float32(src)).As<T>();
            else if(typeof(T) == typeof(double))
                    return config.Dec(float64(src)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Dec(this PrimalDConfig config, ReadOnlySpan<sbyte> src)
        {
            var opid = Id<sbyte>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Dec(this PrimalDConfig config, ReadOnlySpan<byte> src)
        {
            var opid = Id<byte>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Dec(this PrimalDConfig config, ReadOnlySpan<short> src)
        {
            var opid = Id<short>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Dec(this PrimalDConfig config, ReadOnlySpan<ushort> src)
        {
            var opid = Id<ushort>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Dec(this PrimalDConfig config, ReadOnlySpan<int> src)
        {
            var opid = Id<int>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Dec(this PrimalDConfig config, ReadOnlySpan<uint> src)
        {
            var opid = Id<uint>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Dec(this PrimalDConfig config, ReadOnlySpan<long> src)
        {
            var opid = Id<long>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Dec(this PrimalDConfig config, ReadOnlySpan<ulong> src)
        {
            var opid = Id<ulong>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<float> Dec(this PrimalDConfig config, ReadOnlySpan<float> src)
        {
            var opid = Id<float>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<double> Dec(this PrimalDConfig config, ReadOnlySpan<double> src)
        {
            var opid = Id<double>(OpKind.Dec);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.dec(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}