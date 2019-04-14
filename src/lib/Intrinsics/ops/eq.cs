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
        public static Num128<float> eq(Num128<float> lhs, Num128<float> rhs)
            => Avx2.CompareEqualScalar(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Num128<double> eq(Num128<double> lhs, Num128<double> rhs)
            => Avx2.CompareEqualScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> eq(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> eq(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> eq(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> eq(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> eq(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> eq(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> eq(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> eq(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> eq(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> eq(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> eq(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> eq(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> eq(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.CompareEqual(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> eq(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.CompareEqual(lhs, rhs);


 

    }
}