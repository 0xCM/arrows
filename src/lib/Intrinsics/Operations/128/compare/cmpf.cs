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
    
    using static zcore;
    using static inxfunc;


    partial class InX
    {
        [MethodImpl(Inline)]
        public static Num128<float> cmpf(Num128<float> lhs, Num128<float> rhs, FloatComparisonMode mode)
            => Avx2.CompareScalar(lhs,rhs,mode);

        [MethodImpl(Inline)]
        public static Num128<double> cmpf(Num128<double> lhs, Num128<double> rhs, FloatComparisonMode mode)
            => Avx2.CompareScalar(lhs,rhs,mode);

        [MethodImpl(Inline)]
        public static Vec128<float> cmpf(Vec128<float> lhs, Vec128<float> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);
        
        [MethodImpl(Inline)]
        public static Vec128<double> cmpf(Vec128<double> lhs, Vec128<double> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);
    }

}