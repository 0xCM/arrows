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
    using static mfunc;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> ngt(Vec128<float> lhs, Vec128<float> rhs)
            => Sse.CompareNotGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(Vec128<double> lhs, Vec128<double> rhs)
            => Sse2.CompareNotGreaterThan(lhs, rhs);
        

    }


}