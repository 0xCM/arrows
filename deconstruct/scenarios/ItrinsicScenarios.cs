//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;


    [DisplayName("scenarios-intrinsic")]
    class CommonIntrinsicScenarios
    {
        [MethodImpl(Inline | Optimize)]
        public static Vec128<sbyte> add1(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vec128<sbyte> add2(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);
        
        [MethodImpl(Inline | Optimize)]
        public static Vector128<sbyte> add3(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Sse2.Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vector256<sbyte> add4(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline | Optimize)]
        public static Vec256<sbyte> add5(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

    }


}