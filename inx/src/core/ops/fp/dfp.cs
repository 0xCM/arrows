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
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        ///<intrinsic>__m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm</intrinsic>
        public static Vec128<float> movescalar(in Vec128<float> a, in Vec128<float> b)
            => Avx2.MoveScalar(b,a);

        /// <summary>
        /// Moves the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy 
        /// the upper element from "a" to the upper element of "dst"
        /// </summary>
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
 
         // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<float> mulAdd(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAdd(x,y,z);
                    
        // dst = x*y + z
        [MethodImpl(Inline)]
        public static Vec128<double> mulAdd(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<float> mulAddNegated(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<double> mulAddNegated(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<float> mulAddSub(in Vec128<float> x, in Vec128<float> y, in Vec128<float> z)
            => MultiplyAddSubtract(x,y,z);

        [MethodImpl(Inline)]
        public static Vec128<double> mulAddSub(in Vec128<double> x, in Vec128<double> y, in Vec128<double> z)
            => MultiplyAddSubtract(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAdd(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAdd(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAdd(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAddNegated(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAddNegated(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddNegated(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<float> mulAddSub(in Vec256<float> x, in Vec256<float> y, in Vec256<float> z)
            => MultiplyAddSubtract(x,y,z);

        [MethodImpl(Inline)]
        public static Vec256<double> mulAddSub(in Vec256<double> x, in Vec256<double> y, in Vec256<double> z)
            => MultiplyAddSubtract(x,y,z);

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
        public static bool[] cmpf(in Vec128<float> lhs,in Vec128<float> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

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
        static bool[] TestNaN(this Vector128<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool[] TestNaN(this Vector128<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN()
                );

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<float> src, int index)
                => src.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<double> src, int index)
                => src.GetElement(index).IsNaN();    
    }

}