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

    partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> gt(Num128<float> lhs, Num128<float> rhs)
            => Sse.CompareGreaterThanScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> gt(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareGreaterThanScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> gt(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> gt(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> gt(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> gt(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> gt(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> gt(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> gt(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gt(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

    }
}