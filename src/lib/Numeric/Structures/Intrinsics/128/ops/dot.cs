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
    using static x86;

    partial class Vec128
    {


        [MethodImpl(Inline)]
        public static Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs)
            => Sse41.DotProduct(lhs, rhs,0);
        
        [MethodImpl(Inline)]
        public static Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs)
            => Sse41.DotProduct(lhs, rhs,0);


    }

}