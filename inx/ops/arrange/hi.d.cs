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

        [MethodImpl(Inline)]
        public static Vec128<sbyte> hi(in Vec256<sbyte> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<byte> hi(in Vec256<byte> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<short> hi(in Vec256<short> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<ushort> hi(in Vec256<ushort> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<int> hi(in Vec256<int> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<uint> hi(in Vec256<uint> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<long> hi(in Vec256<long> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<ulong> hi(in Vec256<ulong> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<float> hi(in Vec256<float> src)
            => ExtractVector128(src,1);

        [MethodImpl(Inline)]
        public static Vec128<double> hi(in Vec256<double> src)
            => ExtractVector128(src,1);
 
        /// <intrinsic>__m128i _mm_unpackhi_epi8 (__m128i a, __m128i b) PUNPCKHBW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> hi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi8 (__m128i a, __m128i b) PUNPCKHBW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<byte> hi(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi16 (__m128i a, __m128i b) PUNPCKHWD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<short> hi(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi16 (__m128i a, __m128i b) PUNPCKHWD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ushort> hi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<int> hi(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<uint> hi(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<long> hi(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<ulong> hi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackHigh(lhs,rhs);


        /// <intrinsic>__m128 _mm_unpackhi_ps (__m128 a, __m128 b) UNPCKHPS xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<float> hi(in Vec128<float> lhs, in Vec128<float> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m128d _mm_unpackhi_pd (__m128d a, __m128d b) UNPCKHPD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static Vec128<double> hi(in Vec128<double> lhs, in Vec128<double> rhs)
            => UnpackHigh(lhs,rhs);


        /// <intrinsic>__m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<byte> hi(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> hi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<short> hi(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <intrinsic>__m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ushort> hi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<int> hi(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackHigh(lhs,rhs);

        ///<intrinsic>__m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<uint> hi(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// (lhs[1] -> dst[0], rhs[1] -> dst[1], lhs[3] -> dst[2], rhs[3] -> dst[3])
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        ///<intrinsic>__m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<long> hi(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        ///<intrinsic>__m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<ulong> hi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackHigh(lhs,rhs);

        ///<intrinsic>__m256 _mm256_unpackhi_ps (__m256 a, __m256 b) VUNPCKHPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<float> hi(in Vec256<float> lhs, in Vec256<float> rhs)
            => UnpackHigh(lhs,rhs);

        ///<intrinsic>__m256d _mm256_unpackhi_pd (__m256d a, __m256d b) VUNPCKHPD ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static Vec256<double> hi(in Vec256<double> lhs, in Vec256<double> rhs)
            => UnpackHigh(lhs,rhs);
 
    }

}