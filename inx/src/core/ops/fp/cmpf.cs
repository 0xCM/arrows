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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dfp
    {

       [MethodImpl(Inline)]
        public static Vec128Cmp<double> nlt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareNotLessThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> nlt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareNotLessThan(lhs,rhs));

        /// <summary>
        /// __m128 _mm_cmpnge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> ngteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareNotGreaterThanOrEqual(lhs,rhs));

        /// <summary>
        /// __m128d _mm_cmpnge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> ngteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareNotGreaterThanOrEqual(lhs,rhs));


    }

}