//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static mfunc;
    using static As;
    using static InXMetrics;

    partial class InXDirectNum
    {
        public static Metrics<T> Sqrt<T>(ReadOnlySpan128<T> src, InXMetricConfig128 config = null)
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

        public static Metrics<float> Sqrt(ReadOnlySpan128<float> src, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Sqrt, config);            
            var dst = alloc(src);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinx.load(src[i], out Num128<float> x);
                    dst[i] = dinx.sqrt(ref x);
                }
                
            }
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<double> Sqrt(ReadOnlySpan128<double> src, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Sqrt, config);            
            var dst = alloc(src);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinx.load(src[i], out Num128<double> x);
                    dst[i] = dinx.sqrt(ref x);
                }
                
            }
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        } 
    }

}
