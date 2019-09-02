//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_rcp_ps (__m128 a) RCPPS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> rcp(Vec128<float> src)
            => Reciprocal(src);

        /// <summary>
        /// __m256 _mm256_rcp_ps (__m256 a) VRCPPS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> rcp(Vec256<float> src)
            => Reciprocal(src);

        [MethodImpl(Inline)]
        public static Scalar128<float> rcp(Scalar128<float> src)
            => ReciprocalScalar(src);

        /// <summary>
        /// __m128 _mm_rcp_ss (__m128 a) RCPSS xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ref Scalar128<float> rcp(ref Scalar128<float> src)
        {
            src = ReciprocalScalar(src);
            return ref src;
        }

    }

}