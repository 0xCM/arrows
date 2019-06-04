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
    using static BitDMetrics;
    using Z0.Bench;

    public static class PopDMetrics
    {
        public static Metrics<T> Pop<T>(this BitDContext context) 
            where T : struct
        {
            var src = context.Random.Span<T>(context.Samples).ToReadOnlySpan();
            var metrics = Metrics<ulong>.Zero;
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Pop(src);
                metrics += result;
                print(result.Describe());
            }
            return metrics.As<T>();

        }

        static Metrics<ulong> Pop<S>(this BitDContext context, ReadOnlySpan<S> src)
            where S : struct
        {
            if(typeof(S) == typeof(sbyte))
                return context.Pop(int8(src));
            else if(typeof(S) == typeof(byte))
                return context.Pop(uint8(src));
            else if(typeof(S) == typeof(short))
                return context.Pop(int16(src));
            else if(typeof(S) == typeof(ushort))
                return context.Pop(uint16(src));
            else if(typeof(S) == typeof(int))
                return context.Pop(int32(src));
            else if(typeof(S) == typeof(uint))
                return context.Pop(uint32(src));
            else if(typeof(S) == typeof(long))
                return context.Pop(int64(src));
            else if(typeof(S) == typeof(ulong))
                return context.Pop(uint64(src));
            throw unsupported(PrimalKinds.kind<S>());
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<sbyte> src)
        {
            OpId opid = Id<sbyte>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<byte> src)
        {
            OpId opid = Id<byte>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<short> src)
        {
            OpId opid = Id<short>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<ushort> src)
        {
            OpId opid = Id<ushort>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<int> src)
        {
            OpId opid = Id<int>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<uint> src)
        {
            OpId opid = Id<uint>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<long> src)
        {
            OpId opid = Id<long>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop(this BitDContext context, ReadOnlySpan<ulong> src)
        {
            OpId opid = Id<long>(OpKind.Pop);            
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                dst[sample] = Bits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

    }
}