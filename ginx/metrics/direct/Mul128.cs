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
    using static InX128DMetrics;

    public static class MulInX128D
    {
        public static Metrics<T> Mul<T>(this InXMetricConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                =>  Mul(lhs,rhs,config);

        public static Metrics<T> Mul<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            config = Configure(config);
            switch(kind)
            {

                case PrimalKind.float32:
                    return Mul(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Mul(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }

        }

        static Metrics<float> Mul(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXMetricConfig128 config)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.mul(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> Mul(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXMetricConfig128 config)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.mul(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
 

    }

}