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


    partial class dinxx
    {

       [MethodImpl(Inline)]
        public static short InXSum(this Index<short> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe int InXSum(this Index<int> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe float InXSum(this Index<float> src)
            => dinx.sum(src);

        [MethodImpl(Inline)]
        public static unsafe double InXSum(this Index<double> src)
            => dinx.sum(src);
    }
}