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

    public partial class BaselineMetrics : PrimalBench
    {
        public static BaselineMetrics Create(IRandomizer random, BenchConfig config = null)
            => new BaselineMetrics(random, config);

        public static BaselineMetrics Create(ArraySampler LeftSrc, ArraySampler RightSrc, ArraySampler NonZeroSrc, IRandomizer random, BenchConfig config)
            => new BaselineMetrics(LeftSrc, RightSrc, NonZeroSrc, random, config);


        BaselineMetrics(ArraySampler LeftSrc, ArraySampler RightSrc, ArraySampler NonZeroSrc, IRandomizer random, BenchConfig config = null)
            : base(BenchKind.PrimalDirect, LeftSrc, RightSrc, NonZeroSrc, random, config)
        {
        }

        BaselineMetrics(IRandomizer random, BenchConfig config = null)
            : base(BenchKind.PrimalDirect, random, config)
        {
        }
        
        protected override OpId<T> Id<T>(OpKind op)
            => op.PrimalDirect<T>(NumericKind.Native);

    }

}