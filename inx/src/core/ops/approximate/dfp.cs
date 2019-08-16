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
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static As;
    using static zfunc;    
    using static AsInX;

    public static class dfp
    {

        /// <summary>
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        ///<intrinsic>__m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm</intrinsic>
        public static Vec128<float> movescalar(in Vec128<float> a, in Vec128<float> b)
            => Avx2.MoveScalar(b,a);


        /// Moves the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy 
        /// the upper element from "a" to the upper element of "dst"
        ///<intrinsic>__m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm</intrinsic>
        public static Vec128<double> movescalar(in Vec128<double> a, in Vec128<double> b)
            => Avx2.MoveScalar(a,b);


        [MethodImpl(Inline)]
        public static Vec128<float> ceil(in Vec128<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec128<double> ceil(in Vec128<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<float> ceil(in Vec256<float> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static Vec256<double> ceil(in Vec256<double> src)
            => Ceiling(src);

        [MethodImpl(Inline)]
        public static void ceil(in Vec128<float> src, ref float dst)
            => vstore(ceil(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec128<double> src, ref double dst)
            => vstore(ceil(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec256<float> src, ref float dst)
            => vstore(ceil(src), ref dst);

        [MethodImpl(Inline)]
        public static void ceil(in Vec256<double> src, ref double dst)
            => vstore(ceil(src), ref dst);

        [MethodImpl(Inline)]
        public static Vec128<float> floor(Vec128<float> src)
            => Floor(src);

        [MethodImpl(Inline)]
        public static Vec128<double> floor(Vec128<double> src)
            => Floor(src);
        
        [MethodImpl(Inline)]
        public static Vec256<float> floor(Vec256<float> src)
            => Floor(src);

        [MethodImpl(Inline)]
        public static Vec256<double> floor(Vec256<double> src)
            => Floor(src);

        [MethodImpl(Inline)]
        public static void floor(Vec128<float> src, ref float dst)
            => vstore(floor(src), ref dst);

        [MethodImpl(Inline)]
        public static void floor(Vec128<double> src, ref double dst)
            => vstore(floor(src), ref dst);

        [MethodImpl(Inline)]
        public static void floor(Vec256<float> src, ref float dst)
            => vstore(floor(src), ref dst);

        [MethodImpl(Inline)]
        public static void floor(Vec256<double> src, ref double dst)
            => vstore(floor(src), ref dst);


        [MethodImpl(Inline)]
        public static Vec128<float> sqrt(in Vec128<float> src)
            => Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec128<double> sqrt(in Vec128<double> src)
            => Sqrt(src);
 
        [MethodImpl(Inline)]
        public static Vec256<float> sqrt(in Vec256<float> src)
            => Sqrt(src);

        [MethodImpl(Inline)]
        public static Vec256<double> sqrt(in Vec256<double> src)
            => Sqrt(src);


        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static void div(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => vstore(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void div(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => vstore(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static void div(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => vstore(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void div(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => vstore(Divide(lhs, rhs), ref dst);

    }

}