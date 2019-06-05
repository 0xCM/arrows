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
    using static InXDMetrics256;

    public static class MulInX256D
    {
        public static Metrics<T> Mul<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return context.Mul(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Mul(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported(PrimalKinds.kind<T>());            
        }

        static Metrics<float> Mul(this InXDContext256 context, ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.mul(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Mul(this InXDContext256 context, ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.mul(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }
}