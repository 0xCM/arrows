//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
 
    using static zfunc;
    
    public static partial class Bits
    {                
        /// <summary>
        /// __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> andn(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> andn(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<short> andn(in Vec128<short> lhs, in Vec128<short> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> andn(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<int> andn(in Vec128<int> lhs, in Vec128<int> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> andn(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<long> andn(in Vec128<long> lhs, in Vec128<long> rhs)
            => AndNot(lhs, rhs);
 
        /// <summary>
        ///  __m128i _mm_andnot_si128 (__m128i a, __m128i b) PANDN xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> andn(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => AndNot(lhs, rhs);
 
        /// <summary>
        /// __m128 _mm_andnot_ps (__m128 a, __m128 b) ANDNPS xmm, xmm/m128
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<float> andn(in Vec128<float> lhs, in Vec128<float> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// _mm_andnot_pd:
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec128<double> andn(in Vec128<double> lhs, in Vec128<double> rhs)
            => AndNot(lhs, rhs);        
    
        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> andn(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> andn(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<short> andn(in Vec256<short> lhs, in Vec256<short> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> andn(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<int> andn(in Vec256<int> lhs, in Vec256<int> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> andn(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<long> andn(in Vec256<long> lhs, in Vec256<long> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256i _mm256_andnot_si256 (__m256i a, __m256i b) VPANDN ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> andn(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256 _mm256_andnot_ps (__m256 a, __m256 b) VANDNPS ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<float> andn(in Vec256<float> lhs, in Vec256<float> rhs)
            => AndNot(lhs, rhs);

        /// <summary>
        /// __m256d _mm256_andnot_pd (__m256d a, __m256d b) VANDNPD ymm, ymm, ymm/m256
        /// Effects the composite operation (~ lhs) & rhs for the left and right operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Vec256<double> andn(in Vec256<double> lhs, in Vec256<double> rhs)
            => AndNot(lhs, rhs);
    }
}