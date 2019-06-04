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


    class InXDMetrics256 : InXMetrics
    {
        public static OpId<T> Id<T>(OpKind op, bool fused = true)
            where T : struct
                => op.OpId<T>(
                        NumericSystem.Intrinsic,
                        numKind: NumericKind.Vec256, 
                        generic: Genericity.Direct, 
                        fusion: fused ? OpFusion.Fused : OpFusion.Atomic
                        );

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                =>  Span256.alloc<T>(lhs, rhs);

        public static Span256<T> alloc<T>(ReadOnlySpan256<T> src)
            where T : struct
                => Span256.alloc<T>(src.BlockCount);


    }


}