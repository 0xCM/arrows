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
    using static InXDMetrics256;

    public static class MulInX256D
    {
        public static Metrics<T> Mul<T>(this InXDConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

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

        static Metrics<float> Mul(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXDConfig256 config = null)
        {
            var opid = Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.mul(lhs,rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> Mul(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXDConfig256 config = null)
        {
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