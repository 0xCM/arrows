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

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Num128<float> lteq(Num128<float> lhs, Num128<float> rhs)
            => Sse.CompareLessThanOrEqualScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> lteq(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareLessThanOrEqualScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> lteq(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareLessThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareLessThanOrEqual(lhs, rhs);
    }


}