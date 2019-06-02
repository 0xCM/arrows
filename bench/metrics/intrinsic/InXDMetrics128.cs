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
    using static Span128;


    class InXDMetrics128 : InXMetrics
    {
        const MetricKind Metric = MetricKind.InX128DFused;
        
        public static InXDConfig128 Configure(InXDConfig128 config)
            => config ?? InXDConfig128.Default(Metric);

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



}