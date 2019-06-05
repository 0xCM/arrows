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

    public static class DivInX256D
    {
        public static Metrics<T> Div<T>(this InXDContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return Div(float32(lhs), float32(rhs), context).As<T>();
            else if(typeof(T) == typeof(double))
                return Div(float64(lhs), float64(rhs), context).As<T>();
            else
                throw unsupported(PrimalKinds.kind<T>());
        }

        static Metrics<float> Div(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXDContext256 context)
        {
            var opid = context.Id<float>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);            
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Div(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXDContext256 context)
        {
            var opid = context.Id<double>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                dinx.div(lhs, rhs, dst);            
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}