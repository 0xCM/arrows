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
        public static Vec128<float> lteq(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareLessThanOrEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareLessThanOrEqual(lhs, rhs);
    
        [MethodImpl(Inline)]
        public static bool lteq(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs, rhs);

    
    }


}