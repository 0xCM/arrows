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
        public static Vec128<short> hsub(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m128i _mm_hsub_epi32 (__m128i a, __m128i b) PHSUBD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vec128<int> hsub(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalSubtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_hsub_epi16 (__m256i a, __m256i b) VPHSUBW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<short> subh(in Vec256<short> lhs, in Vec256<short> rhs)
            => HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> hsub(in Vec256<int> lhs, in Vec256<int> rhs)
            => HorizontalSubtract(lhs, rhs);




    }
}