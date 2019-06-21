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
        /// Multiplies corresponding lo input vector components 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <remarks>
        /// a[0]:uint * b[0]:uint -> c[0]:ulong
        /// a[1]:uint * b[1]:uint -> c[1]:ulong
        /// a[2]:uint * b[2]:uint -> c[2]:ulong
        /// a[3]:uint * b[3]:uint -> c[3]:ulong
        /// </remarks>
        /// <intrinsic>__m256i _mm256_mul_epu32 (__m256i a, __m256i b) VPMULUDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_mul_epu32(in m256i a, in m256i b)
            => Multiply(v32u(a),v32u(b));

        /// <summary>
        /// Multiplies corresponding input vector components components
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <remarks>
        /// a[0]:int * b[0]:int -> c[0]:long
        /// a[1]:int * b[1]:int -> c[1]:long
        /// a[2]:int * b[2]:int -> c[2]:long
        /// a[3]:int * b[3]:int -> c[3]:long
        /// </remarks>
        /// <intrinsic>_mm256_mul_epi32 (__m256i a, __m256i b) VPMULDQ ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_mul_epi32(in m256i a, in m256i b)
            => Multiply(v32i(a),v32i(b));
    
    
    }

}