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

    public static class PrimalGBench
    {
        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.OpId<T>(NumericKind.Native, generic:true);


        const MetricKind Metric = MetricKind.PrimalG;

        static int Cycles(MetricConfig config)
            => Metric.Configure(config).Cycles;

        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);


        public static Metrics<T> Run<T>(OpKind op, MetricConfig config = null, IRandomizer random = null)        
            where T : struct
        {
            config = Metric.Configure(config);    
            random = Random(random);
            var lhs = random.Span<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan<T>(config.Samples) : random.Span<T>(config.Samples);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Run<T>(op, lhs, rhs, config);
            return metrics;            
        }


        public static IMetrics Run(OpKind op, PrimalKind prim, MetricConfig config = null, IRandomizer random = null)
        {
            config = Metric.Configure(config);    
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

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Flip:
                    metrics = FlipGMetrics.Flip<T>(src, config);   
                    break;
                case OpKind.Abs:
                    metrics = AbsGMetrics.Abs<T>(src, config);   
                    break;
                case OpKind.Negate:
                    metrics = Negate<T>(src, config);   
                    break;
                case OpKind.Inc:
                    metrics = Inc<T>(src, config);   
                    break;
                case OpKind.Dec:
                    metrics = Dec<T>(src, config);   
                    break;
                case OpKind.Min:
                    metrics = Min<T>(src, config);   
                    break;
                case OpKind.Max:
                    metrics = Max<T>(src, config);   
                    break;
                case OpKind.Square:
                    metrics = Square<T>(src, config);   
                    break;
                case OpKind.Sqrt:
                    metrics = SqrtGMetrics.Sqrt<T>(src, config);   
                    break;
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }
            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = AddGMetrics.Add<T>(lhs, rhs, config);   
                    break;
                case OpKind.Sub:
                    metrics = SubGMetrics.Sub<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Mul:
                    metrics = MulGMetrics.Mul<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Div:
                    metrics = DivGMetrics.Div<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Mod:
                    metrics = ModGMetrics.Mod<T>(lhs, rhs, config);   
                    break;                
                case OpKind.And:
                    metrics = AndGMetrics.And<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Or:
                    metrics = OrGMetrics.Or<T>(lhs, rhs, config);   
                    break;                
                case OpKind.XOr:
                    metrics = XOrGMetrics.XOr<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Eq:
                    metrics = EqGMetrics.Eq<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Lt:
                    metrics = LtGMetrics.Lt<T>(lhs, rhs, config);   
                    break;                
                case OpKind.LtEq:
                    metrics = LtEqGMetrics.LtEq<T>(lhs, rhs, config);   
                    break;                
                case OpKind.Gt:
                    metrics = GtGMetrics.Gt<T>(lhs, rhs, config);   
                    break;                
                case OpKind.GtEq:
                    metrics = GtEqGMetrics.GtEq<T>(lhs, rhs, config);   
                    break;                
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Negate<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Negate);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.negate(src[sample]);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Inc<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Inc);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.inc(src[sample]);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Dec<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Dec);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.dec(src[sample]);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

 

        public static Metrics<T> Square<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Square);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.square(src[sample]);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Max<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Max);
            var dst = alloc<T>(1);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.max(src);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Min<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Min);
            var dst = alloc<T>(1);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[0] = gmath.min(src);
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        public static Metrics<T> Parse<T>(ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Parse);
            var dst = alloc<T>(src.Length);
            var cycles = Cycles(config);

            var sw = stopwatch();
            for(var cycle = 1; cycle <= cycles; cycle++)
            for(var sample = 0; sample < dst.Length; sample++)
                dst[sample] = gmath.parse<T>(src[sample].ToString());
            var time = snapshot(sw);
            
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
    }
}