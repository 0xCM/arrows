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
    using static Operative;


    public partial class InX
    {

        [MethodImpl(Inline)]
        public static Num128<float> add(Num128<float> lhs, Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(Vec128<float> lhs, Num128<float> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128<double> add(Num128<double> lhs, Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(Vec128<double> lhs, Num128<double> rhs)
            => Avx2.AddScalar(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> add(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);
    }

}