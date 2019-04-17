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

    public partial class InX
    {
        
        [MethodImpl(Inline)]
        public static Vec128<short> hsub(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> hsub(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> hsub(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> hsub(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

 
    }

}