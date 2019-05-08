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
    
    
    using static mfunc;

    public partial class dinx
    {
        
        [MethodImpl(Inline)]
        public static Vec128<short> subh(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> subh(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> subh(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> subh(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.HorizontalSubtract(lhs, rhs);

 
    }

}