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
    using static VecGMetrics;

    public static class VecGOps
    {
        public static Metrics<T> Add<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 + v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Sub);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 - v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mul);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 * v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Div);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 / v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Mod<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Mod);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 % v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> And<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.And);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 & v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Or<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Or);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 | v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> XOr<T>(this VecGContext context, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var opid =  Id<T>(OpKind.XOr);
            var v1 = VecG.load(lhs);
            var v2 = VecG.load(rhs);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v1 ^ v2;                   
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Flip<T>(this VecGContext context, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Flip);
            var v = VecG.load(src);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = ~ v;
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Negate<T>(this VecGContext context, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var v = VecG.load(src);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = - v;
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

        public static Metrics<T> Abs<T>(this VecGContext context, ReadOnlySpan<T> src)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Abs);
            var v = VecG.load(src);
            Span<T> dst = default;
            var sw = stopwatch();
            for(var cycle = 1; cycle <= context.Cycles; cycle++)
                dst = v.Abs();
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }

    }

}