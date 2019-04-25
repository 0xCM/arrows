//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
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
        public static Vec128<sbyte> xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> xor(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> xor(in Vec128<short> lhs, in Vec128<short> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> xor(in Vec128<int> lhs, in Vec128<int> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> xor(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> xor(in Vec128<long> lhs, in Vec128<long> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> lhs, in Vec128<float> rhs)
            => Sse2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> xor(in Vec128<double> lhs, in Vec128<double> rhs)
            => Sse2.Xor(lhs, rhs); 
 
       [MethodImpl(Inline)]
        public static Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Or(lhs, rhs);
    }    
}