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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    
    partial class dinx
    {
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<sbyte> src, in Vec128<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<byte> src, in Vec128<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<short> src, in Vec128<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ushort> src, in Vec128<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<int> src, in Vec128<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<uint> src, in Vec128<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<long> src, in Vec128<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ulong> src, in Vec128<ulong> mask)
            => TestC(src, mask);                     


        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<sbyte> src, in Vec256<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<byte> src, in Vec256<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<short> src, in Vec256<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ushort> src, in Vec256<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<int> src, in Vec256<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<uint> src, in Vec256<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<long> src, in Vec256<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// _mm256_testc_si256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ulong> src, in Vec256<ulong> mask)
            => TestC(src, mask);                             


    }

}