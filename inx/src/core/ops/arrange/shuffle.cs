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
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {
        ///<summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        ///</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflehi(in Vec128<short> src, byte control)
            => ShuffleHigh(src, control);

        ///<summary>__m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflehi(in Vec128<ushort> src, byte control)
            => ShuffleHigh(src, control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflelo(in Vec128<short> src, byte control)
            => ShuffleLow(src, control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflelo(in Vec128<ushort> src, byte control)
            => ShuffleLow(src, control);

        ///<summary>__m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(in Vec128<int> src, byte control)
            => Shuffle(src, control);

        ///<summary>__m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<uint> shuffle(in Vec128<uint> src, byte control)
            => Shuffle(src, control);

        ///<summary>__m128i _mm_shuffle_epi8 (__m128i a, __m128i b) PSHUFB xmm, xmm/m128</summary>
        [MethodImpl(Inline)]
        public static Vec128<byte> shuffle(in Vec128<byte> src, in Vec128<byte> mask)
            => Shuffle(src, mask);

        ///<summary>__m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> shuffle(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => Shuffle(src, mask);

        ///<summary>__m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int control) SHUFPS xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<float> shuffle(in Vec128<float> lhs, in Vec128<float> rhs,  byte control)
            => Shuffle(lhs,rhs, control);

        ///<summary>__m128d _mm_shuffle_pd (__m128d a, __m128d b, int immediate) SHUFPD xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<double> shuffle(in Vec128<double> lhs, in Vec128<double> rhs, byte control)
            =>  Shuffle(lhs,rhs, control);

        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<int> shuffle(in Vec256<int> src, byte control)
            => Shuffle(src, control);
        
        ///<summary>
        /// __m256i _mm256_shuffle_epi32 (__m256i a, const int imm8) VPSHUFD ymm, ymm/m256, imm8
        /// shuffles 32-bit integers in the source vector within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> shuffle(in Vec256<uint> src, byte control)
            => Shuffle(src, control);

        ///<summary>
        /// __m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        /// Shuffles 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        ///</summary>
        [MethodImpl(Inline)]
        public static Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> control)
            => Shuffle(src, control);

        ///<summary>__m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> control)
            => Shuffle(src, control);
    }
}