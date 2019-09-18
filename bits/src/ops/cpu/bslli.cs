//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class Bits
    {
        /// <summary>
        /// __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8    
        /// Shifts the source value leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static UInt128 bslli(UInt128 src, byte bytes)        
            => ShiftLeftLogical128BitLane(src, bytes).ToUInt128();                            

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<short> bslli(in Vec128<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> bslli(in Vec128<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<int> bslli(in Vec128<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> bslli(in Vec128<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<long> bslli(in Vec128<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        ///  __m128i _mm_bslli_si128 (__m128i a, int imm8) PSLLDQ xmm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> bslli(in Vec128<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);
        
        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<short> bslli(in Vec256<short> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> bslli(in Vec256<ushort> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<int> bslli(in Vec256<int> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> bslli(in Vec256<uint> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<long> bslli(in Vec256<long> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);

        /// <summary>
        /// __m256i _mm256_bslli_epi128 (__m256i a, const int imm8) VPSLLDQ ymm, ymm, imm8
        /// Shifts the source vector leftwards with byte-level resolution
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="bytes">The number of bytes to shift</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> bslli(in Vec256<ulong> src, byte bytes)
            => ShiftLeftLogical128BitLane(src, bytes);          
    }
}