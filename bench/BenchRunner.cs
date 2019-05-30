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

    public static class BenchRunner
    {
        static IRandomizer Random(IRandomizer random = null)
            => random ?? Z0.Randomizer.define(RandSeeds.BenchSeed);

        public static IMetrics Run(this InXConfig128 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  
                ? config.RunG(op, prim, random) 
                : config.RunD(op, prim, random);
                  
        public static IMetrics Run(this InXConfig256 config, OpKind op, PrimalKind prim, bool generic, IRandomizer random = null)        
            =>  generic  
                ? config.RunG(op, prim, random) 
                : config.RunD(op, prim, random);                

        public static IEnumerable<MetricComparisonRecord> RunComparison(this InXConfig128 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.RunComparison(op));

        public static IEnumerable<MetricComparisonRecord> RunComparison(this InXConfig256 config, IEnumerable<OpType> ops)
            => ops.Select(op => config.RunComparison(op));

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXConfig128 config, IEnumerable<OpType> ops, bool silent = false)
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

       public static IReadOnlyList<MetricComparisonRecord> RunComparisons(this InXConfig256 config, IEnumerable<OpType> ops, bool silent = false)
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

        public static MetricComparisonRecord RunComparison(this InXConfig256 config, OpType op, IRandomizer random = null)
        {
            var m1 = config.Run(op.Op, op.Primitive, false, random);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true, random);
            print(m2.Describe());

            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord RunComparison(this InXConfig128 config, OpType op, IRandomizer random = null)
        {
            var m1 = config.Run(op.Op, op.Primitive, false, random);
            print(m1.Describe());

            var m2 = config.Run(op.Op, op.Primitive, true, random);
            print(m2.Describe());
        
            return m1.Compare(m2).ToRecord();
        }

        public static MetricComparisonRecord RunComparison(this PrimalGConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalD.Measure(op.Op, op.Primitive, config.ToDirect());
            var m2 = MetricKind.PrimalG.Measure(op.Op, op.Primitive, config);            
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }
        
        public static MetricComparisonRecord RunComparison(this NumGConfig config, OpType op, bool silent = false)
        {            
            var m1 = MetricKind.PrimalD.Measure(op.Op, op.Primitive, config.ToPrimalD());
            var m2 = MetricKind.NumG.Measure(op.Op, op.Primitive, config);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static MetricComparisonRecord RunComparison(this BitGConfig config, OpType op, bool silent = false)
        {
            var m1 = MetricKind.BitD.Measure(op.Op, op.Primitive, config.ToDirect());
            var m2 = MetricKind.BitG.Measure(op.Op, op.Primitive, config);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, NumGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(op, prim, Random(random));

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, PrimalDConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(op, prim, Random(random));

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, PrimalGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(op, prim, Random(random));

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, BitDConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(metric, false, op, prim, Random(random));

        public static IMetrics Measure(this MetricKind metric, OpKind op, PrimalKind prim, BitGConfig config, IRandomizer random = null)
            => metric.Configure(config).Run(metric, true, op, prim, Random(random));

    }
}