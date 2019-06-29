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
                lhs.Add(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Sub(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Mul(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Div(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

       public static Metrics<T> And<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

       public static Metrics<T> Or<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = context.Id<T>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.XOr(rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }
    }
}