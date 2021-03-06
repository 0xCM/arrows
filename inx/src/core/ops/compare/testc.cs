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
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        ///     ZF := 1
        /// ELSE
        ///     ZF := 0        
        /// <algorithm>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<sbyte> src, Vector128<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<byte> src, Vector128<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<short> src, Vector128<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<ushort> src, Vector128<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<int> src, Vector128<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<uint> src, Vector128<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<long> src, Vector128<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector128<ulong> src, Vector128<ulong> mask)
            => TestC(src, mask);                     

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<sbyte> src, Vector256<sbyte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<byte> src, Vector256<byte> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<short> src, Vector256<short> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<ushort> src, Vector256<ushort> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<int> src, Vector256<int> mask)
            => TestC(src, mask);        
        
        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<uint> src, Vector256<uint> mask)
            => TestC(src, mask);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<long> src, Vector256<long> mask)
            => TestC(src, mask);        

        /// <summary>
        /// _mm256_testc_si256
        /// Returns true if all source bits identified by a mask are on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(Vector256<ulong> src, Vector256<ulong> mask)
            => TestC(src, mask);                             
    }

}