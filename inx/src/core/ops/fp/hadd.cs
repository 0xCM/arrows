//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    
    using static zfunc;    

    partial class dfp
    {
       /// <summary>
        /// __m128 _mm_hadd_ps (__m128 a, __m128 b) HADDPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> hadd(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        ///  __m128d _mm_hadd_pd (__m128d a, __m128d b) HADDPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> hadd(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_hadd_ps (__m256 a, __m256 b) VHADDPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> hadd(in Vec256<float> lhs, in Vec256<float> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_hadd_pd (__m256d a, __m256d b) VHADDPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> hadd(in Vec256<double> lhs, in Vec256<double> rhs)
            => HorizontalAdd(lhs, rhs);
 
    }

}