//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128 _mm_sqrt_ss (__m128 a) SQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> sqrt(in Scalar128<float> src)
            => SqrtScalar(src);

        /// <summary>
        /// _m128d _mm_sqrt_sd (__m128d a) SQRTSD xmm, xmm/64 
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> sqrt(in Scalar128<double> src)
            => SqrtScalar(src);

        /// <summary>
        /// __m128 _mm_sqrt_ps (__m128 a) SQRTPS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(in Vec128<float> src)
            => Sqrt(src);

        /// <summary>
        /// __m128d _mm_sqrt_pd (__m128d a) SQRTPD xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(in Vec128<double> src)
            => Sqrt(src);
 
        /// <summary>
        /// __m256 _mm256_sqrt_ps (__m256 a) VSQRTPS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> sqrt(in Vec256<float> src)
            => Sqrt(src);

        /// <summary>
        /// __m256d _mm256_sqrt_pd (__m256d a) VSQRTPD ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(in Vec256<double> src)
            => Sqrt(src);
 
        /// <summary>
        /// __m128 _mm_rsqrt_ps (__m128 a) RSQRTPS xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec128<float> rsqrt(Vec128<float> src)
            => ReciprocalSqrt(src);    
     
        /// <summary>
        /// __m128 _mm_rsqrt_ss (__m128 a) RSQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static ref Scalar128<float> rsqrt(ref Scalar128<float> src)
        {
            src = ReciprocalSqrtScalar(src);
            return ref src;
        }

        public static Span256<double> sqrt(Span256<double> src, Span256<double> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<float> sqrt(Span256<float> src, Span256<float> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Load(ref src.Block(block));
                vstore(dfp.sqrt(x), ref dst[block]);                
            }
            return dst;
        }

    }

}