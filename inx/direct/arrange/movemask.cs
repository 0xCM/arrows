//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;

    partial class dinx
    {
        ///<intrinsic>int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec128<byte> src)
            => MoveMask(src);

        ///<intrinsic>int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec128<sbyte> src)
            => MoveMask(src);

        ///<intrinsic>int _mm_movemask_ps (__m128 a) MOVMSKPS reg, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec128<float> src)
            => MoveMask(src);

        ///<intrinsic>int _mm_movemask_pd (__m128d a) MOVMSKPD reg, xmm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec128<double> src)
            => MoveMask(src);

        ///<intrinsic>int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec256<sbyte> src)
            => MoveMask(src);

        ///<intrinsic>int _mm256_movemask_epi8 (__m256i a) VPMOVMSKB reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec256<byte> src)
            => MoveMask(src);
 
        ///<intrinsic>int _mm256_movemask_ps (__m256 a) VMOVMSKPS reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec256<float> src)
            => MoveMask(src);

        ///<intrinsic>int _mm256_movemask_pd (__m256d a) VMOVMSKPD reg, ymm</intrinsic>
        [MethodImpl(Inline)]
        public static int movemask(in Vec256<double> src)
            => MoveMask(src);
        
        //Move the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy the upper element from "a" to the upper element of "dst"
        ///<intrinsic>__m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm</intrinsic>
        public static Vec128<double> movescalar(in Vec128<double> src, in Vec128<double> dst)
            => MoveScalar(dst,src);
    }

}