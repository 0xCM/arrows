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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dfp
    {

        [MethodImpl(Inline)]
        public static bool gteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool gt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool lteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool neq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedNotEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool neq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedNotEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool lt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);                

        [MethodImpl(Inline)]
        public static bool lt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);

        /// <summary>
        /// __m128 _mm_cmpge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> gteq(Vec128<float> lhs, Vec128<float> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_cmpge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> gteq(Vec128<double> lhs, Vec128<double> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);

        /// <summary>
        ///  __m128d _mm_cmpnlt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> nlt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareNotLessThan(lhs,rhs));

        /// <summary>
        /// __m128 _mm_cmpnlt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> nlt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareNotLessThan(lhs,rhs));

        /// <summary>
        /// __m128 _mm_cmpnge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> ngteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareNotGreaterThanOrEqual(lhs,rhs));

        /// <summary>
        /// __m128d _mm_cmpnge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> ngteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareNotGreaterThanOrEqual(lhs,rhs));

        /// <summary>
        /// __m128 _mm_cmpneq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(4)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> neq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareNotEqual(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_cmpneq_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(4)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> neq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareNotEqual(lhs, rhs);

        /// <summary>
        /// __m128 _mm_cmpnlt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> nlt(Vec128<float> lhs, Vec128<float> rhs)
            => CompareNotLessThan(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_cmpnlt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> nlt(Vec128<double> lhs, Vec128<double> rhs)
            => CompareNotLessThan(lhs, rhs);

        /// <summary>
        /// __m128 _mm_cmpngt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> ngt(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareNotGreaterThan(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_cmpngt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareNotGreaterThan(lhs, rhs);
 
        /// <summary>
        /// __m128 _mm_cmple_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> lteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareLessThanOrEqual(lhs, rhs);
        
        /// <summary>
        /// __m128d _mm_cmple_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareLessThanOrEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        /// <summary>
        ///  __m128 _mm_cmplt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> lt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareLessThan(lhs,rhs));
        
        /// <summary>
        /// __m128d _mm_cmplt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> lt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareLessThan(lhs,rhs));
    
        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256Cmp<float> lt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8 
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256Cmp<double> lt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

        /// <summary>
        /// __m128 _mm_cmpgt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(6)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> gt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareGreaterThan(lhs,rhs));
        
        /// <summary>
        /// __m128d _mm_cmpgt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(6)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> gt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareGreaterThan(lhs,rhs));

        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256Cmp<float> gt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling));

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm,ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256Cmp<double> gt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs,FloatComparisonMode.OrderedGreaterThanNonSignaling));

        /// <summary>
        ///  __m128 _mm_cmpeq_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m128d _mm_cmpeq_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(0)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareEqual(lhs,rhs));

        /// <summary>
        /// __m256 _mm256_cmp_ps (__m256 a, __m256 b, const int imm8) VCMPPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec256Cmp<float> eq(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        /// <summary>
        /// __m256d _mm256_cmp_pd (__m256d a, __m256d b, const int imm8) VCMPPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
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