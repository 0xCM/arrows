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
        
        PrimalFused,

        PrimalAtomic,
        
        PrimalGeneric,

        PrimalDirect,

        NumG,

        Numbers,

        Num128,

        Vec128,

        Vec256

    }

    public static class BenchSelector
    {
        public static BenchContext CreateBench(this BenchKind kind, IRandomizer random, BenchConfig config = null)
        {
            switch(kind)
            {
                case BenchKind.Common:
                    return CommonBench.Create(random, config);
                
                case BenchKind.PrimalFused:
                    return PrimalFusedBench.Create(random, config);

                case BenchKind.PrimalDirect:
                    return PrimalDirectBench.Create(random, config);

                case BenchKind.PrimalGeneric:
                    return PrimalGenericBench.Create(random, config);
                
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