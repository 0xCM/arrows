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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class x86
    {
        /// <summary>
        /// __m256i _mm256_permutevar8x32_epi32 (__m256i a, __m256i idx) VPERMD ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_permutevar8x32_epi32(in m256i a, in m256i b)
            => PermuteVar8x32(v32i(a), v32i(b));

    }

}