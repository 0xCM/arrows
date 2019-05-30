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

    public static class MulInX256D
    {
        public static Metrics<T> MulD<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct        
                => Mul(lhs,rhs,config);

        static Metrics<T> Mul<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXConfig256 config = null)
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

        static Metrics<float> Mul(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXConfig256 config = null)
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

        static Metrics<double> Mul(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXConfig256 config = null)
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