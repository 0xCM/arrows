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
    
    using static zcore;
    using static inxfunc;
    using static vec128;


    partial class InXX
    {

       [MethodImpl(Inline)]
        public static short InXSum(this Index<short> src)
            => InX.sum(src);

        [MethodImpl(Inline)]
        public static unsafe int InXSum(this Index<int> src)
            => InX.sum(src);

        [MethodImpl(Inline)]
        public static unsafe float InXSum(this Index<float> src)
            => InX.sum(src);

        [MethodImpl(Inline)]
        public static unsafe double InXSum(this Index<double> src)
            => InX.sum(src);
    }
}