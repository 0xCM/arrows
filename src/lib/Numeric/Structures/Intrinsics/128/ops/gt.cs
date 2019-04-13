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
    using static x86;

    partial class Vec128
    {


        [MethodImpl(Inline)]
        public static Vec128<sbyte> gt(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse42.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> gt(Vec128<short> lhs, Vec128<short> rhs)
            => Sse42.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> gt(Vec128<int> lhs, Vec128<int> rhs)
            => Sse42.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> gt(Vec128<float> lhs, Vec128<float> rhs)
            => Sse.CompareGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gt(Vec128<double> lhs, Vec128<double> rhs)
            => Sse42.CompareGreaterThan(lhs, rhs);


    }


}