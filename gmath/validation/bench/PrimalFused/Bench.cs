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

    public partial class PrimalFusedBench : PrimalBench
    {
        public static PrimalFusedBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalFusedBench(random, config ?? Config2);


        PrimalFusedBench(IRandomizer random, BenchConfig config)
            : base(random, config)
            {

            }

        protected override OpId<T> Id<T>(OpKind op, bool baseline = true)
            => op.PrimalFused<T>(generic: baseline ? false : true , baseline: baseline);

    }
}