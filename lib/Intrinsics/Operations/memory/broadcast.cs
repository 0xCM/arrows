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
        public static Vec128<byte> broadcast(Num128<byte> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> broadcast(Num128<sbyte> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<short> broadcast(Num128<short> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> broadcast(Num128<ushort> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<int> broadcast(Num128<int> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> broadcast(Num128<uint> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<long> broadcast(Num128<long> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> broadcast(Num128<ulong> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<float> broadcast(Num128<float> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<double> broadcast(Num128<double> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(byte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(sbyte* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(short* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(ushort* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(int* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(uint* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(long* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(ulong* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(float* src)
            => Avx2.BroadcastScalarToVector256(src);

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(double* src)
            => Avx2.BroadcastScalarToVector256(src);

    }

}