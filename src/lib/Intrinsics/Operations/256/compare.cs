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
    using static inX;

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Vec256<float> compare(Vec256<float> lhs, Vec256<float> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);
        
        [MethodImpl(Inline)]
        public static Vec256<double> compare(Vec256<double> lhs, Vec256<double> rhs, FloatComparisonMode mode)
            => Avx2.Compare(lhs,rhs,mode);

    }

}