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

    partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec128<short> sign(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sign(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Sign(lhs, rhs);


        //Align the sign of the left integers with those on the right
        [MethodImpl(Inline)]
        public static Vec128<sbyte> sign(Vec128<sbyte> lhs,  Vec128<sbyte> rhs)
            => Avx2.Sign(lhs, rhs);

    }

}