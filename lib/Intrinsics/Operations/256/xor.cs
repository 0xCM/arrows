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
        public static Vec256<sbyte> xor(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> xor(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> xor(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> xor(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> xor(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> xor(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> xor(Vec256<ulong> lhs, Vec256<ulong> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> xor(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> xor(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Or(lhs, rhs);
    }
}
