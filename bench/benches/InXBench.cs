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
    using Z0.Metrics;
    
    using static zfunc;
    using static As;
    
    
    public static class InXBench
    {
        static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        const MetricKind Fused128D = MetricKind.InX128DFused;
        
        const MetricKind Fused128G = MetricKind.InX128GFused;

        const MetricKind Fused256D = MetricKind.InX256DFused;
        
        const MetricKind Fused256G = MetricKind.InX256GFused;

        public static Metrics<T> Run<T>(OpKind op, InXConfig128 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Fused128D.Configure(config);            
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan128<T>(config.Blocks) : random.Span128<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += ApplyD<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static Metrics<T> RunD<T>(OpKind op, InXConfig256 config = null, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            config = Fused256D.Configure(config);            
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan256<T>(config.Blocks) : random.Span256<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i < config.Runs; i++)
                metrics += ApplyD<T>(op, lhs, rhs, config);
            return metrics;            
        }

        public static IMetrics RunD(this InXConfig128 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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

        public static IMetrics RunD(this InXConfig256 config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return RunD<sbyte>(op, config, random);
                case PrimalKind.uint8:
                    return RunD<byte>(op, config, random);
                case PrimalKind.int16:
                    return RunD<short>(op, config, random);
                case PrimalKind.uint16:
                    return RunD<ushort>(op, config, random);
                case PrimalKind.int32:
                    return RunD<int>(op, config, random);
                case PrimalKind.uint32:
                    return RunD<uint>(op, config, random);
                case PrimalKind.int64:
                    return RunD<long>(op, config, random);
                case PrimalKind.uint64:
                    return RunD<ulong>(op, config, random);
                case PrimalKind.float32:
                    return RunD<float>(op, config, random);
                case PrimalKind.float64:                    
                    return RunD<double>(op, config, random);
                default:
                    throw unsupported(op, prim);
            }
        }

       static Metrics<T> ApplyD<T>(OpKind op, ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, InXConfig128 config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Fused128D.Configure(config);

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.AddD<T>(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.SubD<T>(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.MulD<T>(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.DivD(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.AndD(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.OrD<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOrD<T>(lhs, rhs);   
                break;
                case OpKind.Max:
                    metrics = config.MaxD<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;
        }

        public static Metrics<T> ApplyD<T>(OpKind op, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, InXConfig256 config = null)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            config = Fused256D.Configure(config);

            switch(op)
            {
                case OpKind.Add:
                    metrics = config.AddD<T>(lhs, rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.SubD<T>(lhs, rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.MulD<T>(lhs, rhs);   
                break;
                case OpKind.Div:
                    metrics = config.DivD(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.AndD<T>(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.OrD<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOrD<T>(lhs, rhs);   
                break;
                default: 
                    throw unsupported(op);
            }

            print(metrics.Describe());

            return metrics;        
        }
   }
}