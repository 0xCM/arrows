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

    public static class AddInXNumD
    {
        public static Metrics<T> AddScalar<T>(this InXDConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.float32:
                    return Add(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Add(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<float> Add(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, InXDConfig128 config = null)
        {
            var opid = Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(lhs[i], out Num128<float> x);
                    dinxs.load(rhs[i], out Num128<float> y);
                    dst[i] = dinxs.add(ref x, y);
                }
                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        static Metrics<double> Add(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, InXDConfig128 config = null)
        {
            var opid = Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            {
                for(var i = 0; i < dst.Length; i++)
                {
                    dinxs.load(lhs[i], out Num128<double> x);
                    dinxs.load(rhs[i], out Num128<double> y);
                    dst[i] = dinxs.add(ref x, y);
                }
                
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        } 
    }

}
