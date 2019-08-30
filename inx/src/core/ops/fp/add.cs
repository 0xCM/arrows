//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;    

    partial class dfp
    {

        [MethodImpl(Inline)]
        public static Num128<float> add(in Num128<float> lhs, in Num128<float> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(in Num128<double> lhs, in Num128<double> rhs)
            => AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
            => Add(lhs, rhs); 

    }

}