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
        public static Num128<float> div(Num128<float> lhs, Num128<float> rhs)
            => Avx2.DivideScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> div(Num128<double> lhs, Num128<double> rhs)
            => Avx2.DivideScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> div(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Divide(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<double> div(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Divide(lhs, rhs);


    }

}