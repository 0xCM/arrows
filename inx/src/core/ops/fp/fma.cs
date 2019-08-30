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

    using static System.Runtime.Intrinsics.X86.Fma;        
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_fnmadd_ps (__m128 a, __m128 b, __m128 c) VFNMADDPS xmm, xmm, xmm/m128
        /// dst = -(x*y + c)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec128<float> fnmadd(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m128d _mm_fnmadd_pd (__m128d a, __m128d b, __m128d c) VFNMADDPD xmm, xmm, xmm/m128
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec128<double> fnmadd(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m128 _mm_fnmadd_ss (__m128 a, __m128 b, __m128 c) VFNMADDSS xmm, xmm, xmm/m32
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Num128<float> fnmadd(in Num128<float> x, in Num128<float> y, in Num128<float> z)
            => MultiplyAddNegatedScalar(x,y,z);

        /// <summary>
        /// __m128d _mm_fnmadd_sd (__m128d a, __m128d b, __m128d c) VFNMADDSD xmm, xmm, xmm/m64
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Num128<double> fnmadd(in Num128<double> x, in Num128<double> y, in Num128<double> z)
            => MultiplyAddNegatedScalar(x,y,z);

        /// <summary>
        /// __m128 _mm_fmaddsub_ps (__m128 a, __m128 b, __m128 c) VFMADDSUBPS xmm, xmm, xmm/m128
        /// dst = x*y - z
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec128<float> fmaddsub(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m128d _mm_fmaddsub_pd (__m128d a, __m128d b, __m128d c) VFMADDSUBPD xmm, xmm, xmm/m128
        /// dst[i] = x[i]*y[i] + z (i is even?)
        /// dst[i] = x[i]*y[i] - z (i is odd?)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec128<double> fmaddsub(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m256 _mm256_fnmadd_ps (__m256 a, __m256 b, __m256 c) VFNMADDPS ymm, ymm, ymm/m256
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec256<float> fnmadd(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m256d _mm256_fnmadd_pd (__m256d a, __m256d b, __m256d c) VFNMADDPD ymm, ymm,ymm/m256
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec256<double> fnmadd(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddNegated(x,y,z);

        /// <summary>
        /// __m256 _mm256_fmaddsub_ps (__m256 a, __m256 b, __m256 c) VFMADDSUBPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec256<float> fmaddsub(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddSubtract(x,y,z);

        /// <summary>
        /// __m256d _mm256_fmaddsub_pd (__m256d a, __m256d b, __m256d c) VFMADDSUBPD ymm, ymm, ymm/m256
        /// dst[i] = x[i]*y[i] + z (i is even?)
        /// dst[i] = x[i]*y[i] - z (i is odd?)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Vec256<double> fmaddsub(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddSubtract(x,y,z);
    }
}