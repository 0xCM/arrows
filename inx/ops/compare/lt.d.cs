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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128Cmp<sbyte> lt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Vec128Cmp.Define<sbyte>(CompareLessThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<short> lt(in Vec128<short> lhs, in Vec128<short> rhs)
            => Vec128Cmp.Define<short>(CompareLessThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<int> lt(in Vec128<int> lhs, in Vec128<int> rhs)
            => Vec128Cmp.Define<int>(CompareLessThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> lt(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareLessThan(lhs,rhs));
        
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> lt(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareLessThan(lhs,rhs));
    
        [MethodImpl(Inline)]
        public static Vec256Cmp<float> lt(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> lt(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs,FloatComparisonMode.OrderedLessThanNonSignaling));

    
    }

}