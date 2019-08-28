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

        ///<summary>__m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shuffleHi(in Vec128<short> src, byte control)
            => ShuffleHigh(src, control);

        ///<summary>__m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleHi(in Vec128<ushort> src, byte control)
            => ShuffleHigh(src, control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shuffleLo(in Vec128<short> src, byte control)
            => ShuffleLow(src, control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffleLo(in Vec128<ushort> src, byte control)
            => ShuffleLow(src, control);

        ///<summary>
        /// _mm256_shuffle_epi32: shuffles 32-bit integers within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<int> shuffle(in Vec256<int> src, byte control)
            => Shuffle(src, control);
        
        ///<summary>
        /// _mm256_shuffle_epi32: shuffles 32-bit integers within 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="control">The shuffle spec</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> shuffle(in Vec256<uint> src, byte control)
            => Shuffle(src, control);

        ///<summary>
        /// Shuffles 8-bit integers in the source vector within 128-bit lanes 
        /// as specified by the corresponding element in the shuffle control mask
        ///__m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256
        ///</summary>
        [MethodImpl(Inline)]
        public static Vec256<byte> shuffle(in Vec256<byte> src, in Vec256<byte> control)
            => Shuffle(src, control);

        ///<summary>__m256i _mm256_shuffle_epi8 (__m256i a, __m256i b) VPSHUFB ymm, ymm, ymm/m256</summary>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> shuffle(in Vec256<sbyte> src, in Vec256<sbyte> control)
            => Shuffle(src, control);

        /// <summary>
        /// Transposes a 4x4 matrix of floats, adapted from MSVC intrinsic headers
        /// </summary>
        /// <param name="row0">The first row</param>
        /// <param name="row1">The second row</param>
        /// <param name="row2">The third row</param>
        /// <param name="row3">The fourth row</param>
        [MethodImpl(Inline)]
        public static void transpose(ref Vec128<float> row0,ref Vec128<float> row1,ref Vec128<float> row2,ref Vec128<float> row3)
        {
            var tmp0 = shuffle(row0,row1, 0x44);
            var tmp2 = shuffle(row0, row1, 0xEE);
            var tmp1 = shuffle(row2, row3, 0x44);
            var tmp3 = shuffle(row2,row3, 0xEE);
            row0 = shuffle(tmp0,tmp1, 0x88);
            row1 = shuffle(tmp0,tmp1, 0xDD);
            row2 = shuffle(tmp2,tmp3, 0x88);
            row3 = shuffle(tmp2, tmp3, 0xDD);
        }    
    }
}