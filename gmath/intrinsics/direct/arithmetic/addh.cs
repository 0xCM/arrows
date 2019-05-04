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
        public static Vec128<short> addh(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.HorizontalAdd(lhs, rhs);        

        [MethodImpl(Inline)]
        public static Vec128<int> addh(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> addh(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> addh(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.HorizontalAdd(lhs, rhs);
    }

}