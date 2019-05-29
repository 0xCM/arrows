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

    public static class PrimalDBench
    {        
        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        const MetricKind Metric = MetricKind.PrimalD;

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
                metrics += Run<T>(op, lhs,rhs,config);
            return metrics;            
        }

        public static IMetrics Run(OpKind op, PrimalKind prim,  MetricConfig config = null, IRandomizer random = null)
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
                    throw unsupported(prim);
            }
        }

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, MetricConfig config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Metric.Configure(config);
            switch(op)
            {
                case OpKind.Add:
                    metrics = AddDMetrics.Add<T>(lhs,rhs, config);   
                break;
                case OpKind.Sub:
                    metrics = SubDMetrics.Sub<T>(lhs,rhs, config);   
                break;
                case OpKind.Mul:
                    metrics = MulDMetrics.Mul<T>(lhs,rhs, config);   
                break;
                case OpKind.Div:
                    metrics = DivDMetrics.Div<T>(lhs,rhs, config);   
                break;
                case OpKind.Mod:
                    metrics = ModDMetrics.Mod<T>(lhs, rhs, config);   
                break;
                case OpKind.And:
                    metrics = AndDMetrics.And<T>(lhs, rhs, config);   
                break;
                case OpKind.Or:
                    metrics = OrDMetrics.Or<T>(lhs, rhs, config);   
                break;
                case OpKind.XOr:
                    metrics = XOrDMetrics.XOr<T>(lhs, rhs, config);   
                break;
                case OpKind.Eq:
                    metrics = EqDMetrics.Eq<T>(lhs, rhs, config);   
                break;
                case OpKind.Gt:
                    metrics = GtDMetrics.Gt<T>(lhs, rhs, config);   
                break;
                case OpKind.GtEq:
                    metrics = GtEqDMetrics.GtEq<T>(lhs, rhs, config);   
                break;
                case OpKind.Lt:
                    metrics = LtDMetrics.Lt<T>(lhs, rhs, config);   
                break;
                case OpKind.LtEq:
                    metrics = LtEqDMetrics.LtEq<T>(lhs, rhs, config);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Run<T>(OpKind op, ReadOnlySpan<T> src, MetricConfig config = null)
            where T : struct
        {
            config = Metric.Configure(config);
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = AbsDMetrics.Abs<T>(src, config);   
                break;
                case OpKind.Negate:
                    metrics = NegateDMetrics.Negate<T>(src, config);   
                break;
                case OpKind.Flip:
                    metrics = FlipDMetrics.Flip<T>(src, config);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }
    }

}