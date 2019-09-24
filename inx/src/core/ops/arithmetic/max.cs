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

    using static System.Runtime.Intrinsics.X86.Sse;    
    using static System.Runtime.Intrinsics.X86.Sse2;    
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static zfunc;

    public partial class dinx
    {
        /// <summary>
        /// __m128i _mm_max_epu8 (__m128i a, __m128i b) PMAXUB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<byte> max(Vector128<byte> lhs, Vector128<byte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epi8 (__m128i a, __m128i b) PMAXSB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> max(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_max_epi16 (__m128i a, __m128i b) PMAXSW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<short> max(Vector128<short> lhs, Vector128<short> rhs)
            => Max(lhs, rhs);
 
        /// <summary>
        ///  __m128i _mm_max_epi32 (__m128i a, __m128i b) PMAXSD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<int> max(Vector128<int> lhs, Vector128<int> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epu32 (__m128i a, __m128i b) PMAXUD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<uint> max(Vector128<uint> lhs, Vector128<uint> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu8 (__m256i a, __m256i b) VPMAXUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector256<byte> max(Vector256<byte> lhs, Vector256<byte> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> max(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epi16 (__m256i a, __m256i b) VPMAXSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector256<short> max(Vector256<short> lhs, Vector256<short> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m128i _mm_max_epu16 (__m128i a, __m128i b) PMAXUW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> max(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu16 (__m256i a, __m256i b) VPMAXUW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> max(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => Max(lhs, rhs);

        /// <summary>
        ///  __m256i _mm256_max_epi32 (__m256i a, __m256i b) VPMAXSD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector256<int> max(Vector256<int> lhs, Vector256<int> rhs)
            => Max(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_max_epu32 (__m256i a, __m256i b) VPMAXUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        [MethodImpl(Inline)]
        public static Vector256<uint> max(Vector256<uint> lhs, Vector256<uint> rhs)
            => Max(lhs, rhs);

    }
}