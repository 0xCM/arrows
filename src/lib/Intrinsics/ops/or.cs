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
        public static Vec128<sbyte> or(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> or(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> or(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> or(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Or(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<short> or(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Or(lhs, rhs);

 
        [MethodImpl(Inline)]
        public static Vec256<short> or(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> or(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Or(lhs, rhs);

   
        [MethodImpl(Inline)]
        public static Vec256<ushort> or(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> or(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> or(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> or(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> or(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> or(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> or(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> or(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Or(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec256<float> or(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Or(lhs, rhs);

 
        [MethodImpl(Inline)]
        public static Vec128<double> or(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> or(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Or(lhs, rhs);
    }
}