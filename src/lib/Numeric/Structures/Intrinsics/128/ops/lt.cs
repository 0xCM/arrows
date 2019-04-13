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
        public static Vec128<sbyte> lt(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse42.CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> lt(Vec128<short> lhs, Vec128<short> rhs)
            => Sse42.CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> lt(Vec128<int> lhs, Vec128<int> rhs)
            => Sse42.CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> lt(Vec128<float> lhs, Vec128<float> rhs)
            => Sse.CompareLessThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lt(Vec128<double> lhs, Vec128<double> rhs)
            => Sse42.CompareLessThan(lhs, rhs);


    }


}