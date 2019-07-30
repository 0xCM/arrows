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
    
    
    using static zfunc;

    
    partial class dinx
    {

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<float> lhs,in Vec128<float> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<float> lhs, in Num128<float> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs,mode).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool cmpf(in Num128<double> lhs, in Num128<double> rhs, FloatComparisonMode mode)
            => CompareScalar(lhs,rhs, mode).IsNaN(0);
         
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