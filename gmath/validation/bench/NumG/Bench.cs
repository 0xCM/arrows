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

    public partial class NumGBench : PrimalBench
    {
        public static NumGBench Create(IRandomizer random, BenchConfig config = null)
            => new NumGBench(random, config);


        NumGBench(IRandomizer random, BenchConfig config = null)
            : base(BenchKind.NumG, random, config)
        {

        }

        protected override OpId<T> Id<T>(OpKind op)
            => op.NumG<T>(OpFusion.Atomic);

    }

}