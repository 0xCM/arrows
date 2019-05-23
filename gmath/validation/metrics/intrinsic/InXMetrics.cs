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
    using static As;
    using static InXMetrics;
    
    public static class InXMetrics
    {


        public static OpId<T> InXId<T>(this OpKind op, InXMetricConfig config = null, bool generic = false)
            where T : struct
                => (config is InXMetricConfig256) 
                  ? (generic ? op.IntrinsicGeneric<N256,T>() :  op.IntrinsicDirect<N256, T>())
                  : (generic ? op.IntrinsicGeneric<N128,T>() :  op.IntrinsicDirect<N128, T>());

        public static InXMetricConfig128 Configure(InXMetricConfig128 config)
            => config ?? InXMetricConfig128.Default;

        public static InXMetricConfig256 Configure(InXMetricConfig256 config)
            => config ?? InXMetricConfig256.Default;

        public static IRandomizer Random(IRandomizer random)
            => random ?? Randomizer.define(RandSeeds.BenchSeed);

        public static Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => Span128.alloc<T>(length(lhs,rhs));

        public static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => Span128.alloc<T>(src.Length);

        public static Span128<T> alloc128<T>(int blocks)
            where T : struct
                => Span128.alloc<T>(blocks);

        public static Span256<T> alloc256<T>(int blocks)
            where T : struct
                => Span256.alloc<T>(blocks);

        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => Span256.alloc<T>(length(lhs,rhs));

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => Span256.alloc<T>(src.Length);

        public static Metrics<T> metrics<T>(in OpId<T> OpId, InXMetricConfig config, Duration WorkTime, Span128<T> results)
            where T : struct
                => Metrics.Define(OpId, config.Cycles*results.Length, WorkTime, results.Unblock());

        public static Metrics<T> metrics<T>(in OpId<T> OpId, InXMetricConfig config, Duration WorkTime, Span256<T> results)
            where T : struct
                => Metrics.Define(OpId, config.Cycles*results.Length, WorkTime, results.Unblock());
    }
}