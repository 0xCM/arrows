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
    using static BitGMetrics;

    public static class BitGOps 
    {
        public static Metrics<T> Toggle<T>(this BitGContext context)
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.Span<T>(context.Samples).ReadOnly();
            var positions = context.Random.Array<int>(context.Samples, closed(0,bitsize - 1));            
            var metrics = Metrics<T>.Zero;
                    
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Toggle(src, positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        public static Metrics<T> Enable<T>(this BitGContext context)
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.Span<T>(context.Samples).ReadOnly();
            var positions = context.Random.Array<int>(context.Samples, closed(0,bitsize - 1));            
            var metrics = Metrics<T>.Zero;
                    
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Enable(src, positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        public static Metrics<T> Disable<T>(this BitGContext context)
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.Span<T>(context.Samples).ReadOnly();
            var positions = context.Random.Array<int>(context.Samples, closed(0,bitsize - 1));            
            var metrics = Metrics<T>.Zero;
                    
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Disable(src, positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        public static Metrics<T> Pop<T>(this BitGContext context) 
            where T : struct
        {
            var src = context.Random.ReadOnlySpan<T>(context.Samples);
            var metrics = Metrics<ulong>.Zero;            
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Pop(src);
                metrics += result;
                print(result.Describe());
            }
            return metrics.As<T>();
        }

        public static Metrics<T> Test<T>(this BitGContext context) 
            where T : struct
        {
            var bitsize = SizeOf<T>.BitSize;
            var src = context.Random.Span<T>(context.Samples).ReadOnly();
            var positions = context.Random.Array<int>(context.Samples, closed(0,bitsize - 1));            
            var metrics = Metrics<T>.Zero;
                    
            for(var i=0; i<context.Runs; i++)
            {
                var result = context.Test(src, positions);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<T> Toggle<T>(this BitGContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Toggle);
            var dst = span<T>(context.Samples);
            var cycles = context.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 dst[sample] = gbits.toggle(dst[sample], positions[sample]);                        
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }
        
        static Metrics<T> Enable<T>(this BitGContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Enable);
            var dst = span<T>(context.Samples);
            src.CopyTo(dst);
            var cycles = context.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                for(var sample = 0; sample < dst.Length; sample++)
                     gbits.enable(ref dst[sample], positions[sample]);

                sw.Stop();
                src.CopyTo(dst);
                sw.Start();
            }
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<T> Disable<T>(this BitGContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Disable);
            var dst = span<T>(context.Samples);
            src.CopyTo(dst);
            var cycles = context.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            {
                for(var sample = 0; sample < dst.Length; sample++)
                     gbits.disable(ref dst[sample], positions[sample]);

                sw.Stop();
                src.CopyTo(dst);
                sw.Start();
            }
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<ulong> Pop<T>(this BitGContext context, ReadOnlySpan<T> src)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Pop);
            var dst = span<ulong>(src.Length);
            var cycles = context.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gbits.pop(src[sample]);            
            return opid.CaptureMetrics(cycles*dst.Length, snapshot(sw), dst);
        }

        static Metrics<T> Test<T>(this BitGContext context, ReadOnlySpan<T> src, ReadOnlySpan<int> positions)
            where T : struct
        {
            OpId opid =  Id<T>(OpKind.Test);
            var dst = span<bool>(context.Samples);
            var cycles = context.Cycles;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                 dst[sample] = gbits.test(src[sample], positions[sample]);                                                
            var time = snapshot(sw);
            var scalars = dst.ToScalars<T>();                 
            return opid.CaptureMetrics(cycles*dst.Length, time, scalars);
        }

    }

}