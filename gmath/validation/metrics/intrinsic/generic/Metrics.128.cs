//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static mfunc;
    using static As;
    using static InXMetrics;

    partial class IntrinsicGeneric
    {

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Configure(config);

            switch(op)
            {
                case OpKind.Add:
                    metrics = Add<T>(lhs, rhs, config);   
                break;
                case OpKind.Sub:
                    metrics = Sub<T>(lhs, rhs, config);   
                break;
                case OpKind.Mul:
                    metrics = Mul<T>(lhs, rhs, config);   
                break;
                case OpKind.Div:
                    metrics = Div<T>(lhs, rhs, config);   
                break;
                case OpKind.And:
                    metrics = And<T>(lhs, rhs, config);   
                break;
                case OpKind.Or:
                    metrics = Or<T>(lhs, rhs, config);   
                break;
                case OpKind.XOr:
                    metrics = XOr<T>(lhs, rhs, config);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Add, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.add(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<T> Sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Sub, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.sub(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<T> Mul<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Mul, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.mul(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

        public static Metrics<T> Div<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Div, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.div(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

       public static Metrics<T> And<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.And, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

       public static Metrics<T> Or<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Or, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

      public static Metrics<T> XOr<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.XOr, config);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.xor(lhs, rhs, dst);
            var time = snapshot(sw);

            return metrics(opid, config, time, dst);
        }

    }

}