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
    using static InXDMetrics128;

    public static class MulInX128D
    {
        public static Metrics<T> Mul<T>(this InXDConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {

                case PrimalKind.float32:
                    return config.Mul(float32(lhs), float32(rhs)).As<T>();
                case PrimalKind.float64:                    
                    return config.Mul(float64(lhs), float64(rhs)).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<float> Mul(this InXDConfig128 config, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.mul(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }

        static Metrics<double> Mul(this InXDConfig128 config, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = Id<double>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.mul(lhs, rhs, dst);
            return opid.CaptureMetrics(config, snapshot(sw), dst);
        }
    }
}