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

    static class InXMetricX
    {
        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, InXConfig config, Duration WorkTime, Span128<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());

        public static Metrics<T> CaptureMetrics<T>(this OpId<T> OpId, InXConfig config, Duration WorkTime, Span256<T> results)
            where T : struct
                => new Metrics<T>(OpId, ((long)config.Cycles) * ((long)results.Length), WorkTime, results.Unblock());


       public static Metrics<T> Measure<T>(this InXDConfig128 config, OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr(lhs, rhs);   
                break;
                case OpKind.Max:
                    metrics = config.Max(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Measure<T>(this InXDConfig256 config, OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;        
        }

        public static Metrics<T> Measure<T>(this InXGConfig128 config, OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Measure<T>(this InXGConfig256 config, OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add<T>(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub<T>(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul<T>(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div<T>(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And<T>(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());
            return metrics;
        }
 
    }
}