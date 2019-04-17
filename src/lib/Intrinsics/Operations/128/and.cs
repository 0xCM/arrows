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
    using static inX;

    partial class InX
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> and(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.And(lhs, rhs);   
    }
}