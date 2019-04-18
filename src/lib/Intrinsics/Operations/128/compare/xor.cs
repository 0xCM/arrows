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
        public static Vec128<sbyte> xor(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> xor(Vec128<byte> lhs, Vec128<byte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> xor(Vec128<short> lhs, Vec128<short> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> xor(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> xor(Vec128<int> lhs, Vec128<int> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> xor(Vec128<uint> lhs, Vec128<uint> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> xor(Vec128<long> lhs, Vec128<long> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> xor(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(Vec128<float> lhs, Vec128<float> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> xor(Vec128<double> lhs, Vec128<double> rhs)
            => Sse2.Xor(lhs, rhs); 
 

    }

}