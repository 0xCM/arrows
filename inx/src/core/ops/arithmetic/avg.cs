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

     partial class dinx
     {
          /// <summary>
          /// __m128i _mm_avg_epu8 (__m128i a, __m128i b) PAVGB xmm, xmm/m128
          /// </summary>
          /// <param name="lhs"></param>
          /// <param name="rhs"></param>
          /// <returns></returns>
          [MethodImpl(Inline)]          
          public static Vec128<byte> avg(in Vec128<byte> lhs, in Vec128<byte> rhs)
               => Average(lhs,rhs);

          /// <summary>
          /// __m128i _mm_avg_epu16 (__m128i a, __m128i b) PAVGW xmm, xmm/m128
          /// </summary>
          /// <param name="lhs"></param>
          /// <param name="rhs"></param>
          [MethodImpl(Inline)]          
          public static Vec128<ushort> avg(in Vec128<ushort> lhs,in Vec128<ushort> rhs)
               => Average(lhs,rhs);

          /// <summary>
          /// __m256i _mm256_avg_epu8 (__m256i a, __m256i b) VPAVGB ymm, ymm, ymm/m256
          /// </summary>
          /// <param name="lhs"></param>
          /// <param name="rhs"></param>
          /// <returns></returns>
          [MethodImpl(Inline)]          
          public static Vec256<byte> avg(in Vec256<byte> lhs,in Vec256<byte> rhs)
               => Average(lhs,rhs);

          /// <summary>
          ///  __m256i _mm256_avg_epu16 (__m256i a, __m256i b) VPAVGW ymm, ymm, ymm/m256
          /// </summary>
          /// <param name="lhs"></param>
          /// <param name="rhs"></param>
          /// <returns></returns>
          [MethodImpl(Inline)]          
          public static Vec256<ushort> avg(in Vec256<ushort> lhs,in Vec256<ushort> rhs)
               => Average(lhs,rhs);
     }

}
