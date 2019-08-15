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
    using static System.Runtime.Intrinsics.X86.FloatComparisonMode;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
            
    
    using static zfunc;

    
    partial class dinx
    {
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