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
        public static Vec128<float> div(Vec128<float> lhs, Vec128<float> rhs)
            => Sse42.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(Vec128<double> lhs, Vec128<double> rhs)
            => Sse42.Divide(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<float> reciprocal(Vec128<float> src)
            => Sse42.Reciprocal(src);

 

    }

}