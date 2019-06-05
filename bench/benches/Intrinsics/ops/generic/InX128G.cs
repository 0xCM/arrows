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

    public static class InX128GOps
    {
        public static Metrics<T> Add<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.add(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.mul(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.div(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

       public static Metrics<T> And<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.and(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

       public static Metrics<T> Or<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.or(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginx.xor(lhs, rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}