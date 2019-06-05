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
    using Z0.Bench;

    public static class ToggleDMetrics 
    {
        public static Metrics<T> Toggle<T>(this BitDContext context)
            where T : struct
        {
            var src = context.Random.ReadOnlySpan<T>(context.Samples);
            var positions = context.Random.Span<int>(context.Samples, closed(0,7));
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Toggle(src,positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<T> Toggle<T>(this BitDContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.Toggle(int8(src), positions).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.Toggle(uint8(src),positions).As<T>();
            else if(typeof(T) == typeof(short))
                return context.Toggle(int16(src),positions).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.Toggle(uint16(src), positions).As<T>();
            else if(typeof(T) == typeof(int))
                return context.Toggle(int32(src), positions).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.Toggle(uint32(src), positions).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Toggle(int64(src), positions).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Toggle(uint64(src),positions).As<T>();
            throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<sbyte> Toggle(this BitDContext context, ReadOnlySpan<sbyte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<sbyte>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<byte> Toggle(this BitDContext context, ReadOnlySpan<byte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<byte>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<short> Toggle(this BitDContext context, ReadOnlySpan<short> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<short>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ushort> Toggle(this BitDContext context, ReadOnlySpan<ushort> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ushort>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<int> Toggle(this BitDContext context, ReadOnlySpan<int> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<int>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<uint> Toggle(this BitDContext context, ReadOnlySpan<uint> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<uint>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<long> Toggle(this BitDContext context, ReadOnlySpan<long> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<long>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Toggle(this BitDContext context, ReadOnlySpan<ulong> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ulong>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
    }

}
