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


    public enum BenchKind
    {
        Common,

        /// <summary>
        /// Identifies primal/generic/fused benchmarks
        /// </summary>        
        PrimalFused,
        
        /// <summary>
        /// Identifies primal/generic/atomic benchmarks
        /// </summary>        
        PrimalAtomic,

        PrimalDirect,

        NumG,

        Numbers,

        Num128,

        Vec128,

        Vec256

    }

    public static class BenchSelector
    {
        public static void RunBench(BenchKind kind, params  OpKind[] opkinds)
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

        public static BenchContext CreateBench(this BenchKind kind, IRandomizer random, BenchConfig config = null)
        {
            switch(kind)
            {
                case BenchKind.Common:
                    return CommonBench.Create(random, config);
                
                case BenchKind.PrimalFused:
                    return PrimalFusedBench.Create(random, config);

                case BenchKind.PrimalDirect:
                    return BaselineMetrics.Create(random, config);

                case BenchKind.PrimalAtomic:
                    return PrimalAtomicBench.Create(random, config);
                
                case BenchKind.NumG:
                    return NumGBench.Create(random, config);
                
                case BenchKind.Numbers:
                    return NumbersBench.Create(random, config);
                
                case BenchKind.Num128:
                    return Num128Bench.Create(random, config);
                
                case BenchKind.Vec128:
                    return Vec128Bench.Create(random, config);
                
                case BenchKind.Vec256:
                    return Vec256Bench.Create(random, config);

            }

            throw new Exception($"{nameof(BenchKind)} = {kind} is not supported");
        }

    }

}