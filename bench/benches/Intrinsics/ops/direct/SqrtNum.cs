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
    using static InXNumGMetrics128;

    public static class SqrtInXNumD
    {
        public static Metrics<T> Sqrt<T>(this InXNumDContext128 context, ReadOnlySpan128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return context.Sqrt(float32(src)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Sqrt(float64(src)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<float> Sqrt(this InXNumDContext128 context, ReadOnlySpan128<float> src)
        {
            var opid = context.Id<float>(OpKind.Sqrt);            
            var dst = alloc(src);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.sqrt(src.Scalar(block));
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<double> Sqrt(this InXNumDContext128 context, ReadOnlySpan128<double> src)
        {
            var opid = context.Id<double>(OpKind.Sqrt);            
            var dst = alloc(src);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.sqrt(src.Scalar(block));
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }

}
