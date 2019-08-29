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
        /// _mm_testc_si128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<short> lhs, in Vec128<short> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<int> lhs, in Vec128<int> rhs)
            => TestC(lhs, rhs);        
        
        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<long> lhs, in Vec128<long> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm_testc_si128 (__m128i a, __m128i b) PTEST xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => TestC(lhs, rhs);                     

        /// <summary>
        /// int _mm_testc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<float> lhs, in Vec128<float> rhs)
            => TestC(lhs, rhs);                     

        /// <summary>
        /// int _mm_testc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<double> lhs, in Vec128<double> rhs)
            => TestC(lhs, rhs);                     

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<short> lhs, in Vec256<short> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<int> lhs, in Vec256<int> rhs)
            => TestC(lhs, rhs);        
        
        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// int _mm256_testc_si256 (__m256i a, __m256i b) VPTEST ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<long> lhs, in Vec256<long> rhs)
            => TestC(lhs, rhs);        

        /// <summary>
        /// _mm256_testc_si256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => TestC(lhs, rhs);                             

        /// <summary>
        /// int _mm256_testc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<float> lhs, in Vec256<float> rhs)
            => TestC(lhs, rhs);                             

        /// <summary>
        /// int _mm256_testc_pd (__m256d a, __m256d b) VTESTPS ymm, ymm/m256
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<double> lhs, in Vec256<double> rhs)
            => TestC(lhs, rhs);                             

    }

}