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
    using static mfunc;


    public static class BenchX
    {
        public static IMetrics Run(this InXMetricConfig128 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  ? InXGBench.Run(op, prim, config, random) : InXVecBench.Run(op, prim, config, random);
                  
        public static IMetrics Run(this InXMetricConfig256 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  ? InXGBench.Run(op, prim, config, random) : InXVecBench.Run(op, prim, config, random);
                  
        public static MetricComparisonRecord Compare(this InXMetricConfig256 config, OpType op)
        {
            var m1 = config.Run(op.Op, op.Primitive, false);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true);
            print(m2.Describe());

            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord Compare(this InXMetricConfig128 config, OpType op)
        {
            var m1 = config.Run(op.Op, op.Primitive, false);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true);
            print(m2.Describe());
        
            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord Compare(this MetricConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalDirect.Run(op.Op, op.Primitive, config);
            var m2 = MetricKind.PrimalGeneric.Run(op.Op, op.Primitive, config);            
            var compared =m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static MetricComparisonRecord Compare(this InXMetricConfig128 config, OpKind op, PrimalKind prim)
            => config.Compare(OpType.Define(op, prim));

        public static MetricComparisonRecord Compare(this InXMetricConfig256 config, OpKind op, PrimalKind prim)
            => config.Compare(OpType.Define(op, prim));

        public static IEnumerable<MetricComparisonRecord> Compare(this InXMetricConfig128 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.Compare(op));

        public static IEnumerable<MetricComparisonRecord> Compare(this InXMetricConfig256 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.Compare(op));

       public static IReadOnlyList<MetricComparisonRecord> CollectComparisons(this InXMetricConfig128 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in config.Compare(ops))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       }

       public static IReadOnlyList<MetricComparisonRecord> CollectComparisons(this InXMetricConfig256 config, IEnumerable<OpType> ops, bool silent = false)
       {            
            var results = new List<MetricComparisonRecord>();
            foreach(var comparison in config.Compare(ops))
            {
                results.Add(comparison);
                if(!silent)
                    print(items(comparison).FormatMessages());
            }
            
            return results;
       } 
    }
}