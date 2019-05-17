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

    public partial class Num128Bench : BenchContext<MetricKind>
    {   
        static readonly BenchConfig DefaultConfig = new BenchConfig(Cycles: Pow2.T14, Reps: 1, SampleSize: Pow2.T12, AnnounceRate: Pow2.T10);

        public static Num128Bench Create(IRandomizer random, BenchConfig config = null)
            => new Num128Bench(random, config ?? DefaultConfig);

        Num128Bench(IRandomizer random, BenchConfig config)
            : base(MetricKind.Num128, random, config)
        {



        }


        static OpId<T> Id<T>(OpKind op)
            where T : struct
                => op.Num128OpId<T>();

    }

}
