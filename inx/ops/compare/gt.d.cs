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
        public static Vec128Cmp<sbyte> gt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Vec128Cmp.Define<sbyte>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<short> gt(in Vec128<short> lhs, in Vec128<short> rhs)
            => Vec128Cmp.Define<short>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<int> gt(in Vec128<int> lhs, in Vec128<int> rhs)
            => Vec128Cmp.Define<int>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<sbyte> gt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Vec256Cmp.Define<sbyte>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<short> gt(in Vec256<short> lhs, in Vec256<short> rhs)
            => Vec256Cmp.Define<short>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<int> gt(in Vec256<int> lhs, in Vec256<int> rhs)
            => Vec256Cmp.Define<int>(CompareGreaterThan(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<long> gt(in Vec256<long> lhs, in Vec256<long> rhs)
            => Vec256Cmp.Define<long>(CompareGreaterThan(lhs,rhs));


    }
}