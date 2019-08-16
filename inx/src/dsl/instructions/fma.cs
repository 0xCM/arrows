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
    using static System.Runtime.Intrinsics.X86.Fma;
    
    using static zfunc; 
    using static As;

    partial class x86
    {
        ///<intrinsic>__m256 _mm256_fmadd_ps (__m256 a, __m256 b, __m256 c) VFMADDPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_fmadd_ps(__m256 a, __m256 b, __m256 c)
            => MultiplyAdd(a,b,c);

        ///<intrinsic>__m256 _mm256_fnmadd_ps (__m256 a, __m256 b, __m256 c) VFNMADDPS ymm, ymm, ymm/m256</intrinsic>
        [MethodImpl(Inline)]
        public static __m256 _mm256_fnmadd_ps(__m256 a, __m256 b, __m256 c)
            => MultiplyAddNegated(a,b,c);

        //<intrinsic> __m128d _mm_fmadd_pd (__m128d a, __m128d b, __m128d c) VFMADDPD xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fmadd_pd(__m128d a, __m128d b, __m128d c)
            => MultiplyAdd(a,b,c);

        ///<intrinsic> __m128 _mm_fmadd_ps (__m128 a, __m128 b, __m128 c) VFMADDPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fmadd_ps(__m128 a, __m128 b, __m128 c)
            => MultiplyAdd(a,b,c);

        ///<intrinsic> __m256d _mm256_fmadd_pd(__m256d a, __m256d b, __m256d c) VFMADDPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fmadd_pd(__m256d a, __m256d b, __m256d c)
            => MultiplyAdd(a,b,c);

        ///<intrinsic> __m128d _mm_fnmadd_pd (__m128d a, __m128d b, __m128d c) VFNMADDPD xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fnmadd_pd(__m128d a, __m128d b, __m128d c)
            => MultiplyAddNegated(a,b,c);

        ///<intrinsic> __m128 _mm_fnmadd_ps (__m128 a, __m128 b, __m128 c) VFNMADDPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fnmadd_ps(__m128 a, __m128 b, __m128 c)
            => MultiplyAddNegated(a,b,c);

        ///<intrinsic> __m256d _mm256_fnmadd_pd (__m256d a, __m256d b, __m256d c) VFNMADDPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fnmadd_pd(__m256d a, __m256d b, __m256d c)
            => MultiplyAddNegated(a,b,c);

        ///<intrinsic> __m128d _mm_fnmadd_sd (__m128d a, __m128d b, __m128d c) VFNMADDSD xmm, xmm, xmm/m64
        [MethodImpl(Inline)]
        public static __m128d _mm_fnmadd_sd(__m128d a, __m128d b, __m128d c)
            => MultiplyAddNegatedScalar(a,b,c);

        ///<intrinsic> __m128 _mm_fnmadd_ss (__m128 a, __m128 b, __m128 c) VFNMADDSS xmm, xmm, xmm/m32
        [MethodImpl(Inline)]
        public static __m128 _mm_fnmadd_ss(__m128 a, __m128 b, __m128 c)
            => MultiplyAddNegatedScalar(a,b,c);

        ///<intrinsic> __m128d _mm_fmadd_sd (__m128d a, __m128d b, __m128d c) VFMADDSS xmm, xmm, xmm/m64
        [MethodImpl(Inline)]
        public static __m128d _mm_fmadd_sd(__m128d a, __m128d b, __m128d c)
            => MultiplyAddScalar(a,b,c);

        ///<intrinsic> __m128 _mm_fmadd_ss (__m128 a, __m128 b, __m128 c) VFMADDSS xmm, xmm, xmm/m32
        [MethodImpl(Inline)]
        public static __m128 _mm_fmadd_ss(__m128 a, __m128 b, __m128 c)
            => MultiplyAddScalar(a,b,c);

        ///<intrinsic> __m128d _mm_fmaddsub_pd (__m128d a, __m128d b, __m128d c) VFMADDSUBPD xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fmaddsub_pd(__m128d a, __m128d b, __m128d c)
            => MultiplyAddSubtract(a,b,c);

        ///<intrinsic> __m128 _mm_fmaddsub_ps (__m128 a, __m128 b, __m128 c) VFMADDSUBPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fmaddsub_ps(__m128 a, __m128 b, __m128 c)
            => MultiplyAddSubtract(a,b,c);

        ///<intrinsic> __m256d _mm256_fmaddsub_pd (__m256d a, __m256d b, __m256d c) VFMADDSUBPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fmaddsub_pd(__m256d a, __m256d b, __m256d c)
            => MultiplyAddSubtract(a,b,c);

        ///<intrinsic> __m256 _mm256_fmaddsub_ps (__m256 a, __m256 b, __m256 c) VFMADDSUBPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_fmaddsub_ps(__m256 a, __m256 b, __m256 c)
            => MultiplyAddSubtract(a,b,c);

        ///<intrinsic> __m256 _mm256_fmsub_ps (__m256 a, __m256 b, __m256 c) VFMSUBPS ymm, ymm, ymm/m256
        public static __m256 _mm256_fmsub_ps(__m256 a, __m256 b, __m256 c)
            => MultiplySubtract(a,b,c);

        ///<intrinsic> __m128 _mm_fmsub_ps (__m128 a, __m128 b, __m128 c) VFMSUBPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fmsub_ps(__m128 a, __m128 b, __m128 c)
            => MultiplySubtract(a,b,c);

        ///<intrinsic> __m256d _mm256_fmsub_pd (__m256d a, __m256d b, __m256d c) VFMSUBPD ymm, ymm,ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fmsub_pd(__m256d a, __m256d b, __m256d c)
            => MultiplySubtract(a,b,c);

        ///<intrinsic> __m128d _mm_fmsub_pd (__m128d a, __m128d b, __m128d c) VFMSUBPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fmsub_pd(__m128d a, __m128d b, __m128d c)
            => MultiplySubtract(a,b,c);

        ///<intrinsic> __m128d _mm_fmsubadd_pd (__m128d a, __m128d b, __m128d c) VFMSUBADDPD xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fmsubadd_pd(__m128d a, __m128d b, __m128d c)
            => MultiplySubtractAdd(a,b,c);

        ///<intrinsic> __m128 _mm_fmsubadd_ps (__m128 a, __m128 b, __m128 c) VFMSUBADDPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fmsubadd_ps(__m128 a, __m128 b, __m128 c)
            => MultiplySubtractAdd(a,b,c);

        ///<intrinsic> __m256d _mm256_fmsubadd_pd (__m256d a, __m256d b, __m256d c) VFMSUBADDPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fmsubadd_pd(__m256d a, __m256d b, __m256d c)
            => MultiplySubtractAdd(a,b,c);

        ///<intrinsic> __m256 _mm256_fmsubadd_ps (__m256 a, __m256 b, __m256 c) VFMSUBADDPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_fmsubadd_ps(__m256 a, __m256 b, __m256 c)
            => MultiplySubtractAdd(a,b,c);

        ///<intrinsic> __m128d _mm_fnmsub_pd(__m128d a, __m128d b, __m128d c) VFNMSUBPD xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128d _mm_fnmsub_pd(__m128d a, __m128d b, __m128d c)
            => MultiplySubtractNegated(a,b,c);

        ///<intrinsic> __m128 _mm_fnmsub_ps(__m128 a, __m128 b, __m128 c) VFNMSUBPS xmm, xmm, xmm/m128
        [MethodImpl(Inline)]
        public static __m128 _mm_fnmsub_ps(__m128 a, __m128 b, __m128 c)
            => MultiplySubtractNegated(a,b,c);

        ///<intrinsic> __m256d _mm256_fnmsub_pd(__m256d a, __m256d b, __m256d c) VFNMSUBPD ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256d _mm256_fnmsub_pd(__m256d a, __m256d b, __m256d c)
            => MultiplySubtractNegated(a,b,c);

        ///<intrinsic> __m256 _mm256_fnmsub_ps (__m256 a, __m256 b, __m256 c) VFNMSUBPS ymm, ymm, ymm/m256
        [MethodImpl(Inline)]
        public static __m256 _mm256_fnmsub_ps(__m256 a, __m256 b, __m256 c)
            => MultiplySubtractNegated(a,b,c);

        ///<intrinsic> __m128d _mm_fnmsub_sd (__m128d a, __m128d b, __m128d c) VFNMSUBSD xmm, xmm, xmm/m64
        [MethodImpl(Inline)]
        public static __m128d _mm_fnmsub_sd(__m128d a, __m128d b, __m128d c)
            => MultiplySubtractNegatedScalar(a,b,c);

        ///<intrinsic> __m128 _mm_fnmsub_ss (__m128 a, __m128 b, __m128 c) VFNMSUBSS xmm, xmm, xmm/m32
        [MethodImpl(Inline)]
        public static __m128 _mm_fnmsub_ss(__m128 a, __m128 b, __m128 c)
            => MultiplySubtractNegatedScalar(a,b,c);
 
        ///<intrinsic> __m128 _mm_fmsub_ss (__m128 a, __m128 b, __m128 c) VFMSUBSS xmm, xmm, xmm/m32
        [MethodImpl(Inline)]
        public static __m128 _mm_fmsub_ss(__m128 a, __m128 b, __m128 c)
            => MultiplySubtractScalar(a,b,c);
 
        ///<intrinsic> __m128d _mm_fmsub_sd (__m128d a, __m128d b, __m128d c) VFMSUBSD xmm, xmm, xmm/m64
        [MethodImpl(Inline)]
        public static __m128d _mm_fmsub_sd(__m128d a, __m128d b, __m128d c)
            => MultiplySubtractScalar(a,b,c); 
    }

}