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

    public partial class Vec128
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> sub(Vec128<byte> lhs, Vec128<byte> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> sub(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> sub(Vec128<short> lhs, Vec128<short> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> sub(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sub(Vec128<int> lhs, Vec128<int> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> sub(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> sub(Vec128<long> lhs, Vec128<long> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> sub(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> sub(Vec128<float> lhs, Vec128<float> rhs)
            => Sse2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> sub(Vec128<double> lhs, Vec128<double> rhs)
            => Sse2.Subtract(lhs, rhs);
    }

}