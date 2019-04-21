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


    partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec256<float> sqrt(Vec256<float> src)
            => Avx2.Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(Vec256<double> src)
            => Avx2.Sqrt(src);

    }

}