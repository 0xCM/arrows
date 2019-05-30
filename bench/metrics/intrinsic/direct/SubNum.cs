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
    using static InX128NumGMetrics;

    public static class SubInXNumD
    {
        public static Metrics<T> SubND<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.float32:
                    return Sub(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Sub(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }


        static Metrics<float> Sub(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<float>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(lhs[i], out Num128<float> x);
                    dinxs.load(rhs[i], out Num128<float> y);
                    dst[i] = dinxs.sub(ref x, y);
                }                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> Sub(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXConfig128 config = null)
        {
            config = Configure(config);
            var opid = Id<double>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(lhs[i], out Num128<double> x);
                    dinxs.load(rhs[i], out Num128<double> y);
                    dst[i] = dinxs.sub(ref x, y);
                }                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        } 
    }

}
