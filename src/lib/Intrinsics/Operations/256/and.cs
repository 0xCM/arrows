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
        public static Vec256<ushort> and(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> and(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> and(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> and(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.And(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<int> and(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> and(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> and(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> and(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]    
        public static Vec256<double> and(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.And(lhs, rhs); 
    }

}