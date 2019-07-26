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


        static Span128<T> MulBench<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<S> rhs, Span128<T> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                int32(lhs).Mul(int32(rhs), int64(dst));
            else if(typeof(S) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs), uint64(dst));
            else if(typeof(S) == typeof(float))
                float32(lhs).Mul(float32(rhs), float32(dst));
            else if(typeof(S) == typeof(double))
                float64(rhs).Mul(float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        public static Metrics<T> Mul<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {


            var opid = context.Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                MulBench(lhs,rhs, dst);
            return context.CaptureMetrics(opid, snapshot(sw), dst);
        }


        public static Metrics<T> Div<T>(this InXGContext128 context, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            
            static Span128<T> Div(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            {
                if(typeof(T) == typeof(float))
                    return generic<T>(float32(lhs).Div(float32(rhs), float32(dst)));
                else if(typeof(T) == typeof(double))
                    return generic<T>(float64(lhs).Div(float64(rhs), float64(dst)));
                else                
                    throw unsupported<T>();
            }
        
            
            var opid = context.Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < context.Cycles; cycle++)
                Div(lhs, rhs, dst);
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