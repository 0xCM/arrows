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
        /// __m128i _mm_adds_epu8 (__m128i a, __m128i b) PADDUSB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<byte> adds(in Vec128<byte> lhs, in Vec128<byte> rhs)        
            => AddSaturate(lhs,rhs);

        /// <summary>
        /// __m128i _mm_adds_epi8 (__m128i a, __m128i b) PADDSB xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> adds(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)        
            => AddSaturate(lhs,rhs);

        /// <summary>
        /// __m128i _mm_adds_epi16 (__m128i a, __m128i b) PADDSW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<short> adds(in Vec128<short> lhs, in Vec128<short> rhs)        
            => AddSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> adds(in Vec128<ushort> lhs, in Vec128<ushort> rhs)        
            => AddSaturate(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_adds_epu8 (__m256i a, __m256i b) VPADDUSB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<byte> adds(in Vec256<byte> lhs, in Vec256<byte> rhs)        
            => AddSaturate(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<sbyte> adds(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)        
            => AddSaturate(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> adds(in Vec256<short> lhs, in Vec256<short> rhs)        
            => AddSaturate(lhs,rhs);

        /// <summary>
        ///  __m256i _mm256_adds_epu16 (__m256i a, __m256i b) VPADDUSW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<ushort> adds(in Vec256<ushort> lhs, in Vec256<ushort> rhs)        
            =>  AddSaturate(lhs,rhs);
    }

}