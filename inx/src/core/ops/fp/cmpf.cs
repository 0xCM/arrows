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
        /// <summary>
        /// __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> cmp(in Scalar128<float> lhs, in Scalar128<float> rhs, FpCmpMode mode)
            => CompareScalar(lhs,rhs, fpmode(mode));
   
        /// <summary>
        /// __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<double> cmp(in Scalar128<double> lhs, in Scalar128<double> rhs, FpCmpMode mode)
            => CompareScalar(lhs,rhs, fpmode(mode));
    
        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs, rhs);

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
        public static bool gteq(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool gteq(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarOrderedGreaterThanOrEqual(lhs, rhs);

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
        public static Vec128<float> ngteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareNotGreaterThanOrEqual(lhs,rhs);

        /// <summary>
        /// __m128d _mm_cmpnge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ngteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareNotGreaterThanOrEqual(lhs,rhs);

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
 
        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FpCmpMode mode)
            => Compare(lhs,rhs,fpmode(mode)).TestNaN();


        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool[] TestNaN(this Vector128<double> src)
            => array(src.GetElement(0).IsNaN(), src.GetElement(1).IsNaN());

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec256<float> lhs,in Vec256<float> rhs, FpCmpMode mode)
        {
            Span<float> vresult = stackalloc float[8];
            Compare(lhs,rhs,fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[8];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            bits[4] = double.IsNaN(vresult[4]);
            bits[5] = double.IsNaN(vresult[5]);
            bits[6] = double.IsNaN(vresult[6]);
            bits[7] = double.IsNaN(vresult[7]);
            return bits;

        }

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec256<double> lhs,in Vec256<double> rhs, FpCmpMode mode)
        {
            Span<double> vresult = stackalloc double[4];
            Compare(lhs,rhs,fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[4];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            return bits;

        }

    }

}