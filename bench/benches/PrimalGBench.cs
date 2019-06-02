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


    using static BenchTools;
    using static zfunc;

    public static class PrimalGBench
    {
        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, PrimalGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(op, prim, Random(random));

        public static MetricComparisonRecord RunComparison(this PrimalGConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalD.Measure(op.Op, op.Primitive, config.ToDirect());
            var m2 = MetricKind.PrimalG.Measure(op.Op, op.Primitive, config);            
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = items(OpKind.Sub, OpKind.Mul, OpKind.Add, OpKind.GtEq, OpKind.LtEq, OpKind.Eq);
            var prims = items(PrimalKinds.All);
            var optypes = from o in ops from p in prims select OpType.Define(o,p);            
            var config = PrimalGConfig.Define(MetricKind.PrimalG, runs: Pow2.T03, cycles: Pow2.T12, samples: Pow2.T11);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;

        }

        static IMetrics Run(this PrimalGConfig config, OpKind op, PrimalKind prim, IRandomizer random)
        {
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
                    throw unsupported(op, prim);
            }
        }

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, IRandomizer random)        
            where T : struct
        {
            var metrics = Metrics<T>.Zero;

            var lhs = random.ReadOnlySpan<T>(config.Samples);
            var rhs = op.NonZeroRight() 
                ? random.NonZeroSpan<T>(config.Samples) 
                : random.ReadOnlySpan<T>(config.Samples);
            var moves = op.IsBitMovement() 
                ? random.ReadOnlySpan<int>(config.Samples, closed(0, SizeOf<T>.BitSize)) 
                : ReadOnlySpan<int>.Empty;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
            {                
                if(op.IsBitMovement())
                    config.Run(op, lhs, moves);
                else if(op.Arity() == OpArity.Binary)
                    metrics += config.Run<T>(op, lhs, rhs);
                else if(op.Arity() == OpArity.Unary)
                    metrics += config.Run(op, lhs);
                else 
                    error($"No arity defined for {op} operator!");
            }
            return metrics;            
        }


        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Flip:
                    metrics = config.Flip(src);   
                    break;
                case OpKind.Abs:
                    metrics = config.Abs(src);   
                    break;
                case OpKind.Negate:
                    metrics = config.Negate(src);   
                    break;
                case OpKind.Inc:
                    metrics = config.Inc(src);   
                    break;
                case OpKind.Dec:
                    metrics = config.Dec(src);   
                    break;
                case OpKind.Min:
                    metrics = config.Min(src);   
                    break;
                case OpKind.Max:
                    metrics = config.Max(src);   
                    break;
                case OpKind.Square:
                    metrics = config.Square(src);   
                    break;
                case OpKind.Sqrt:
                    metrics = config.Sqrt(src);   
                    break;
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }
            print(metrics.Describe());

            return metrics;
        }

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
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
                case OpKind.Mod:
                    metrics = config.Mod(lhs, rhs);   
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
                case OpKind.Eq:
                    metrics = config.Eq(lhs, rhs);   
                    break;                
                case OpKind.Lt:
                    metrics = config.Lt(lhs, rhs);   
                    break;                
                case OpKind.LtEq:
                    metrics = config.LtEq(lhs, rhs);   
                    break;                
                case OpKind.Gt:
                    metrics = config.Gt(lhs, rhs);   
                    break;                
                case OpKind.GtEq:
                    metrics = config.GtEq(lhs, rhs);   
                    break;                
                default: 
                    throw unsupported(op, PrimalKinds.kind<T>());
            }            

            print(metrics.Describe());

            return metrics;
        }

        static Metrics<T> Run<T>(this PrimalGConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.ShiftL:
                    metrics = config.ShiftL(lhs,rhs);   
                break;
                case OpKind.ShiftR:
                    metrics = config.ShiftR(lhs,rhs);   
                break;
                case OpKind.RotL:
                    metrics = config.RotL(lhs,rhs);   
                break;
                case OpKind.RotR:
                    metrics = config.RotR(lhs,rhs);   
                break;
                default: 
                    throw unsupported(op);
            }
            return metrics;
        }

   }
}