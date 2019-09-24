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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static zfunc;

    public partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector128<byte> min(Vector128<byte> xmm0, Vector128<byte> xmm1)
            => Min(xmm0, xmm1);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> min(Vector128<sbyte> xmm0, Vector128<sbyte> xmm1)
            => Min(xmm0, xmm1);

        [MethodImpl(Inline)]
        public static Vector128<short> min(Vector128<short> xmm0, Vector128<short> xmm1)
            => Min(xmm0, xmm1);

        /// <summary>
        /// __m128i _mm_min_epu16 (__m128i a, __m128i b) PMINUW xmm, xmm/m128
        /// </summary>
        /// <param name="xmm0"></param>
        /// <param name="xmm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<ushort> min(Vector128<ushort> xmm0, Vector128<ushort> xmm1)
            => Min(xmm0, xmm1);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="xmm0"></param>
        /// <param name="xmm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<int> min(Vector128<int> xmm0, Vector128<int> xmm1)
            => Min(xmm0, xmm1);

        /// <summary>
        /// __m128i _mm_min_epu32 (__m128i a, __m128i b) PMINUD xmm, xmm/m128
        /// </summary>
        /// <param name="xmm0"></param>
        /// <param name="xmm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector128<uint> min(Vector128<uint> xmm0, Vector128<uint> xmm1)
            => Min(xmm0, xmm1);

        /// <summary>
        /// __m256i _mm256_min_epu8 (__m256i a, __m256i b) VPMINUB ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="ymm0"></param>
        /// <param name="ymm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<byte> min(Vector256<byte> ymm0, Vector256<byte> ymm1)
            => Min(ymm0, ymm1);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> min(Vector256<sbyte> ymm0, Vector256<sbyte> ymm1)
            => Min(ymm0, ymm1);

        [MethodImpl(Inline)]
        public static Vector256<short> min(Vector256<short> ymm0, Vector256<short> ymm1)
            => Min(ymm0, ymm1);

        [MethodImpl(Inline)]
        public static Vector256<ushort> min(Vector256<ushort> ymm0, Vector256<ushort> ymm1)
            => Min(ymm0, ymm1);

        [MethodImpl(Inline)]
        public static Vector256<int> min(Vector256<int> ymm0, Vector256<int> ymm1)
            => Min(ymm0, ymm1);

        /// <summary>
        /// __m256i _mm256_min_epu32 (__m256i a, __m256i b) VPMINUD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="ymm0"></param>
        /// <param name="ymm1"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<uint> min(Vector256<uint> ymm0, Vector256<uint> ymm1)
            => Min(ymm0, ymm1);


    }
}