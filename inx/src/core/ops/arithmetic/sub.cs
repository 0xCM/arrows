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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {

        /// <summary>
        /// __m128i _mm_sub_epi8 (__m128i a, __m128i b) PSUBB xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> sub(Vector128<byte> lhs, Vector128<byte> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        ///  __m128i _mm_sub_epi8 (__m128i a, __m128i b) PSUBB xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> sub(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> sub(Vector128<short> lhs, Vector128<short> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi16 (__m128i a, __m128i b) PSUBW xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> sub(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m12
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> sub(Vector128<int> lhs, Vector128<int> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi32 (__m128i a, __m128i b) PSUBD xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> sub(Vector128<uint> lhs, Vector128<uint> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> sub(Vector128<long> lhs, Vector128<long> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m128i _mm_sub_epi64 (__m128i a, __m128i b) PSUBQ xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> sub(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Subtract(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> sub(Vector256<byte> lhs, Vector256<byte> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi8 (__m256i a, __m256i b) VPSUBB ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> sub(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> sub(Vector256<short> lhs, Vector256<short> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi16 (__m256i a, __m256i b) VPSUBW ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> sub(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> sub(Vector256<int> lhs, Vector256<int> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        ///  __m256i _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> sub(Vector256<uint> lhs, Vector256<uint> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> sub(Vector256<long> lhs, Vector256<long> rhs)
            => Subtract(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// Subtracts the right vector from the left
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> sub(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => Subtract(lhs, rhs);

    }
}