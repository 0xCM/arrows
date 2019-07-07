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
    
    using static BenchRunner;

    public static class VecGBench    
    {           
        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = items(
                OpKind.Add, OpKind.Sub, OpKind.Mul, 
                OpKind.Div, OpKind.Mod, 
                OpKind.And, OpKind.Or, OpKind.XOr, OpKind.Flip);
            var prims = PrimalKinds.IntList;
            var optypes =from o in ops from p in prims select OpType.Define(o,p);
            var context = MetricConfig.Define(MetricKind.VecG, runs: Pow2.T04, cycles: Pow2.T13, samples: Pow2.T12).VecGContext();
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in optypes)
            {
                var comparison =  context.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }

            return comparisons;
        }

        public static MetricComparisonRecord RunComparison(this VecGContext config, OpType op, bool silent = false)
        {
            var m1 = config.ToPrimalD().Run(op.Op, op.Primitive);
            var m2 = config.Run(op.Op, op.Primitive);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }        


        public static IMetrics Run(this VecGContext context, OpKind op, PrimalKind prim)
        {
            switch(prim)
            {
                case PrimalKind.int8:
                    return context.Run<sbyte>(op);
                case PrimalKind.uint8:
                    return context.Run<byte>(op);
                case PrimalKind.int16:
                    return context.Run<short>(op);
                case PrimalKind.uint16:
                    return context.Run<ushort>(op);
                case PrimalKind.int32:
                    return context.Run<int>(op);
                case PrimalKind.uint32:
                    return context.Run<uint>(op);
                case PrimalKind.int64:
                    return context.Run<long>(op);
                case PrimalKind.uint64:
                    return context.Run<ulong>(op);
                case PrimalKind.float32:
                    return context.Run<float>(op);
                case PrimalKind.float64:                    
                    return context.Run<double>(op);
                default:
                    throw unsupported(prim);
            }
        }

        static Metrics<T> Run<T>(this VecGContext context, OpKind op)        
            where T : struct
        {
            var random = context.Random;
            var lhs = random.ReadOnlySpan<T>(context.Samples);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan<T>(context.Samples) 
                : random.ReadOnlySpan<T>(context.Samples);
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<context.Runs; i++)
            {
                if(op.Arity() == OpArity.Binary)
                    metrics += context.Run<T>(op, lhs, rhs);
                else if(op.Arity() == OpArity.Unary)
                    metrics += context.Run(op, lhs);
                else 
                    error($"No arity defined for {op} operator!");
            }
                
            return metrics;            
        }

        public static Metrics<T> Run<T>(this VecGContext context, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = context.Abs<T>(src);   
                    break;
                case OpKind.Negate:
                    metrics = context.Negate<T>(src);   
                    break;
                case OpKind.Flip:
                    metrics = context.Flip<T>(src);   
                    break;
                default: 
                    throw unsupported(op);
            }
            print(metrics.Describe());

            return metrics;
        }

        static Metrics<T> Run<T>(this VecGContext context, OpKind op, ReadOnlySpan<T> lhs,  ReadOnlySpan<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = context.Add<T>(lhs, rhs);   
                    break;
                case OpKind.Sub:
                    metrics = context.Sub<T>(lhs, rhs);   
                    break;                
                case OpKind.Mul:
                    metrics = context.Mul<T>(lhs, rhs);   
                    break;                
                case OpKind.Div:
                    metrics = context.Div<T>(lhs, rhs);   
                    break;                
                case OpKind.Mod:
                    metrics = context.Mod<T>(lhs, rhs);   
                    break;                
                case OpKind.And:
                    metrics = context.And<T>(lhs, rhs);   
                    break;                
                case OpKind.Or:
                    metrics = context.Or<T>(lhs, rhs);   
                    break;                
                case OpKind.XOr:
                    metrics = context.XOr<T>(lhs, rhs);   
                    break;                

            }

            return metrics;
        }


    }

}
