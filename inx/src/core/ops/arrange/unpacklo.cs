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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        /// <intrinsic>__m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> unpacklo(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi8 (__m128i a, __m128i b) PUNPCKLBW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<byte> unpacklo(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<short> unpacklo(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi16 (__m128i a, __m128i b) PUNPCKLWD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ushort> unpacklo(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<int> unpacklo(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi32 (__m128i a, __m128i b) PUNPCKLDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<uint> unpacklo(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> unpacklo(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpacklo_epi64 (__m128i a, __m128i b) PUNPCKLQDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> unpacklo(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackLow(lhs,rhs);


        /// <intrinsic>__m128 _mm_unpacklo_ps (__m128 a, __m128 b) UNPCKLPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> unpacklo(in Vec128<float> lhs, in Vec128<float> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m128d _mm_unpacklo_pd (__m128d a, __m128d b) UNPCKLPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> unpacklo(in Vec128<double> lhs, in Vec128<double> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<byte> unpacklo(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpacklo_epi8 (__m256i a, __m256i b) VPUNPCKLBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> unpacklo(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<short> unpacklo(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackLow(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpacklo_epi16 (__m256i a, __m256i b) VPUNPCKLWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> unpacklo(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> unpacklo(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpacklo_epi32 (__m256i a, __m256i b) VPUNPCKLDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> unpacklo(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> unpacklo(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpacklo_epi64 (__m256i a, __m256i b) VPUNPCKLQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> unpacklo(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256 _mm256_unpacklo_ps (__m256 a, __m256 b) VUNPCKLPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> unpacklo(in Vec256<float> lhs, in Vec256<float> rhs)
            => UnpackLow(lhs,rhs);

        ///<intrinsic>__m256d _mm256_unpacklo_pd (__m256d a, __m256d b) VUNPCKLPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> unpacklo(in Vec256<double> lhs, in Vec256<double> rhs)
            => UnpackLow(lhs,rhs);
    }

}