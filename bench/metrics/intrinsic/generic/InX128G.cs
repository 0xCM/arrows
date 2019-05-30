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
    using static InX128GMetrics;

    public static class InX128GOps
    {
        public static Metrics<T> Run<T>(InXConfig128 config, OpKind op, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan128<T>(config.Blocks) : random.Span128<T>(config.Blocks);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += RunG<T>(config, op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics RunG(this InXConfig128 config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return Run<sbyte>(config, op, random);
                case PrimalKind.uint8:
                    return Run<byte>(config, op, random);
                case PrimalKind.int16:
                    return Run<short>(config, op, random);
                case PrimalKind.uint16:
                    return Run<ushort>(config, op, random);
                case PrimalKind.int32:
                    return Run<int>(config, op, random);
                case PrimalKind.uint32:
                    return Run<uint>(config, op, random);
                case PrimalKind.int64:
                    return Run<long>(config, op, random);
                case PrimalKind.uint64:
                    return Run<ulong>(config, op, random);
                case PrimalKind.float32:
                    return Run<float>(config, op, random);
                case PrimalKind.float64:                    
                    return Run<double>(config, op, random);
                default:
                    throw unsupported(op, prim);
            }
        }
 
        public static Metrics<T> RunG<T>(this InXConfig128 config, OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.AddG(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.SubG(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.MulG(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.DivG(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.AndG(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.OrG(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOrG(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> AddG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.add(lhs, rhs, ref dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> SubG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Sub);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.sub(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> MulG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Mul);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.mul(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> DivG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Div);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.div(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

       public static Metrics<T> AndG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.And);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.and(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

       public static Metrics<T> OrG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Or);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                ginx.or(lhs, rhs, dst);
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

      public static Metrics<T> XOrG<T>(this InXConfig128 config, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
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