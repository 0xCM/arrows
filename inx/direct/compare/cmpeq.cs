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
        public static Vec128Cmp<sbyte> cmpeq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Vec128Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        [MethodImpl(Inline)]
        public static Vec128Cmp<byte> cmpeq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Vec128Cmp.Define<byte>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<short> cmpeq(in Vec128<short> lhs, in Vec128<short> rhs)
            => Vec128Cmp.Define<short>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<ushort> cmpeq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Vec128Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<int> cmpeq(in Vec128<int> lhs, in Vec128<int> rhs)
            => Vec128Cmp.Define<int>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<uint> cmpeq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Vec128Cmp.Define<uint>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<long> cmpeq(in Vec128<long> lhs, in Vec128<long> rhs)
            => Vec128Cmp.Define<long>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<ulong> cmpeq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Vec128Cmp.Define<ulong>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<float> cmpeq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Vec128Cmp.Define<float>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec128Cmp<double> cmpeq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Vec128Cmp.Define<double>(CompareEqual(lhs,rhs));


        [MethodImpl(Inline)]
        public static Vec256Cmp<sbyte> cmpeq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Vec256Cmp.Define<sbyte>(CompareEqual(lhs,rhs));
            
        [MethodImpl(Inline)]
        public static Vec256Cmp<byte> cmpeq(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Vec256Cmp.Define<byte>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<short> cmpeq(in Vec256<short> lhs, in Vec256<short> rhs)
            => Vec256Cmp.Define<short>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<ushort> cmpeq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Vec256Cmp.Define<ushort>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<int> cmpeq(in Vec256<int> lhs, in Vec256<int> rhs)
            => Vec256Cmp.Define<int>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<uint> cmpeq(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Vec256Cmp.Define<uint>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<long> cmpeq(in Vec256<long> lhs, in Vec256<long> rhs)
            => Vec256Cmp.Define<long>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<ulong> cmpeq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Vec256Cmp.Define<ulong>(CompareEqual(lhs,rhs));

        [MethodImpl(Inline)]
        public static Vec256Cmp<float> cmpeq(in Vec256<float> lhs, in Vec256<float> rhs)
            => Vec256Cmp.Define<float>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        [MethodImpl(Inline)]
        public static Vec256Cmp<double> cmpeq(in Vec256<double> lhs, in Vec256<double> rhs)
            => Vec256Cmp.Define<double>(Compare(lhs,rhs, FloatComparisonMode.UnorderedEqualNonSignaling));

        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => CompareScalarUnorderedEqual(lhs, rhs);

    }
}