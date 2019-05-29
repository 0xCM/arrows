//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Measure
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static InXMetrics;
    using static InX256DMetrics;

    public static class DivInX256D
    {
        public static Metrics<T> Div<T>(this InXMetricConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                =>  Div(lhs,rhs,config);

        public static Metrics<T> Div<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<float> Div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }

        public static Metrics<double> Div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXMetricConfig256 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return Capture(opid, config, time, dst);
        }
    }
}