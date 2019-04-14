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
        public static Num128<float> nlt(Num128<float> lhs, Num128<float> rhs)
            => Sse.CompareNotLessThanScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> nlt(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareNotLessThanScalar(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<float> nlt(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareNotLessThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> nlt(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareNotLessThan(lhs, rhs);


    }


}