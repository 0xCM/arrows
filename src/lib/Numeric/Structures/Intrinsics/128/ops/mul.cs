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


    public partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<long> mul(Vec128<int> lhs, Vec128<int> rhs)
            => Sse42.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse42.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> mul(Vec128<float> lhs, Vec128<float> rhs)
            => Sse42.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> mul(Vec128<double> lhs, Vec128<double> rhs)
            => Sse42.Multiply(lhs, rhs);

    }

}