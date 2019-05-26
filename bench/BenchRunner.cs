//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public static class BenchRunner
    {
        public static IMetrics Run(this InXMetricConfig128 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  ? InXGBench.Run(op, prim, config, random) : InXVecBench.Run(op, prim, config, random);
                  
        public static IMetrics Run(this InXMetricConfig256 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  ? InXGBench.Run(op, prim, config, random) : InXVecBench.Run(op, prim, config, random);
                  
        public static IEnumerable<IMetrics> Run(this MetricConfig config, IEnumerable<MetricKind> metrics, IEnumerable<OpKind> ops, 
            IEnumerable<PrimalKind> primitives,  IRandomizer random = null)
        {
            var query = from m in metrics
                        from o in ops
                        from p in primitives
                        select m.Run(o,p, config, random);
            return query;
        }

        public static MetricComparisonRecord RunComparison(this InXMetricConfig256 config, OpType op)
        {
            var m1 = config.Run(op.Op, op.Primitive, false);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true);
            print(m2.Describe());

            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord RunComparison(this InXMetricConfig128 config, OpType op)
        {
            var m1 = config.Run(op.Op, op.Primitive, false);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true);
            print(m2.Describe());
        
            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord RunComparison(this MetricConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalDirect.Run(op.Op, op.Primitive, config);
            var m2 = MetricKind.PrimalGeneric.Run(op.Op, op.Primitive, config);            
            var compared =m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static MetricComparisonRecord RunComparison(this InXMetricConfig128 config, OpKind op, PrimalKind prim)
            => config.RunComparison(OpType.Define(op, prim));

        public static MetricComparisonRecord RunComparison(this InXMetricConfig256 config, OpKind op, PrimalKind prim)
            => config.RunComparison(OpType.Define(op, prim));

        public static IEnumerable<MetricComparisonRecord> RunComparison(this InXMetricConfig128 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.RunComparison(op));

        public static IEnumerable<MetricComparisonRecord> RunComparison(this InXMetricConfig256 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.RunComparison(op));

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXMetricConfig128 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in config.RunComparison(ops))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       }

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXMetricConfig256 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in config.RunComparison(ops))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       } 

        static IRandomizer Random(IRandomizer random = null)
            => random ?? Z0.Randomizer.define(RandSeeds.BenchSeed);
        
        public static bool NonZeroRight(this OpKind op)
            => op == OpKind.Div || op == OpKind.Mod;

        public static IMetrics Run(this MetricKind metric, OpKind op, PrimalKind primal, 
            MetricConfig config = null, IRandomizer random = null)
        {
            switch(metric)
            {
                case MetricKind.Number:
                    return NumGBench.Run(op, primal, config, random);
                case MetricKind.PrimalDirect:
                    return PrimalDBench.Run(op, primal, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGBench.Run(op, primal, config, random);
            }
            throw unsupported(metric);
        }

        public static IMetrics Run(this MetricId metric, MetricConfig config = null, IRandomizer random = null)
        {
            (var @class, var prim, var op) = metric;
            
            random = Random(random);

            switch(@class)
            {
                case MetricKind.PrimalDirect:
                    return PrimalDBench.Run(op, prim, config, random);
                case MetricKind.Number:
                    return NumGBench.Run(op, prim, config, random);
                case MetricKind.PrimalGeneric:
                    return PrimalGBench.Run(op, prim, config, random);
                default:
                    throw unsupported(metric.Classifier);
            }
        }

        public static MetricComparisonRecord RunComparison(this MetricComparisonSpec spec, MetricConfig config = null)
        {            
            var lhs = spec.BaselineId.Run(config);
            var rhs = spec.BenchId.Run(config);        
            //spec.Validate(lhs,rhs);

            static IEnumerable<T> items<T>(ValueTuple<T,T> tuple)
                => zfunc.items(tuple.Item1, tuple.Item2);

            var compare = lhs.Compare(rhs);
            var record = compare.ToRecord();
            var info = record.Describe();

            print(lhs.Describe(true));
            print(rhs.Describe(true));
            print(items(info));
            
            return record;                    
        }

         public static IEnumerable<MetricComparisonRecord> RunComparisons(this IEnumerable<MetricComparisonSpec> specs, MetricConfig config = null)
         {
             foreach(var spec in specs)
                yield return spec.RunComparison(config);
         }   

    }
}