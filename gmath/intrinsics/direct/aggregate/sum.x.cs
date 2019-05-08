//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    
    using static mfunc;


    partial class dinxx
    {

       [MethodImpl(Inline)]
        public static short InXSum(this ReadOnlySpan<short> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe int InXSum(this ReadOnlySpan<int> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe float InXSum(this ReadOnlySpan<float> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe double InXSum(this ReadOnlySpan<double> src)
            => dinx.sum(src);
    }
}