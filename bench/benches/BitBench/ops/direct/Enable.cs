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

    public static class EnableDMetrics 
    {
        public static Metrics<T> Enable<T>(this BitDContext context)
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.ReadOnlySpan<T>(context.Samples);
            var positions = context.Random.Span<int>(context.Samples, closed(0,bitsize - 1));
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Enable(src,positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<T> Enable<T>(this BitDContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.Enable(int8(src), positions).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.Enable(uint8(src),positions).As<T>();
            else if(typeof(T) == typeof(short))
                return context.Enable(int16(src),positions).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.Enable(uint16(src), positions).As<T>();
            else if(typeof(T) == typeof(int))
                return context.Enable(int32(src), positions).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.Enable(uint32(src), positions).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Enable(int64(src), positions).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Enable(uint64(src),positions).As<T>();
            throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Enable(this BitDContext context, ReadOnlySpan<sbyte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<sbyte>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Enable(this BitDContext context, ReadOnlySpan<byte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<byte>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Enable(this BitDContext context, ReadOnlySpan<short> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<short>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Enable(this BitDContext context, ReadOnlySpan<ushort> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ushort>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Enable(this BitDContext context, ReadOnlySpan<int> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<int>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Enable(this BitDContext context, ReadOnlySpan<uint> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<uint>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Enable(this BitDContext context, ReadOnlySpan<long> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<long>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Enable(this BitDContext context, ReadOnlySpan<ulong> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ulong>(OpKind.Enable);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.enable(src[sample], pos[sample]);
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }
}