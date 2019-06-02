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
    using static BenchTools;

    public static class NumGBench
    {            
        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, NumGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(op, prim, Random(random));

        public static MetricComparisonRecord RunComparison(this NumGConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalD.Measure(op.Op, op.Primitive, config.ToPrimalD());
            var m2 = MetricKind.NumG.Measure(op.Op, op.Primitive, config);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }


        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = items(OpKind.Add, OpKind.Mul, OpKind.Sub);
            var prims = items(PrimalKind.float32, PrimalKind.float64, PrimalKind.int64);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = NumGConfig.Define(MetricKind.NumG,runs: Pow2.T03, cycles: Pow2.T13, samples: Pow2.T11);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;            
        }

        const MetricKind Metric = MetricKind.NumG;

        public static IMetrics Run(this NumGConfig config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            config = Metric.Configure(config);    
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

       public static Metrics<T> Run<T>(this NumGConfig config, OpKind op, IRandomizer random)        
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

        public static Metrics<T> Run<T>(this NumGConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
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

        public static Metrics<T> Run<T>(this NumGConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
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
                case OpKind.Lt:
                    metrics = config.Lt<T>(lhs, rhs);   
                    break;                
                case OpKind.LtEq:
                    metrics = config.LtEq<T>(lhs, rhs);   
                    break;                
                case OpKind.Gt:
                    metrics = config.Gt<T>(lhs, rhs);   
                    break;                
                case OpKind.GtEq:
                    metrics = config.GtEq<T>(lhs, rhs );   
                    break;                
                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }
 
   }
}