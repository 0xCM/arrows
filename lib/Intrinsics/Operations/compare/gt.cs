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
        public static Num128<float> gt(in Num128<float> lhs, in Num128<float> rhs)
            => Sse.CompareGreaterThanScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> gt(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.CompareGreaterThanScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> gt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> gt(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> gt(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> gt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> gt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.CompareGreaterThan(lhs, rhs);
 
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