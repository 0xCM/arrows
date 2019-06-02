//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static Span256;
    using static Span128;

    class InXMetrics
    {
        protected static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        protected static Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => Span128.alloc<T>(length(lhs,rhs));
        protected static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => Span128.alloc<T>(src.BlockCount);

        protected static Span128<T> alloc128<T>(int blocks)
            where T : struct
                => Span128.alloc<T>(blocks);

        protected static Span256<T> alloc256<T>(int blocks)
            where T : struct
                => Span256.alloc<T>(blocks);

        protected static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => Span256.alloc<T>(lhs.BlockCount);

        protected static Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => Span256.alloc<T>(src.BlockCount);
    }

}