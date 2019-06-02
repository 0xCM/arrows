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


    class InXGMetrics256 : InXMetrics
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
        
        public static InXGConfig256 Configure(InXGConfig256 config)
            => config ?? InXGConfig256.Default(Metric);

        public static new IRandomizer Random(IRandomizer random)
            => InXMetrics.Random(random);

        public static Vec256<T> single<T>(ReadOnlySpan256<T> src, int block)
            where T : struct
                => Vec256.single(src, block);

    }

}