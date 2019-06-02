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
        public static Metrics<T> SqrtND<T>(this InXConfig128 config, ReadOnlySpan128<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.float32:
                    return Sqrt(float32(src), config).As<T>();
                case PrimalKind.float64:                    
                    return Sqrt(float64(src), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<float> Sqrt(ReadOnlySpan128<float> src, InXConfig128 config)
        {
            var opid = Id<float>(OpKind.Sqrt);            
            var dst = alloc(src);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(src[i], out Num128<float> x);
                    dst[i] = dinxs.sqrt(ref x);
                }
                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<double> Sqrt(ReadOnlySpan128<double> src, InXConfig128 config = null)
        {
            var opid = Id<double>(OpKind.Sqrt);            
            var dst = alloc(src);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(src[i], out Num128<double> x);
                    dst[i] = dinxs.sqrt(ref x);
                }
                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        } 
    }

}