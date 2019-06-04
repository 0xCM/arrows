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


    class InXGMetrics128 : InXMetrics
    {
    
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec128, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );
    }

    class InXNumGMetrics128 : InXMetrics
    {

        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Num128, 
                        generic: Genericity.Generic, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static Span128<T> alloc<T>(ReadOnlySpan128<T> src)
            where T : struct
                => Span128.alloc<T>(src.BlockCount);

    }

}