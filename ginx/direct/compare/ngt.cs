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
        
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> ngt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Sse.CompareNotGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Sse2.CompareNotGreaterThan(lhs, rhs);
        

        

    }


}