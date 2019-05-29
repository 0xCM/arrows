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

        protected static InXMetricConfig128 Configure(InXMetricConfig128 config)
            => config ?? InXMetricConfig128.Default;

        protected static InXMetricConfig256 Configure(InXMetricConfig256 config)
            => config ?? InXMetricConfig256.Default;

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
        public static new InXMetricConfig128 Configure(InXMetricConfig128 config)
            => InXMetrics.Configure(config);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        numKind: NumericKind.Vec128, 
                        numSystem: NumericSystem.Primal, 
                        generic: false, 
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

    class InX128GMetrics : InXMetrics
    {
        public static new InXMetricConfig128 Configure(InXMetricConfig128 config)
            => InXMetrics.Configure(config);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        numKind: NumericKind.Vec128, 
                        numSystem: NumericSystem.Primal, 
                        generic: true, 
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

    class InX128NumGMetrics : InXMetrics
    {
        public static new InXMetricConfig128 Configure(InXMetricConfig128 config)
            => InXMetrics.Configure(config);

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        numKind: NumericKind.Num128, 
                        numSystem: NumericSystem.Primal, 
                        generic: true, 
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
                        numKind: NumericKind.Vec256, 
                        numSystem: NumericSystem.Primal, 
                        generic: false, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static new InXMetricConfig256 Configure(InXMetricConfig256 config)
            => InXMetrics.Configure(config);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => InXMetrics.alloc<T>(lhs,rhs);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => InXMetrics.alloc<T>(src);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);
    }

    class InX256GMetrics : InXMetrics
    {
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        numKind: NumericKind.Vec256, 
                        numSystem: NumericSystem.Primal, 
                        generic: true, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static new InXMetricConfig256 Configure(InXMetricConfig256 config)
            => InXMetrics.Configure(config);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => InXMetrics.alloc<T>(lhs,rhs);

        public static new Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => InXMetrics.alloc<T>(src);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);
    }
}