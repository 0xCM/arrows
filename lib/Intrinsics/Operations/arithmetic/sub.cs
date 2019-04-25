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

    public partial class InX
    {
        [MethodImpl(Inline)]
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => Avx2.SubtractScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => Avx2.SubtractScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> sub(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> sub(in Vec128<short> lhs, in Vec128<short> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sub(in Vec128<int> lhs, in Vec128<int> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> sub(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> sub(in Vec128<long> lhs, in Vec128<long> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
            => sub(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
            => sub(lhs, rhs); 
    }

}