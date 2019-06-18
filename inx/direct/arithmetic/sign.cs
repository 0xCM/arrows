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
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<short> sign(in Vec128<short> lhs, in Vec128<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sign(in Vec128<int> lhs, in Vec128<int> rhs)
            => Sign(lhs, rhs);

        //Align the sign of the left integers with those on the right
        [MethodImpl(Inline)]
        public static Vec128<sbyte> sign(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> sign(in Vec256<short> lhs, in Vec256<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> sign(in Vec256<int> lhs, in Vec256<int> rhs)
            => Sign(lhs, rhs);

        //Align the sign of the left integers with those on the right
        [MethodImpl(Inline)]
        public static Vec256<sbyte> sign(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Sign(lhs, rhs);

    }
}