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
    
    
    using static zfunc;
    using static mfunc;

    
    partial class dinx
    {
        static bool IsNaN(double test)
            => double.IsNaN(test);

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector128<double> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1))
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector128<float> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1)),
                IsNaN(src.GetElement(2)), 
                IsNaN(src.GetElement(3))
                );

        [MethodImpl(Inline)]
        static bool[] TestNaN(Vector256<float> src)
            => array(
                IsNaN(src.GetElement(0)), 
                IsNaN(src.GetElement(1)),
                IsNaN(src.GetElement(2)), 
                IsNaN(src.GetElement(3)),
                IsNaN(src.GetElement(4)), 
                IsNaN(src.GetElement(5)),
                IsNaN(src.GetElement(6)), 
                IsNaN(src.GetElement(7))
                );


        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<float> lhs,in Vec128<float> rhs, FloatComparisonMode mode)
            => TestNaN(Avx2.Compare(lhs,rhs,mode));

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> lhs,in Vec128<double> rhs, FloatComparisonMode mode)
            => TestNaN(Avx2.Compare(lhs,rhs,mode));

        [MethodImpl(Inline)]
        public static Vec256<float> cmpf(in Vec256<float> lhs,in Vec256<float> rhs, FloatComparisonMode mode)
            => clearNaN(Avx2.Compare(lhs,rhs,mode));

        [MethodImpl(Inline)]
        public static Vec256<double> cmpf(in Vec256<double> lhs, in Vec256<double> rhs, FloatComparisonMode mode)
            => clearNaN(Avx2.Compare(lhs,rhs,mode));



    }


}