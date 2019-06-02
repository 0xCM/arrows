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
    using static InXGMetrics128;

    public static class InX128GOps
    {

        public static Metrics<T> Add<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.add(lhs, rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> Sub<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.sub(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> Mul<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.mul(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> Div<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.div(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

       public static Metrics<T> And<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

       public static Metrics<T> Or<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

      public static Metrics<T> XOr<T>(this InXGConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.xor(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }
    }
}