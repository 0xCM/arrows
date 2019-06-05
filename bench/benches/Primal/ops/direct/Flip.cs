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
    
    public static class FlipDMetrics 
    {
        public static Metrics<T> Flip<T>(this PrimalDConfig config, ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return config.Flip(int8(src)).As<T>();
            else if(typeof(T) == typeof(byte))
                return config.Flip(uint8(src)).As<T>();
            else if(typeof(T) == typeof(short))
                return config.Flip(int16(src)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return config.Flip(uint16(src)).As<T>();
            else if(typeof(T) == typeof(int))
                return config.Flip(int32(src)).As<T>();
            else if(typeof(T) == typeof(uint))
                return config.Flip(uint32(src)).As<T>();
            else if(typeof(T) == typeof(long))
                return config.Flip(int64(src)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return config.Flip(uint64(src)).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Flip(this PrimalDConfig config, ReadOnlySpan<sbyte> src)
        {
            var opid = Id<sbyte>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Flip(this PrimalDConfig config, ReadOnlySpan<byte> src)
        {
            var opid = Id<byte>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Flip(this PrimalDConfig config, ReadOnlySpan<short> src)
        {
            var opid = Id<short>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Flip(this PrimalDConfig config, ReadOnlySpan<ushort> src)
        {
            var opid = Id<ushort>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Flip(this PrimalDConfig config, ReadOnlySpan<int> src)
        {
            var opid = Id<int>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Flip(this PrimalDConfig config, ReadOnlySpan<uint> src)
        {
            var opid = Id<uint>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Flip(this PrimalDConfig config, ReadOnlySpan<long> src)
        {
            var opid = Id<long>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Flip(this PrimalDConfig config, ReadOnlySpan<ulong> src)
        {
            var opid = Id<ulong>(OpKind.Flip);            
            var cycles = config.Cycles;
            var dst = alloc(src);            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var it=0; it< dst.Length; it++)
                dst[it] = math.flip(src[it]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}