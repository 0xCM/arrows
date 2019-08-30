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

    partial class dfpx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> Div(this Vec128<float> lhs, in Vec128<float> rhs)
            => dfp.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> Div(this Vec128<double> lhs, in Vec128<double> rhs)
            => dfp.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> Div(this Vec256<float> lhs, in Vec256<float> rhs)
            => dfp.div(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> Div(this Vec256<double> lhs, in Vec256<double> rhs)
            => dfp.div(in lhs, in rhs);


    }
}