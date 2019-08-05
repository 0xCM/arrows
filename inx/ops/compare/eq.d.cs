//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {   
        [MethodImpl(Inline)]
        public static Vec128Cmp<sbyte> eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Vec128Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        [MethodImpl(Inline)]
        public static Vec128Cmp<byte> eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Vec128Cmp.Define<byte>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<short> eq(in Vec128<short> lhs, in Vec128<short> rhs)
            => Vec128Cmp.Define<short>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<ushort> eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Vec128Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<int> eq(in Vec128<int> lhs, in Vec128<int> rhs)
            => Vec128Cmp.Define<int>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<uint> eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Vec128Cmp.Define<uint>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<long> eq(in Vec128<long> lhs, in Vec128<long> rhs)
            => Vec128Cmp.Define<long>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<ulong> eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Vec128Cmp.Define<ulong>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<double> eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Vec256Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        [MethodImpl(Inline)]
        public static Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Vec256Cmp.Define<byte>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
            => Vec256Cmp.Define<short>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Vec256Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
            => Vec256Cmp.Define<int>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Vec256Cmp.Define<uint>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
            => Vec256Cmp.Define<long>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Vec256Cmp.Define<ulong>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<float> eq(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> eq(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));


    }
}