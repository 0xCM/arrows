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



    public static class BenchSelector
    {
        public static void RunBench(MetricKind kind, params  OpKind[] opkinds)
        {                    
            var randomizer = Randomizer.define(RandSeeds.BenchSeed);
            var bench = kind.CreateBench(randomizer);
            if(opkinds.Length != 0)
            {
                var ops = opkinds.Select(o => o.ToString()).ToHashSet();
                bench.Run(x => ops.Any(o => x.StartsWith(o)));
            }
            else
                bench.Run();
        }

        public static BenchContext<MetricKind> CreateBench(this MetricKind kind, IRandomizer random, BenchConfig config = null)
        {
            switch(kind)
            {
                case MetricKind.Common:
                    return CommonBench.Create(random, config);
                
                // case BenchKind.PrimalFused:
                //     return PrimalFusedBench.Create(random, config);

                // case BenchKind.PrimalDirect:
                //     return PrimalBaseline.Create(random, config);

                // case BenchKind.PrimalAtomic:
                //     return PrimalAtomicBench.Create(random, config);
                
                // case BenchKind.NumG:
                //     return NumGBench.Create(random, config);
                
                case MetricKind.Numbers:
                    return NumbersBench.Create(random, config);
                
                case MetricKind.Num128:
                    return Num128Bench.Create(random, config);
                
                case MetricKind.Vec128:
                    return Vec128Bench.Create(random, config);
                
                case MetricKind.Vec256:
                    return Vec256Bench.Create(random, config);

            }

            throw new Exception($"{nameof(MetricKind)} = {kind} is not supported");
        }

    }

}