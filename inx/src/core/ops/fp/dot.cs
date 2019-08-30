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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// __m128 _mm_dp_ps (__m128 a, __m128 b, const int imm8) DPPS xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<float> dot(Vec128<float> lhs, Vec128<float> rhs, byte? control = null)
            => DotProduct(lhs, rhs, control ?? 0xFF);
        
        /// <summary>
        /// __m128d _mm_dp_pd (__m128d a, __m128d b, const int imm8) DPPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<double> dot(Vec128<double> lhs, Vec128<double> rhs, byte? control = null)
            => DotProduct(lhs, rhs, control ?? 0xFF);

        /// <summary>
        /// __m256 _mm256_dp_ps (__m256 a, __m256 b, const int imm8) VDPPS ymm, ymm, ymm/m256,
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> dot(Vec256<float> lhs, Vec256<float> rhs, byte? control = null)
            => DotProduct(lhs, rhs, control ?? 0xFF);



    }

}