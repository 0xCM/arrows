//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a) ROUNDSD xmm, xmm/m128, imm8(10) 
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> ceil(in Vec128<float> src)
            => Ceiling(src);

        /// <summary>
        /// __m128d _mm_ceil_pd (__m128d a) ROUNDPD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ceil(in Vec128<double> src)
            => Ceiling(src);

        /// <summary>
        /// __m256 _mm256_ceil_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> ceil(in Vec256<float> src)
            => Ceiling(src);

        /// <summary>
        /// __m256 _mm256_ceil_pd (__m256 a) VROUNDPS ymm, ymm/m256, imm8(10)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> ceil(in Vec256<double> src)
            => Ceiling(src);


        [MethodImpl(Inline)]
        public static ref Num128<float> ceil(ref Num128<float> src)
        {
            src = CeilingScalar(src);
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref Num128<double> ceil(ref Num128<double> src)
        {
            src = CeilingScalar(src);
            return ref src;
        }

 
    }

}