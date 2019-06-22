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
        
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> lo(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> lo(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> lo(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> lo(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> lo(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> lo(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> lo(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lo(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackLow(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<byte> lo(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> lo(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> lo(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> lo(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> lo(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> lo(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> lo(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackLow(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lo(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackLow(lhs, rhs);


    }

}