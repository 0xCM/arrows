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
    using static inX;

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Vec256<float> ceiling(Vec256<float> src)
            => Avx2.Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<double> ceiling(Vec256<double> src)
            => Avx2.Ceiling(src);



    }
}