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

    public partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> min(Num128<float> lhs, Num128<float> rhs)
            => Avx2.MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> min(Num128<double> lhs, Num128<double> rhs)
            => Avx2.MinScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> min(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> min(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> min(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> min(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> min(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> min(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> min(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Min(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> min(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Min(lhs, rhs);
 
    }

}