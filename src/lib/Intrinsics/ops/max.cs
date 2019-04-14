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

    public partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> max(Num128<float> lhs, Num128<float> rhs)
            => Avx2.MaxScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> max(Num128<double> lhs, Num128<double> rhs)
            => Avx2.MaxScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> max(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> max(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> max(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> max(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> max(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> max(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> max(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> max(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> max(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> max(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> max(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> max(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> max(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Max(lhs, rhs);

       [MethodImpl(Inline)]
        public static Vec256<float> max(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> max(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> max(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Max(lhs, rhs);
    }
}