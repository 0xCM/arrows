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

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> ngt(Num128<float> lhs, Num128<float> rhs)
            => Sse.CompareNotGreaterThanScalar(lhs, rhs);


        [MethodImpl(Inline)]
        public static Num128<double> ngt(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareNotGreaterThanScalar(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<float> ngt(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareNotGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareNotGreaterThan(lhs, rhs);

        

    }


}