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

    public static class DivInX128D
    {

        public static Metrics<T> Div<T>(this InXDConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
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

        public static Metrics<float> Div(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXDConfig128 config = null)
        {
            var opid = Id<float>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<double> Div(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXDConfig128 config = null)
        {
            var opid = Id<double>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
    }
}