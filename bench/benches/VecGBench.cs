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
    
    using static BenchRunner;

    public static class VecGBench    
    {           
        public static MetricComparisonRecord RunComparison(this VecGConfig config, OpType op, bool silent = false)
        {
            var m1 = config.ToPrimalD().Run(op.Op, op.Primitive, Random(null));
            var m2 = config.Run(op.Op, op.Primitive, Random(null));
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }        

        public static IReadOnlyList<MetricComparisonRecord> Run()
        {

            var ops = items(
                OpKind.Add, OpKind.Sub, OpKind.Mul, 
                OpKind.Div, OpKind.Mod, 
                OpKind.And, OpKind.Or, OpKind.XOr, OpKind.Flip);
            var prims = PrimalKinds.Integral;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var config = VecGConfig.Define(MetricKind.VecG, runs: Pow2.T04, cycles: Pow2.T13, samples: Pow2.T12);
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  config.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;
        }

        public static IMetrics Run(this VecGConfig config, OpKind op, PrimalKind prim, IRandomizer random = null)
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

        static Metrics<T> Run<T>(this VecGConfig config, OpKind op, IRandomizer random)        
            where T : struct
        {
            var lhs = random.ReadOnlySpan<T>(config.Samples);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan<T>(config.Samples) 
                : random.ReadOnlySpan<T>(config.Samples);
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
            {
                if(op.Arity() == OpArity.Binary)
                    metrics += config.Run<T>(op, lhs, rhs);
                else if(op.Arity() == OpArity.Unary)
                    metrics += config.Run(op, lhs);
                else 
                    error($"No arity defined for {op} operator!");
            }
                
            return metrics;            
        }

        public static Metrics<T> Run<T>(this VecGConfig config, OpKind op, ReadOnlySpan<T> src)
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

        static Metrics<T> Run<T>(this VecGConfig config, OpKind op, ReadOnlySpan<T> lhs,  ReadOnlySpan<T> rhs)
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

            }

            return metrics;
        }


    }

}
