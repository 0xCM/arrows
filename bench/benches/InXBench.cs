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
    using static BenchRunner;
    
    public static class InXBench
    {
        public static InXGContext256 Context(this InXGConfig256 config, IRandomizer random = null)        
            => new InXGContext256(config,random);

        public static InXDContext128 Context(this InXDConfig128 config, IRandomizer random = null)        
            => new InXDContext128(config,random);

        public static InXDContext256 Context(this InXDConfig256 config, IRandomizer random = null)        
            => new InXDContext256(config,random);
        
        public static InXGContext128 Context(this InXGConfig128 config, IRandomizer random = null)        
            => new InXGContext128(config,random);


        public static IReadOnlyList<MetricComparisonRecord> Run256Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int32, PrimalKind.int64, PrimalKind.float32, PrimalKind.float64);
            var ops = items(OpKind.And, OpKind.Add, OpKind.Sub, OpKind.XOr);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXGConfig256.Define(MetricKind.InX256GFused, runs: Pow2.T03, cycles: Pow2.T13, blocks: Pow2.T11);
            var context = config.Context();
            return context.RunComparisons(specs);
       }

        public static IReadOnlyList<MetricComparisonRecord> Run128Fused()
        {            
            var primitives = items(PrimalKind.int8, PrimalKind.int64, PrimalKind.float32);
            var ops = items(OpKind.Add, OpKind.Sub);
            var specs = from p in primitives
                        from o in ops
                        select o.WithType(p);
            var config = InXGConfig128.Define(MetricKind.InX128GFused, runs: Pow2.T03, cycles: Pow2.T12, blocks: Pow2.T11);
            var context = config.Context();
            return context.RunComparisons(specs);
       }

        static MetricComparisonRecord RunComparison(this InXGContext256 context, OpType op, IRandomizer random = null)
        {
            var m1 = context.ToDirect128().Config.Run(op.Op, op.Primitive, Random(random));
            print(m1.Describe());
            var m2 = context.Config.Run(op.Op, op.Primitive, Random(random));
            print(m2.Describe());
            return m1.Compare(m2).ToRecord();
        }

        static MetricComparisonRecord RunComparison(this InXGContext128 context, OpType op, IRandomizer random = null)
        {
            var m1 = context.ToDirect128().Config.Run(op.Op, op.Primitive, Random(random));
            print(m1.Describe());
            var m2 = context.Config.Run(op.Op, op.Primitive, Random(random));
            print(m2.Describe());        
            return m1.Compare(m2).ToRecord();
        }

       static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXGContext128 config, IEnumerable<OpType> ops, bool silent = false)
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

       static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXGContext256 config, IEnumerable<OpType> ops, bool silent = false)
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
   }
}