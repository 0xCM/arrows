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
    using static Bench;
    
    public static class PrimalDBench
    {        
        const MetricKind Metric = MetricKind.PrimalD;

        public static IMetrics Run(this PrimalDConfig config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return config.Run<sbyte>(op, random);
                case PrimalKind.uint8:
                    return config.Run<byte>(op, random);
                case PrimalKind.int16:
                    return config.Run<short>(op, random);
                case PrimalKind.uint16:
                    return config.Run<ushort>(op, random);
                case PrimalKind.int32:
                    return config.Run<int>(op, random);
                case PrimalKind.uint32:
                    return config.Run<uint>(op, random);
                case PrimalKind.int64:
                    return config.Run<long>(op, random);
                case PrimalKind.uint64:
                    return config.Run<ulong>(op, random);
                case PrimalKind.float32:
                    return config.Run<float>(op, random);
                case PrimalKind.float64:                    
                    return config.Run<double>(op, random);
                default:
                    throw unsupported(prim);
            }
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, IRandomizer random)        
            where T : struct
        {
            var lhs = random.Span<T>(config.Samples);
            var rhs = op.NonZeroRight() ? random.NonZeroSpan<T>(config.Samples) : random.Span<T>(config.Samples);
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Run<T>(op, lhs, rhs);
            return metrics;            
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add<T>(lhs,rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub<T>(lhs,rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul<T>(lhs,rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div<T>(lhs,rhs);   
                break;
                case OpKind.Mod:
                    metrics = config.Mod<T>(lhs, rhs);   
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
                case OpKind.Eq:
                    metrics = config.Eq<T>(lhs, rhs);   
                break;
                case OpKind.Gt:
                    metrics = config.Gt<T>(lhs, rhs);   
                break;
                case OpKind.GtEq:
                    metrics = config.GtEq<T>(lhs, rhs);   
                break;
                case OpKind.Lt:
                    metrics = config.Lt<T>(lhs, rhs);   
                break;
                case OpKind.LtEq:
                    metrics = config.LtEq<T>(lhs, rhs);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());
            return metrics;
        }

        static Metrics<T> Run<T>(PrimalDConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            config = Metric.Configure(config);
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = config.Abs<T>(src);   
                break;
                case OpKind.Negate:
                    metrics = config.Negate<T>(src);   
                break;
                case OpKind.Flip:
                    metrics = config.Flip<T>(src);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }
    }

}