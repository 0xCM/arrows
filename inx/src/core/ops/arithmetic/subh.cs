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
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx
    {        
        /// <summary>
        /// __m128i _mm_hsub_epi16 (__m128i a, __m128i b) PHSUBW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<short> hsub(Vector128<short> lhs, Vector128<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m128i _mm_hsub_epi32 (__m128i a, __m128i b) PHSUBD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<int> hsub(Vector128<int> lhs, Vector128<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_hsub_epi16 (__m256i a, __m256i b) VPHSUBW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<short> subh(Vector256<short> lhs, Vector256<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> hsub(Vector256<int> lhs, Vector256<int> rhs)
            => HorizontalSubtract(lhs, rhs);
    }
}