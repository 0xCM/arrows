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
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    
    using static As;

    partial class x86
    {
        /// <intrinsic>__m128i _mm_add_epi8 (__m128i a, __m128i b) PADDB xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi8(in __m128i a, in __m128i b)
            => Add(v8i(a), v8i(b));

        /// <intrinsic>__m128i _mm_add_epi16 (__m128i a, __m128i b) PADDW xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi16(in __m128i a, in __m128i b)
            => Add(v16i(a), v16i(b));

        /// <intrinsic>_mm_add_epi32 (__m128i a, __m128i b) PADDD xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi32(in __m128i a, in __m128i b)
            => Add(v32i(a), v32i(b));

        /// <intrinsic>__m128i _mm_add_epi64 (__m128i a, __m128i b) PADDQ xmm, xmm/m128</intrinsic>
        [MethodImpl(Inline)]
        public static __m128i _mm_add_epi64(in __m128i a, in __m128i b)
            => Add(v64i(a), v64i(b));

        /// <intrinsic>void _mm_storeu_pd (double* mem_addr, __m128d a) MOVUPD m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_pd(ref double dst, in __m128d src)
            => Store(refptr(ref dst), src);

        /// <intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ulong dst, in __m128i src)
            => Store(refptr(ref dst), v64u(src));

        /// <intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref long dst, in __m128i src)
            => Store(refptr(ref dst), v64i(src));
 
        /// <intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref uint dst, in __m128i src)
            => Store(refptr(ref dst), v32u(src));

        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref short dst, in __m128i src)
            => Store(refptr(ref dst), v16i(src));

        /// <summary>
        /// Writes the data from the source vector to a referenced location
        /// </summary>
        /// <param name="dst"></param>
        /// <param name="src"></param>
        /// <intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref sbyte dst, in __m128i src)
            => Store(refptr(ref dst), v8i(src));

        /// <intrinsic>_mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref byte dst, in __m128i src)
            => Store(refptr(ref dst), v8u(src));


        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref ushort dst, in __m128i src)
            => Store(refptr(ref dst), v16u(src));

        /// <intrinsic>void _mm_storeu_si128 (__m128i* mem_addr, __m128i a) MOVDQU m128, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static unsafe void _mm_storeu_si128(ref int dst, in __m128i src)
            => Store(refptr(ref dst), v32i(src));
   }

}