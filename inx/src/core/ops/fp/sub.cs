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
    
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// __m128 _mm_sub_ss (__m128 a, __m128 b) SUBSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => SubtractScalar(lhs, rhs);
            
        /// <summary>
        /// __m128d _mm_sub_sd (__m128d a, __m128d b) SUBSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => SubtractScalar(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_sub_ps (__m256 a, __m256 b) VSUBPS ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_sub_pd (__m256d a, __m256d b) VSUBPD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)  
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m128d _mm_sub_ps (__m128d a, __m128d b) SUBPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128d _mm_sub_pd (__m128d a, __m128d b) SUBPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
            => Subtract(lhs,rhs);


        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> negate(in Vec128<float> src)
            =>  sub(Vec128<float>.Zero, src);

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> negate(in Vec128<double> src)
            =>  sub(Vec128<double>.Zero, src);

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> negate(in Vec256<float> src)
            =>  sub(Vec256<float>.Zero, src);

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> negate(in Vec256<double> src)
            =>  sub(Vec256<double>.Zero, src);
    }

}