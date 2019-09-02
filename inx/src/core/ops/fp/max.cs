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
        /// __m128 _mm_max_ss (__m128 a, __m128 b) MAXSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> max(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => MaxScalar(lhs, rhs);            

        /// <summary>
        /// __m128d _mm_max_sd (__m128d a, __m128d b) MAXSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>        
        [MethodImpl(Inline)]
        public static Scalar128<double> max(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => MaxScalar(lhs, rhs);

        /// <summary>
        ///  __m128 _mm_max_ps (__m128 a, __m128 b) MAXPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<float> max(in Vec128<float> lhs, in Vec128<float> rhs)
            => Max(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<double> max(in Vec128<double> lhs, in Vec128<double> rhs)
            => Max(lhs, rhs);


        /// <summary>
        /// __m256 _mm256_max_ps (__m256 a, __m256 b) VMAXPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<float> max(in Vec256<float> lhs, in Vec256<float> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> max(in Vec256<double> lhs, in Vec256<double> rhs)
            => Max(lhs, rhs);

    }
}