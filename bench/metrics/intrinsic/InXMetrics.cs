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
    using static Spans;

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

    class InX128DMetrics : InXMetrics
    {
        const MetricKind Metric = MetricKind.InX128DFused;
        
        public static InXConfig128 Configure(InXConfig128 config)
            => config ?? InXConfig128.Default(Metric);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec128, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => InXMetrics.alloc(lhs,rhs);
        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => InXMetrics.alloc(src);
        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

        public static Vec128<T> single<T>(ReadOnlySpan128<T> src, int block)
            where T : struct
                => Vec128.single(src, block);


    }

    class InX128GMetrics : InXMetrics
    {
        const MetricKind Metric = MetricKind.InX128GFused;                  
        
        public static InXConfig128 Configure(InXConfig128 config)
            => config ?? InXConfig128.Default(Metric);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec128, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );
        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => InXMetrics.alloc(lhs,rhs);
        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => InXMetrics.alloc(src);
        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

        public static Vec128<T> single<T>(ReadOnlySpan128<T> src, int block)
            where T : struct
                => Vec128.single(src, block);

    }

    class InX128NumGMetrics : InXMetrics
    {
        const MetricKind Metric = MetricKind.InX128G;
        public static InXConfig128 Configure(InXConfig128 config)
            => config ?? InXConfig128.Default(Metric);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Num128, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => InXMetrics.alloc(lhs,rhs);
        public static new Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => InXMetrics.alloc(src);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

    }

    class InX256DMetrics : InXMetrics
    {
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        const MetricKind Metric = MetricKind.InX256DFused;                  
        
        public static InXConfig256 Configure(InXConfig256 config)
            => config ?? InXConfig256.Default(Metric);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => InXMetrics.alloc<T>(lhs,rhs);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => InXMetrics.alloc<T>(src);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

        public static Vec256<T> single<T>(ReadOnlySpan256<T> src, int block)
            where T : struct
                => Vec256.single(src, block);

    }

    class InX256GMetrics : InXMetrics
    {
 
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        const MetricKind Metric = MetricKind.InX256GFused;                  
        
        public static InXConfig256 Configure(InXConfig256 config)
            => config ?? InXConfig256.Default(Metric);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => InXMetrics.alloc<T>(lhs,rhs);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => InXMetrics.alloc<T>(src);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

        public static Vec256<T> single<T>(ReadOnlySpan256<T> src, int block)
            where T : struct
                => Vec256.single(src, block);

    }
}