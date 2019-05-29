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
    using static InXMetrics;
    using static InX256GMetrics;

    public static class InX256GOps
    {

        public static Metrics<T> Run<T>(OpKind op, InXMetricConfig256 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Blocks) : random.Span256<T>(config.Blocks);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }


        public static IMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig256 config, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return Run<sbyte>(op, config, random);
                case PrimalKind.uint8:
                    return Run<byte>(op, config, random);
                case PrimalKind.int16:
                    return Run<short>(op, config, random);
                case PrimalKind.uint16:
                    return Run<ushort>(op, config, random);
                case PrimalKind.int32:
                    return Run<int>(op, config, random);
                case PrimalKind.uint32:
                    return Run<uint>(op, config, random);
                case PrimalKind.int64:
                    return Run<long>(op, config, random);
                case PrimalKind.uint64:
                    return Run<ulong>(op, config, random);
                case PrimalKind.float32:
                    return Run<float>(op, config, random);
                case PrimalKind.float64:                    
                    return Run<double>(op, config, random);
                default:
                    throw unsupported(op, prim);
            }
        }




        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<T> Add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            config = Configure(config);
            var opid = Id<T>(OpKind.Add);            
            var dst = alloc(lhs,rhs);

            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
            for(var block = 0; block < dst.BlockCount; block++)
            {
                var x = Vec256.single<T>(lhs, block);
                var y = Vec256.single<T>(rhs, block);
                Vec256.store(ginx.add(x,y), ref dst.Block(block));
            }
            var time = snapshot(sw);

            return opid.CaptureMetrics(config, time, dst);
        }

        public static Metrics<T> Sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<T> Mul<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<T> Div<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

        public static Metrics<T> And<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

       public static Metrics<T> Or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
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

      public static Metrics<T> XOr<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            config = Configure(config);
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