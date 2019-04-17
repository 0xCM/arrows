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

    partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec256<sbyte> gt(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> gt(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> gt(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

    }
}