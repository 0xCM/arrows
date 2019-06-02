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
        static bool[] TestNaN(this in Vector128<double> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN()
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(this in Vector128<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN()
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(this in Vector256<float> src)
            => array(
                src.GetElement(0).IsNaN(), 
                src.GetElement(1).IsNaN(),
                src.GetElement(2).IsNaN(), 
                src.GetElement(3).IsNaN(),
                src.GetElement(4).IsNaN(), 
                src.GetElement(5).IsNaN(),
                src.GetElement(6).IsNaN(), 
                src.GetElement(7).IsNaN()
                );

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<float> lhs,in Vec128<float> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).TestNaN();

        [MethodImpl(Inline)]
        public static Vec256<float> cmpf(in Vec256<float> lhs,in Vec256<float> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).ClearNaN();

        [MethodImpl(Inline)]
        public static Vec256<double> cmpf(in Vec256<double> lhs, in Vec256<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).ClearNaN();

        [MethodImpl(Inline)]
        public static bool[] cmpfr(ref Vec128<float> lhs, ref Vec128<float> rhs, FloatComparisonMode mode)
            => TestNaN(Compare(lhs,rhs,mode));

        [MethodImpl(Inline)]
        public static bool[] cmpfr(ref Vec128<double> lhs, ref Vec128<double> rhs, FloatComparisonMode mode)
            => TestNaN(Compare(lhs,rhs,mode));

        [MethodImpl(Inline)]
        public static Vec256<float> cmpfr(ref Vec256<float> lhs, ref Vec256<float> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).ClearNaN();

        [MethodImpl(Inline)]
        public static Vec256<double> cmpfr(ref Vec256<double> lhs, ref Vec256<double> rhs, FloatComparisonMode mode)
            => Compare(lhs,rhs,mode).ClearNaN();
    }
}