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
    using static zfunc;    

    partial class dfp
    {

        /// <summary>
        /// int _mm_testc_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<float> src, in Vec128<float> mask)
            => TestC(src, mask);                     

        /// <summary>
        /// int _mm_testc_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec128<double> src, in Vec128<double> mask)
            => TestC(src, mask);                     

        /// <summary>
        /// int _mm256_testc_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<float> src, in Vec256<float> mask)
            => TestC(src, mask);                             

        /// <summary>
        /// int _mm256_testc_pd (__m256d a, __m256d b) VTESTPS ymm, ymm/m256
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        [MethodImpl(Inline)]
        public static bool testc(in Vec256<double> src, in Vec256<double> mask)
            => TestC(src, mask);                             


    }

}