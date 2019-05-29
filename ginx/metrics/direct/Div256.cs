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
    using static InX256DMetrics;

    public static class DivInX256D
    {
        public static Metrics<T> Div<T>(this InXMetricConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                =>  Div(lhs,rhs,config);

        public static Metrics<T> Div<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            config = Configure(config);
            if(typeof(T) == typeof(float))
                return Div(float32(lhs), float32(rhs), config).As<T>();
            else if(typeof(T) == typeof(double))
                return Div(float64(lhs), float64(rhs), config).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<float> Div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXMetricConfig256 config)
        {
            var opid = Id<float>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> Div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXMetricConfig256 config)
        {
            var opid = Id<double>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }
    }
}