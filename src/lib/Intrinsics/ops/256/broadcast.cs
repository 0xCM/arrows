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