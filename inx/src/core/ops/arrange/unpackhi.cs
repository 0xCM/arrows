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

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> unpackhi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> unpackhi(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<short> unpackhi(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> unpackhi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> unpackhi(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_unpackhi_epi32 (__m128i a, __m128i b) PUNPCKHDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> unpackhi(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m128i _mm_unpackhi_epi64 (__m128i a, __m128i b) PUNPCKHQDQ xmm, xmm/m128
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> unpackhi(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// Creates a 128-bit vector where the lower 64 bits are taken from the
        /// higher 64 bits of the first source vector and the higher 64 bits are taken 
        /// from the higher 64 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> unpackhi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> unpackhi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi8 (__m256i a, __m256i b) VPUNPCKHBW ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> unpackhi(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<short> unpackhi(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi16 (__m256i a, __m256i b) VPUNPCKHWD ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> unpackhi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> unpackhi(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi32 (__m256i a, __m256i b) VPUNPCKHDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> unpackhi(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> unpackhi(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackHigh(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_unpackhi_epi64 (__m256i a, __m256i b) VPUNPCKHQDQ ymm, ymm, ymm/m256
        /// Creates a 256-bit vector where the lower 128 bits are taken from the
        /// higher 128 bits of the first source vector and the higher 128 bits are taken 
        /// from the higher 128 bits of the second source vector
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> unpackhi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackHigh(lhs,rhs);

   }

}