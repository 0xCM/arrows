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

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_maskload_epi32 (int const* mem_addr, __m128i mask) VPMASKMOVD xmm, xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<int> maskload(ref int src, Vec128<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<float> maskload(ref float src, Vec128<float> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m128 _mm_maskload_ps (float const * mem_addr, __m128i mask) VMASKMOVPS xmm,xmm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec128<double> maskload(ref double src, Vec128<double> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<int> maskload(ref int src, Vec256<int> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi32 (int const* mem_addr, __m256i mask) VPMASKMOVD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> maskload(ref uint src, Vec256<uint> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<long> maskload(ref long src, Vec256<long> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256i _mm256_maskload_epi64 (__int64 const* mem_addr, __m256i mask) VPMASKMOVQ ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> maskload(ref ulong src, Vec256<ulong> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<float> maskload(ref float src, Vec256<float> mask)
            => MaskLoad(refptr(ref src), mask);

        /// <summary>
        /// __m256d _mm256_maskload_pd (double const * mem_addr, __m256i mask) VMASKMOVPD ymm, ymm, m256
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="mask">Hi bit on selects the memory, otherwise set to zero</param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<double> maskload(ref double src, Vec256<double> mask)
            => MaskLoad(refptr(ref src), mask);


    }

}