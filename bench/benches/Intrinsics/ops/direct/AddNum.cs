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

    public static class AddInXNumD
    {        
        public static Metrics<T> Add<T>(this InXNumDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return context.Add(float32(lhs), float32(rhs)).As<T>();
            else if (typeof(T) == typeof(double))
                return context.Add(float64(lhs), float64(rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        static Metrics<float> Add(this InXNumDContext128 context, ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs)
        {
            var opid = context.Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dinx.add(lhs.ToScalar128(block), rhs.ToScalar128(block), ref dst[block]);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<double> Add(this InXNumDContext128 context, ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs)
        {
            var opid = context.Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var blocks = dst.BlockCount;
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < blocks; block++)
                dinx.add(lhs.ToScalar128(block), rhs.ToScalar128(block), ref dst[block]);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        } 
    }

}
