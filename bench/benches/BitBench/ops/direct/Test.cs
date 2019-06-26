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

    public static class TestDMetrics 
    {
        public static Metrics<T> Test<T>(this BitDContext context)
            where T : struct
        {
            var src = context.Random.ReadOnlySpan<T>(context.Samples);
            var positions = context.Random.Span<int>(context.Samples, closed(0,7));
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Test(src,positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<T> Test<T>(this BitDContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return context.Test(int8(src), positions).As<T>();
            else if(typeof(T) == typeof(byte))
                return context.Test(uint8(src),positions).As<T>();
            else if(typeof(T) == typeof(short))
                return context.Test(int16(src),positions).As<T>();
            else if(typeof(T) == typeof(ushort))
                return context.Test(uint16(src), positions).As<T>();
            else if(typeof(T) == typeof(int))
                return context.Test(int32(src), positions).As<T>();
            else if(typeof(T) == typeof(uint))
                return context.Test(uint32(src), positions).As<T>();
            else if(typeof(T) == typeof(long))
                return context.Test(int64(src), positions).As<T>();
            else if(typeof(T) == typeof(ulong))
                return context.Test(uint64(src),positions).As<T>();
            else
                throw unsupported<T>();
        }

        static Metrics<sbyte> Test(this BitDContext context, ReadOnlySpan<sbyte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<sbyte>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<sbyte>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<byte> Test(this BitDContext context, ReadOnlySpan<byte> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<byte>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<byte>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<short> Test(this BitDContext context, ReadOnlySpan<short> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<short>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<short>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<ushort> Test(this BitDContext context, ReadOnlySpan<ushort> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ushort>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<ushort>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<int> Test(this BitDContext context, ReadOnlySpan<int> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<int>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<int>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<uint> Test(this BitDContext context, ReadOnlySpan<uint> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<uint>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<uint>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<long> Test(this BitDContext context, ReadOnlySpan<long> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<long>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<long>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

        static Metrics<ulong> Test(this BitDContext context, ReadOnlySpan<ulong> src, ReadOnlySpan<int> pos)
        {
            OpId opid = Id<ulong>(OpKind.Test);            
            var dst = span<bool>(src.Length);
            var cycles = context.Cycles;            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample < dst.Length; sample++)
                dst[sample] = Bits.test(src[sample], pos[sample]);            
            var time = snapshot(sw);
            var scalars = dst.ToScalars<ulong>();
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }
    }

}
