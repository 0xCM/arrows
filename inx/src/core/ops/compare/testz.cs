//-----------------------------------------------------------------------------
// Copymask   :  (c) Chris Moore, 2019
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
    using Avx = System.Runtime.Intrinsics.X86.Avx;   
    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        /// <algorithm>
        /// IF (a[127:0] AND b[127:0] == 0)
        /// 	ZF := 1
        /// ELSE
        /// 	ZF := 0
        /// FI
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<byte> src, Vector128<byte> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<sbyte> src, Vector128<sbyte> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<short> src, Vector128<short> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<ushort> src, Vector128<ushort> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<int> src, Vector128<int> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<uint> src, Vector128<uint> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<long> src, Vector128<long> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector128<ulong> src, Vector128<ulong> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<sbyte> src, Vector256<sbyte> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<byte> src, Vector256<byte> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<short> src, Vector256<short> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<ushort> src, Vector256<ushort> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<int> src, Vector256<int> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<uint> src, Vector256<uint> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<long> src, Vector256<long> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// Returns true if all source bits identified by a mask are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        /// <algorithm>
        /// IF (a[255:0] AND b[255:0] == 0)
        /// 	ZF := 1
        /// ELSE
        /// 	ZF := 0
        /// FI
        /// </algorithm>
        [MethodImpl(Inline)]
        public static bool testz(Vector256<ulong> src, Vector256<ulong> mask)
            => TestZ(src,mask);        
    }    
}