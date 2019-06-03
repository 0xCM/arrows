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
    using static InXNumGMetrics128;

    public static class SqrtInXNumD
    {
        public static Metrics<T> Sqrt<T>(this InXNumDConfig128 config, ReadOnlySpan128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return config.Sqrt(float32(src)).As<T>();
            else if (typeof(T) == typeof(double))
                return config.Sqrt(float64(src)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<float> Sqrt(this InXNumDConfig128 config, ReadOnlySpan128<float> src)
        {
            var opid = Id<float>(OpKind.Sqrt);            
            var dst = alloc(src);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.sqrt(src.Scalar(block));
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        public static Metrics<double> Sqrt(this InXNumDConfig128 config, ReadOnlySpan128<double> src)
        {
            var opid = Id<double>(OpKind.Sqrt);            
            var dst = alloc(src);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.sqrt(src.Scalar(block));
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        } 
    }

}
