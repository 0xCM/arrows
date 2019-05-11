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

    public partial class PrimalDirectBench : PrimalBench
    {
        public static PrimalDirectBench Create(IRandomizer random, BenchConfig config = null)
            => new PrimalDirectBench(random, config);

        PrimalDirectBench(IRandomizer random, BenchConfig config = null)
            : base(random, config)
        {
        }
        
        protected override OpId<T> Id<T>(OpKind op, bool baseline = true)
            => op.PrimalDirect<T>(OpFusion.Atomic, baseline);

    }

}