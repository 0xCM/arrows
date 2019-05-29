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
    using Z0.Metrics;
    
    using static zfunc;
    using static As;
    
    
    public static class InXBench
    {
        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        static InXMetricConfig128 Configure(InXMetricConfig128 config)
            => config ?? InXMetricConfig128.Default;

        static InXMetricConfig256 Configure(InXMetricConfig256 config)
            => config ?? InXMetricConfig256.Default;

        public static Metrics<T> Run<T>(OpKind op, InXMetricConfig128 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan128<T>(config.Blocks) : random.Span128<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += Apply<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static Metrics<T> Run<T>(OpKind op, InXMetricConfig256 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Configure(config);            
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Blocks) : random.Span256<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i < config.Runs; i++)
                metrics += Apply<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static IMetrics Run(OpKind op, PrimalKind prim, InXMetricConfig128 config, IRandomizer random = null)
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

      public static Metrics<T> Apply<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXMetricConfig128 config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Configure(config);

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
                    metrics = config.Div(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr<T>(lhs, rhs);   
                break;
                case OpKind.Max:
                    metrics = config.Max<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> Apply<T>(OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXMetricConfig256 config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Configure(config);

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
                    metrics = config.Div(lhs, rhs);   
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