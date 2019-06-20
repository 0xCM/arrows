//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class x86
    {
        /// <summary>
        /// Adds each component from the first vector to the corresponding component in the second vector
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>__m128i _mm_add_epi8 (__m128i a, __m128i b) PADDB xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static m128i _mm_add_epi8(in m128i a, in m128i b)
            => Add(v8i(a), v8i(b));


        /// <summary>
        /// Adds each component from the first vector to the corresponding component in the second vector
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>__m128i _mm_add_epi16 (__m128i a, __m128i b) PADDW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static m128i _mm_add_epi16(in m128i a, in m128i b)
            => Add(v16i(a), v16i(b));

        /// <summary>
        /// Adds each component from the first vector to the corresponding component in the second vector
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic>_mm_add_epi32 (__m128i a, __m128i b) PADDD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static m128i _mm_add_epi32(in m128i a, in m128i b)
            => Add(v32i(a), v32i(b));

        [MethodImpl(Inline)]
        public static m128i _mm_add_epi64(in m128i a, in m128i b)
            => Add(v64i(a), v64i(b));

        [MethodImpl(Inline)]
        public static m256i _mm256_mm_add_epi8(in m256i a, in m256i b)
            => Add(v8i(a), v8i(b));

        [MethodImpl(Inline)]
        public static m256i _mm256_mm_add_epi16(in m256i a, in m256i b)
            => Add(v16i(a), v16i(b));

        [MethodImpl(Inline)]
        public static m256i _mm256_mm_add_epi32(in m256i a, in m256i b)
            => Add(v32i(a), v32i(b));

        [MethodImpl(Inline)]
        public static m256i _mm256_add_epi64(in m256i a, in m256i b)
            => Add(v64i(a), v64i(b));
 
    }

}