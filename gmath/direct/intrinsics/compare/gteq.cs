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
        public static Num128<float> gteq(Num128<float> lhs, Num128<float> rhs)
            => Sse.CompareGreaterThanOrEqualScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> gteq(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareGreaterThanOrEqualScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> gteq(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gteq(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareGreaterThanOrEqual(lhs, rhs);


    }
}