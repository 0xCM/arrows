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
        /// __m128i _mm_hadd_epi16 (__m128i a, __m128i b) PHADDW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> hadd(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m128i _mm_hadd_epi32 (__m128i a, __m128i b) PHADDD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> hadd(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> hadd(in Vec256<short> lhs, in Vec256<short> rhs)
            => HorizontalAdd(lhs, rhs);

        /// <summary>
        /// m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> hadd(in Vec256<int> lhs, in Vec256<int> rhs)
            => HorizontalAdd(lhs, rhs);

   }
}