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
    using static System.Runtime.Intrinsics.X86.Sse3;
    
    using static zfunc;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<short> addh(in Vec128<short> lhs, in Vec128<short> rhs)
            => HorizontalAdd(lhs, rhs);        

        [MethodImpl(Inline)]
        public static Vec128<int> addh(in Vec128<int> lhs, in Vec128<int> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> addh(in Vec128<float> lhs, in Vec128<float> rhs)
            => HorizontalAdd(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> addh(in Vec128<double> lhs, in Vec128<double> rhs)
            => HorizontalAdd(lhs, rhs);
    }

}