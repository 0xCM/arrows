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
        public static Vec128<byte> hi(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> hi(in Vec128<short> lhs, in Vec128<short> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> hi(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> hi(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> hi(in Vec128<int> lhs, in Vec128<int> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> hi(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> hi(in Vec128<long> lhs, in Vec128<long> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> hi(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> hi(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> hi(in Vec256<short> lhs, in Vec256<short> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> hi(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> hi(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> hi(in Vec256<int> lhs, in Vec256<int> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> hi(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> hi(in Vec256<long> lhs, in Vec256<long> rhs)
            => UnpackHigh(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> hi(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => UnpackHigh(lhs, rhs);
    }
}