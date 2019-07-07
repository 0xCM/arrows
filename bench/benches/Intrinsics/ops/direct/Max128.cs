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

    public static class MaxInX128D
    {
        public static Metrics<T> Max<T>(this InXDContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return  context.Max(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return  context.Max(int32(lhs), int32(rhs)).As<T>();
            else
                throw unsupported<T>();
        }

        static Metrics<int> Max(this InXDContext128 context, ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs )
        {
            var opid = context.Id<int>(OpKind.Max);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block <  dst.BlockCount; block++)
                    Vec128.store(dinx.max(lhs.LoadVec128(block), rhs.LoadVec128(block)), dst, block);            
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        static Metrics<short> Max(this InXDContext128 context, ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs)
        {
            var opid = context.Id<short>(OpKind.Max);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block <  dst.BlockCount; block++)
                    Vec128.store(dinx.max(lhs.LoadVec128(block), rhs.LoadVec128(block)), dst, block);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}