//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_hsub_ps (__m128 a, __m128 b) HSUBPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> hsub(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m128d _mm_hsub_pd (__m128d a, __m128d b) HSUBPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> hsub(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_hsub_ps (__m256 a, __m256 b) VHSUBPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> hsub(in Vec256<float> lhs, in Vec256<float> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_hsub_pd (__m256d a, __m256d b) VHSUBPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> hsub(in Vec256<double> lhs, in Vec256<double> rhs)
            => HorizontalSubtract(lhs, rhs);
    }

}