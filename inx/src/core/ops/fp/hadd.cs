//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
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
        public static Vector128<float> hadd(Vector128<float> lhs, Vector128<float> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        ///  __m128d _mm_hadd_pd (__m128d a, __m128d b) HADDPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<double> hadd(Vector128<double> lhs, Vector128<double> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_hadd_ps (__m256 a, __m256 b) VHADDPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> hadd(Vector256<float> lhs, Vector256<float> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_hadd_pd (__m256d a, __m256d b) VHADDPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> hadd(Vector256<double> lhs, Vector256<double> rhs)
            => HorizontalAdd(lhs, rhs);
 
    }

}