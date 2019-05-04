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


    partial class dinx
    {


        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Divide(lhs, rhs);


        [MethodImpl(Inline)]
        public static unsafe void div(float* lhs, float* rhs, float* dst)  
            => Avx2.Store(dst,Avx2.Divide(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));

        [MethodImpl(Inline)]
        public static unsafe void div(double* lhs, double* rhs, double* dst)  
            => Avx2.Store(dst,Avx2.Divide(Avx2.LoadVector128(lhs),Avx2.LoadVector128(rhs)));


        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Divide(lhs, rhs);

    }

}