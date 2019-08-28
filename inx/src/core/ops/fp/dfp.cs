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
    using static System.Runtime.Intrinsics.X86.Fma;        
    
    using static As;
    using static zfunc;    


    /// <summary>
    /// Defines direct floating-point operations
    /// </summary>
    public static partial class dfp
    {

        /// <summary>
        /// _mm_mul_ps:
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);        

        /// <summary>
        /// _mm_mul_pd:
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);
        
        /// <summary>
        /// _mm256_mul_ps
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        /// <summary>
        /// _mm256_mul_pd
        /// Multiplies corresponding components and returns the result
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);

        /// <summary>
        /// _mm_move_ss:
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        public static Vec128<float> movescalar(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.MoveScalar(rhs,lhs);

        /// <summary>
        /// _mm_move_sd:
        /// Moves the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy 
        /// the upper element from "a" to the upper element of "dst"
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        public static Vec128<double> movescalar(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.MoveScalar(lhs,rhs);

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

        /// <summary>
        /// __m128 _mm_floor_ps (__m128 a) ROUNDPS xmm, xmm/m128, imm8(9)
        /// </summary>
        /// <param name="src">The source vector</param>
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
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Divide(lhs, rhs);
 

        [MethodImpl(Inline)]
        public static Vec128<float> neq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareNotEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> neq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareNotEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> nlt(Vec128<float> lhs, Vec128<float> rhs)
            => CompareNotLessThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> nlt(Vec128<double> lhs, Vec128<double> rhs)
            => CompareNotLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> ngt(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareNotGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareNotGreaterThan(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<float> lteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareLessThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareLessThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> lt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareLessThan(lhs,rhs));
        
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> lt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareLessThan(lhs,rhs));
    
        [MethodImpl(Inline)]
        public static Vec256Cmp<float> lt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> lt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> gt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareGreaterThan(lhs,rhs));
        
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> gt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<float> gt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> gt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<double> eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<float> eq(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> eq(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool[] TestNaN(this Vector128<double> src)
            => array(src.GetElement(0).IsNaN(), src.GetElement(1).IsNaN());

    }
}