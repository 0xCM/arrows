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
        /// _mm256_sub_epi64 (__m256i a, __m256i b) VPSUBQ ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_sub_epi64(in m256i a, in m256i b)
            => Subtract(v64i(a),v64i(b));

        /// <summary>
        /// _mm256_sub_epi32 (__m256i a, __m256i b) VPSUBD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_sub_epi32(in m256i a, in m256i b)
            => Subtract(v32i(a),v32i(b));

    }

}