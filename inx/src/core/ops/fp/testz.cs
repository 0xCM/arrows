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
        /// int _mm_testz_ps (__m128 a, __m128 b) VTESTPS xmm, xmm/m128
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<float> src, in Vec128<float> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm_testz_pd (__m128d a, __m128d b) VTESTPD xmm, xmm/m128
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec128<double> src, in Vec128<double> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_ps (__m256 a, __m256 b) VTESTPS ymm, ymm/m256
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<float> src, in Vec256<float> mask)
            => TestZ(src,mask);        

        /// <summary>
        /// int _mm256_testz_pd (__m256d a, __m256d b) VTESTPD ymm, ymm/m256
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz(in Vec256<double> src, in Vec256<double> mask)
            => TestZ(src,mask);        


    }

}