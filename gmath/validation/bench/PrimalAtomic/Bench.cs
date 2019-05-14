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

    public partial class PrimalAtomicBench : PrimalBench
    {
        public static PrimalAtomicBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalAtomicBench(random, config);

        protected int Baseline = 2;
        
        PrimalAtomicBench(IRandomizer random, BenchConfig config = null)
            : base(random, config)
        {
            
        }


        protected override OpId<T> Id<T>(OpKind op)
            => op.PrimalAtomic<T>();

    }

}