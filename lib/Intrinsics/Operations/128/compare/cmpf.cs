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
        public static Num128<float> cmpf(in Num128<float> lhs, in Num128<float> rhs, FloatComparisonMode mode)
            => Avx2.CompareScalar(lhs,rhs,mode);

        [MethodImpl(Inline)]
        public static Num128<double> cmpf(in Num128<double> lhs, in Num128<double> rhs, FloatComparisonMode mode)
            => Avx2.CompareScalar(lhs,rhs,mode);

        [MethodImpl(Inline)]
        public static Vec128<float> cmpf(in Vec128<float> lhs, in Vec128<float> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);
        
        [MethodImpl(Inline)]
        public static Vec128<double> cmpf(in Vec128<double> lhs, in Vec128<double> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);
    }

}