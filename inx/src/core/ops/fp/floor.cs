//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    
    using static As;
    using static AsIn;

    partial class dfp
    {
        /// <summary>
        ///  __m128 _mm_load_ss (float const* mem_address) MOVSS xmm, m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<float> scalar(in float src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        /// <summary>
        ///  __m128d _mm_load_sd (double const* mem_address) MOVSD xmm, m64
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<double> scalar(in double src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> floor(Vec128<float> src)
            => Floor(src);

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> floor(Vec128<double> src)
            => Floor(src);
        
        /// <summary>
        /// __m256 _mm256_floor_ps (__m256 a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> floor(Vec256<float> src)
            => Floor(src);

        /// <summary>
        ///  __m256d _mm256_floor_pd (__m256d a) VROUNDPS ymm, ymm/m256, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> floor(Vec256<double> src)
            => Floor(src);
 
         [MethodImpl(Inline)]
        public static ref Scalar128<float> floor(ref Scalar128<float> src)
        {
            src = FloorScalar(src);
            return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref Scalar128<double> floor(ref Scalar128<double> src)
        {
            src = FloorScalar(src);
            return ref src;
        }


    }

}