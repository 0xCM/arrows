//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_min_ps (__m128 a, __m128 b) MINPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> min(in Vec128<float> lhs, in Vec128<float> rhs)
            => Min(lhs, rhs);

        /// <summary>
        /// __m128d _mm_min_pd (__m128d a, __m128d b) MINPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> min(in Vec128<double> lhs, in Vec128<double> rhs)
            => Min(lhs, rhs);

        /// <summary>
        ///  __m128 _mm_min_ss (__m128 a, __m128 b) MINSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> min(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => MinScalar(lhs, rhs);

        /// <summary>
        /// __m128d _mm_min_sd (__m128d a, __m128d b) MINSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> min(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => MinScalar(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_min_ps (__m256 a, __m256 b) VMINPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> min(in Vec256<float> lhs, in Vec256<float> rhs)
            => Min(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_min_pd (__m256d a, __m256d b) VMINPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> min(in Vec256<double> lhs, in Vec256<double> rhs)
            => Min(lhs, rhs); 
    }
}