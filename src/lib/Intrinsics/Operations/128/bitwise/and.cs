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
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.And(lhs, rhs);   
    }
}