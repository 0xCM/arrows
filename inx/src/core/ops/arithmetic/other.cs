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
        
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        ///  __m128i _mm_sad_epu8 (__m128i a, __m128i b) PSADBW xmm, xmm/m128
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        public static Vec128<ushort> sad(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => SumAbsoluteDifferences(lhs,rhs);

        /// <summary>
        /// __m256i _mm256_sad_epu8 (__m256i a, __m256i b) VPSADBW ymm, ymm, ymm/m256
        /// Computes the absolute differences of packed unsigned 8-bit integers in a and b, 
        /// then horizontally sums each consecutive 8 differences to produce four 
        /// unsigned 16-bit integers, and pack these unsigned 16-bit integers in the low 
        /// 16 bits of 64-bit elements in dst.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        public static Vec256<ushort> sad(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => SumAbsoluteDifferences(lhs,rhs);


    }

}