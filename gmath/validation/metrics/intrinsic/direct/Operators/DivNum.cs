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
        public static Metrics<T> Div<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.float32:
                    return Div(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Div(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }


        public static Metrics<float> Div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Div, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinx.load(lhs[i], out Num128<float> x);
                    dinx.load(rhs[i], out Num128<float> y);
                    dst[i] = dinx.div(ref x, y);
                }
                
            }
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<double> Div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXMetricConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Div, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinx.load(lhs[i], out Num128<double> x);
                    dinx.load(rhs[i], out Num128<double> y);
                    dst[i] = dinx.div(ref x, y);
                }
                
            }
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        } 
    }

}
