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
    
    public static class PrimalBench
    {        
        public static PrimalDContext Context(this PrimalDConfig config, IRandomizer random = null)
            => new PrimalDContext(config,random);

        public static PrimalGContext Context(this PrimalGConfig config, IRandomizer random = null)
            => new PrimalGContext(config,random);

        public static IReadOnlyList<MetricComparisonRecord> Run()
        {
            var ops = OpType.Define(OpKinds.BinaryAritmetic, PrimalKinds.All);
            var config = PrimalGConfig.Define(MetricKind.PrimalG, runs: Pow2.T04, cycles: Pow2.T13, samples: Pow2.T11);
            var context = config.Context();
            var comparisons = new List<MetricComparisonRecord>();
            foreach(var ot in ops)
            {                
                var comparison =  context.RunComparison(ot, true);
                comparisons.Add(comparison);
                print(comparison.FormatMessage());
            }
            return comparisons;
        }

        static MetricComparisonRecord RunComparison(this PrimalGContext context, OpType op, bool silent = false)
        {            
            var config = context.Config;
            var m1 = config.ToDirect().Run(op.Op, op.Primitive, context.Random);
            var m2 = config.Run(op.Op, op.Primitive, context.Random);
            var compared = m1.Compare(m2).ToRecord();
            if(!silent)
                print(items(compared).FormatMessages());
            return compared;
        }
    }

}