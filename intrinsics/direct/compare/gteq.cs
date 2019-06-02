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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    


    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> gteq(Vec128<float> lhs, Vec128<float> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gteq(Vec128<double> lhs, Vec128<double> rhs)
            => CompareGreaterThanOrEqual(lhs, rhs);



    }
}