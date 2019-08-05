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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
        
    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static void div(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void div(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static Vec256<float> div(in Vec256<float> lhs, in Vec256<float> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> div(in Vec256<double> lhs, in Vec256<double> rhs)
            => Divide(lhs, rhs);

        [MethodImpl(Inline)]
        public static void div(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Divide(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void div(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Divide(lhs, rhs), ref dst);


    }
}