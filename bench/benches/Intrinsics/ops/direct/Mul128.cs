//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;

    public static class MulInX128D
    {
        public static Metrics<T> Mul<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {

                case PrimalKind.float32:
                    return context.Mul(float32(lhs), float32(rhs)).As<T>();
                case PrimalKind.float64:                    
                    return context.Mul(float64(lhs), float64(rhs)).As<T>();
                default:
                    throw unsupported(kind);
            }
        }

        static Metrics<float> Mul(this InXDContext128 context, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.mul(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Mul(this InXDContext128 context, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.mul(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}