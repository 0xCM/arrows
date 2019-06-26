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
    using static BitDMetrics;
    using static As;

    public static class DisableDMetrics 
    {
        public static Metrics<T> Disable<T>(this BitDContext context)
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.ReadOnlySpan<T>(context.Samples);
            var positions = context.Random.Span<int>(context.Samples, closed(0,bitsize - 1));
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Disable(src,positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<T> Disable<T>(this BitDContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.Disable(int8(src), positions).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.Disable(uint8(src),positions).As<T>();
            else if(typeof(T) == typeof(short))
                return context.Disable(int16(src),positions).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.Disable(uint16(src), positions).As<T>();
            else if(typeof(T) == typeof(int))
                return context.Disable(int32(src), positions).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.Disable(uint32(src), positions).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Disable(int64(src), positions).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Disable(uint64(src),positions).As<T>();
            else
                throw unsupported<T>();
        }

        static Metrics<sbyte> Disable(this BitDContext context, ReadOnlySpan<sbyte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<sbyte>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Disable(this BitDContext context, ReadOnlySpan<byte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<byte>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Disable(this BitDContext context, ReadOnlySpan<short> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<short>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Disable(this BitDContext context, ReadOnlySpan<ushort> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ushort>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Disable(this BitDContext context, ReadOnlySpan<int> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<int>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Disable(this BitDContext context, ReadOnlySpan<uint> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<uint>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Disable(this BitDContext context, ReadOnlySpan<long> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<long>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Disable(this BitDContext context, ReadOnlySpan<ulong> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ulong>(OpKind.Disable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.disable(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}
