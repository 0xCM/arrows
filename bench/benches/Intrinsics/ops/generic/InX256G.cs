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
    using static InXGMetrics256;
    using static Span256;

    public static class InX256GOps
    {
        public static Metrics<T> AddAtomic<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
            for(var block = 0; block < dst.BlockCount; block++)
                Vec256.store(ginx.add(Vec256.load(lhs, block), Vec256.load(rhs, block)), ref dst.Block(block));
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

        public static Metrics<T> Add<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginxs.Add(lhs, rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

        public static Metrics<T> Sub<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginxs.Sub(lhs, rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

        public static Metrics<T> Mul<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginxs.Mul(lhs, rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

        public static Metrics<T> Div<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                ginxs.Div(lhs, rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

        public static Metrics<T> And<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.And(rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

       public static Metrics<T> Or<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var opid = Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.Or(rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
        }

      public static Metrics<T> XOr<T>(this InXGContext256 context, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
      {
            var opid = Id<T>(OpKind.XOr);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                lhs.XOr(rhs, dst);
            return context.CaptureMetrics(opid,snapshot(sw), dst);
      }

    }
}