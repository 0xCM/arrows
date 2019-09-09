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
        public static bool gt(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gt(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);

        /// <summary>
        /// __m128 _mm_cmpgt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(6)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> cmpgt(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareGreaterThan(lhs,rhs);
        
        /// <summary>
        /// __m128d _mm_cmpgt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(6)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> cmpgt(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareGreaterThan(lhs,rhs);

        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> cmpgt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling);

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm,ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> cmpgt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling);
 
    }

}