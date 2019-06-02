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
    using static BenchTools;
    
    public static class InXBench
    {
        public static IReadOnlyList<MetricComparisonRecord> Run256Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int32, PrimalKind.int64, PrimalKind.float32, PrimalKind.float64);
            var ops = items(OpKind.And, OpKind.Add, OpKind.Sub, OpKind.XOr);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXGConfig256.Define(MetricKind.InX256GFused, runs: Pow2.T03, cycles: Pow2.T13, blocks: Pow2.T11);
            return config.RunComparisons(specs);
       }

        public static IReadOnlyList<MetricComparisonRecord> Run128Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXGConfig128.Define(MetricKind.InX128GFused, runs: Pow2.T03, cycles: Pow2.T12, blocks: Pow2.T11);
            return config.RunComparisons(specs);
       }

        public static MetricComparisonRecord RunComparison(this InXGConfig256 config, OpType op, IRandomizer random = null)
        {
            var m1 = config.ToDirect256().Run(op.Op, op.Primitive, Random(random));
            print(m1.Describe());
            var m2 = config.Run(op.Op, op.Primitive, Random(random));
            print(m2.Describe());
            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord RunComparison(this InXGConfig128 config, OpType op, IRandomizer random = null)
        {
            var m1 = config.ToDirect128().Run(op.Op, op.Primitive, Random(random));
            print(m1.Describe());
            var m2 = config.Run(op.Op, op.Primitive, Random(random));
            print(m2.Describe());        
            return m1.Compare(m2).ToRecord();
        }

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXGConfig128 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in ops.Select(op => config.RunComparison(op)))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       }

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXGConfig256 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in ops.Select(op => config.RunComparison(op)))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       } 


        public static Metrics<T> Run<T>(this InXDConfig128 config, OpKind op, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() 
                ? random.NonZeroSpan128<T>(config.Blocks) 
                : random.Span128<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics Run(this InXDConfig128 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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
                    throw unsupported(op, prim);
            }
        }

        static Metrics<T> Run<T>(this InXGConfig128 config, OpKind op, IRandomizer random)        
            where T : struct
        {
            var lhs = random.Span128<T>(config.Blocks);
            var rhs = op.NonZeroRight() 
                ? random.NonZeroSpan128<T>(config.Blocks) 
                : random.Span128<T>(config.Blocks);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics Run(this InXGConfig128 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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
                    throw unsupported(op, prim);
            }
        }




        public static Metrics<T> Run<T>(this InXDConfig256 config, OpKind op, IRandomizer random = null)        
            where T : struct
        {
            random = Random(random);
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() 
                ? random.NonZeroSpan256<T>(config.Blocks) 
                : random.Span256<T>(config.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i < config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics Run(this InXGConfig256 config, OpKind op, PrimalKind prim, IRandomizer random = null)
        {
            random = Random(random);
            switch(prim)
            {
                case PrimalKind.int8:
                    return config.Run<sbyte>(random, op);
                case PrimalKind.uint8:
                    return config.Run<byte>(random, op);
                case PrimalKind.int16:
                    return config.Run<short>(random, op);
                case PrimalKind.uint16:
                    return config.Run<ushort>(random, op);
                case PrimalKind.int32:
                    return config.Run<int>(random, op);
                case PrimalKind.uint32:
                    return config.Run<uint>(random, op);
                case PrimalKind.int64:
                    return config.Run<long>(random, op);
                case PrimalKind.uint64:
                    return config.Run<ulong>(random, op);
                case PrimalKind.float32:
                    return config.Run<float>(random, op);
                case PrimalKind.float64:                    
                    return config.Run<double>(random, op);
                default:
                    throw unsupported(op, prim);
            }
        }


        static Metrics<T> Run<T>(this InXGConfig256 config, IRandomizer random,  OpKind op)        
            where T : struct
        {
            random = Random(random);
            var lhs = random.Span256<T>(config.Blocks);
            var rhs = op.NonZeroRight() 
                ? random.NonZeroSpan256<T>(config.Blocks) 
                : random.Span256<T>(config.Blocks);
            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
                metrics += config.Measure<T>(op, lhs, rhs);
            return metrics;            
        }
        public static IMetrics Run(this InXDConfig256 config, OpKind op, PrimalKind prim, IRandomizer random = null)
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
                    throw unsupported(op, prim);
            }
        }

   }
}