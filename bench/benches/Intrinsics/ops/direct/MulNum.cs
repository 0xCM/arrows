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

    public static class MulInXNumD
    {
        public static Metrics<T> Mul<T>(this InXNumDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return context.Mul(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Mul(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported<T>();

        }

        static Metrics<float> Mul(this InXNumDContext128 context, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.mul(lhs.ToScalar128(block), rhs.ToScalar128(block));                
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Mul(this InXNumDContext128 context, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dst[block] = dinx.mul(lhs.ToScalar128(block), rhs.ToScalar128(block));                
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }

}
