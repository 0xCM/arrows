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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class x86
    {
        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <intrinsic>__m256i _mm256_or_si256 (__m256i a, __m256i b) VPOR ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_or_si256(in m256i a, in m256i b)
            => Or(a,b);

    }

}