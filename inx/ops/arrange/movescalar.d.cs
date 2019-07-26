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

        /// <summary>
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        ///<intrinsic>__m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm</intrinsic>
        public static Vec128<float> movescalar(in Vec128<float> a, in Vec128<float> b)
            => MoveScalar(b,a);


        //Move the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy the upper element from "a" to the upper element of "dst"
        ///<intrinsic>__m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm</intrinsic>
        public static Vec128<double> movescalar(in Vec128<double> a, in Vec128<double> b)
            => MoveScalar(a,b);
 


    }

}