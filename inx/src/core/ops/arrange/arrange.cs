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

    public static class Arrange
    {
        ///<summary>
        /// __m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8
        ///</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflehi(in Vec128<short> src, Perm4 control)
            => ShuffleHigh(src, (byte)control);

        ///<summary>__m128i _mm_shufflehi_epi16 (__m128i a, int immediate) PSHUFHW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflehi(in Vec128<ushort> src, Perm4 control)
            => ShuffleHigh(src, (byte)control);

        ///<summary>__m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8</summary>
        [MethodImpl(Inline)]
        public static Vec128<short> shufflelo(in Vec128<short> src, Perm4 control)
            => ShuffleLow(src, (byte)control);

        /// <summary>
        /// __m128i _mm_shufflelo_epi16 (__m128i a, int control) PSHUFLW xmm, xmm/m128, imm8
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shufflelo(in Vec128<ushort> src, Perm4 control)
            => ShuffleLow(src, (byte)control);        

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four
        /// elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> shuffle(in Vec128<ushort> src, Perm4 lo, Perm4 hi)        
            => shufflehi(shufflelo(src,lo),hi);                   

        /// <summary>
        /// Shuffles the first four elements of the source vector with the lo mask and the last four
        /// elements with the hi mask
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="lo">The lo mask</param>
        /// <param name="hi">The hi mask</param>
        [MethodImpl(Inline)]
        public static Vec128<short> shuffle(in Vec128<short> src, Perm4 lo, Perm4 hi)        
            => shufflehi(shufflelo(src,lo),hi);                   

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<int> shuffle(in Vec128<int> src, Perm4 control)
            => Shuffle(src, (byte)control);

        /// <summary>
        /// __m128i _mm_shuffle_epi32 (__m128i a, int immediate) PSHUFD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="src"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<uint> shuffle(in Vec128<uint> src, Perm4 control)
            => Shuffle(src, (byte)control);




    }

}