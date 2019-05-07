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
        Primal,
        
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
                case BenchKind.Primal:
                    return PrimalBench.Create(random, config);
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