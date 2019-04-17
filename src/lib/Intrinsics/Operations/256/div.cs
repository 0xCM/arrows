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
        public static Vec256<float> div(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Divide(lhs, rhs);

    }

}