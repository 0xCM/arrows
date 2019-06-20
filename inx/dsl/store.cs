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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;
    using static As;

    partial class x86
    {
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref sbyte dst, in m128i src)
            => Store(refptr(ref dst), v8i(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref byte dst, in m128i src)
            => Store(refptr(ref dst), v8u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref short dst, in m128i src)
            => Store(refptr(ref dst), v16i(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ushort dst, in m128i src)
            => Store(refptr(ref dst), v16u(src));

        /// <summary>
        /// void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref int dst, in m128i src)
            => Store(refptr(ref dst), v32i(src));

        /// <summary>
        /// _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref uint dst, in m128i src)
            => Store(refptr(ref dst), v32u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref long dst, in m128i src)
            => Store(refptr(ref dst), v64i(src));

        /// <summary>
        /// void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ulong dst, in m128i src)
            => Store(refptr(ref dst), v64u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_ps(ref float dst, in m128 src)
            => Store(refptr(ref dst), src);

        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_pd(ref double dst, in m128d src)
            => Store(refptr(ref dst), src);

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref sbyte dst, in m256i src)
            => Store(refptr(ref dst), v8i(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref byte dst, in m256i src)
            => Store(refptr(ref dst), v8u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref short dst, in m256i src)
            => Store(refptr(ref dst), v16i(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref ushort dst, in m256i src)
            => Store(refptr(ref dst), v16u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref int dst, in m256i src)
            => Store(refptr(ref dst), v32i(src));
            
        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref uint dst, in m256i src)
            => Store(refptr(ref dst), v32u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref long dst, in m256i src)
            => Store(refptr(ref dst), v64i(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_si256(ref ulong dst, in m256i src)
            => Store(refptr(ref dst), v64u(src));

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_ps(ref float dst, in m256 src)
            => Store(refptr(ref dst), src);

        [MethodImpl(Inline)]
        public static unsafe void _mm256_storeu_pd(ref double dst, in m256d src)
            => Store(refptr(ref dst), src);
    }

}