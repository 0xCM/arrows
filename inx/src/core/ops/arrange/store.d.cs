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
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<sbyte> src, ref sbyte dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<byte> src, ref byte dst)
            => StoreAligned(refptr(ref dst), src);
        
        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<short> src, ref short dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<ushort> src, ref ushort dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<int> src, ref int dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<uint> src, ref uint dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<long> src, ref long dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm_store_si128 (__m128i* mem_addr, __m128i a) MOVDQA m128, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec128<ulong> src, ref ulong dst)
            => StoreAligned(refptr(ref dst), src); 

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<sbyte> src, ref sbyte dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<byte> src, ref byte dst)
            => StoreAligned(refptr(ref dst), src);
        
        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<short> src, ref short dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<ushort> src, ref ushort dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<int> src, ref int dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<uint> src, ref uint dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<long> src, ref long dst)
            => StoreAligned(refptr(ref dst), src);

        /// <summary>
        /// void _mm256_store_si256 (__m256i * mem_addr, __m256i a) MOVDQA m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The memory target</param>
        [MethodImpl(Inline)]
        public static unsafe void movdqa(in Vec256<ulong> src, ref ulong dst)
            => StoreAligned(refptr(ref dst), src); 
    }
}