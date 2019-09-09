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
       /// <summary>__m128i _mm_unpackhi_epi8 (__m128i a, __m128i b) PUNPCKHBW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> unpackhi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi8 (__m128i a, __m128i b) PUNPCKHBW xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<byte> unpackhi(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi16 (__m128i a, __m128i b) PUNPCKHWD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> unpackhi(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi16 (__m128i a, __m128i b) PUNPCKHWD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> unpackhi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<int> unpackhi(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<uint> unpackhi(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<long> unpackhi(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<ulong> unpackhi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128 _mm_unpackhi_ps (__m128 a, __m128 b) UNPCKHPS xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> unpackhi(in Vec128<float> lhs, in Vec128<float> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m128d _mm_unpackhi_pd (__m128d a, __m128d b) UNPCKHPD xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> unpackhi(in Vec128<double> lhs, in Vec128<double> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<byte> unpackhi(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> unpackhi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<short> unpackhi(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>__m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<ushort> unpackhi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        ///<summary>__m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<int> unpackhi(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackHigh(lhs,rhs);

        ///<summary>__m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<uint> unpackhi(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Unpack and interleave 64-bit integers from the high half of each 128-bit 
        /// lane in the operands, and store the results in dst, like so:
        /// (lhs[1] -> dst[0], rhs[1] -> dst[1], lhs[3] -> dst[2], rhs[3] -> dst[3])
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> unpackhi(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Unpack and interleave 64-bit integers from the high half of each 128-bit 
        /// lane in the operands, and store the results in dst.
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        ///<algorithm>
        /// DEFINE INTERLEAVE_HIGH_QWORDS(src1[127:0], src2[127:0]) {
        /// 	dst[63:0] := src1[127:64] 
        /// 	dst[127:64] := src2[127:64] 
        /// 	RETURN dst[127:0]	
        /// }
        /// dst[127:0] := INTERLEAVE_HIGH_QWORDS(a[127:0], b[127:0])
        /// dst[255:128] := INTERLEAVE_HIGH_QWORDS(a[255:128], b[255:128])
        /// dst[MAX:256] := 0 
        /// </algorithm>
        [MethodImpl(Inline)]
        public static Vec256<ulong> unpackhi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackHigh(lhs,rhs);

    }
}