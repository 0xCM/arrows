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
    using static inX;


    partial class InX
    {


        [MethodImpl(Inline)]
        public static Vec256<long> mul(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> mul(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> mul(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Multiply(lhs, rhs);


    }

}