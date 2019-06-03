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
    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(in byte src, out Vec256<byte> dst)
            => dst = BroadcastScalarToVector256(puint8(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(in sbyte src, out Vec256<sbyte> dst)
            => dst = BroadcastScalarToVector256(pint8(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(in short src, out Vec256<short> dst)
            => dst = BroadcastScalarToVector256(pint16(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(in ushort src, out Vec256<ushort> dst)
            => dst = BroadcastScalarToVector256(puint16(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(in int src, out Vec256<int> dst)
            => dst =  BroadcastScalarToVector256(pint32(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(in uint src, out Vec256<uint> dst)
            =>  dst = BroadcastScalarToVector256(puint32(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(in long src, out Vec256<long> dst)
            =>  dst = BroadcastScalarToVector256(pint64(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(in ulong src, out Vec256<ulong> dst)
            =>  dst = BroadcastScalarToVector256(puint64(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(in float src, out Vec256<float> dst)
            =>  dst = BroadcastScalarToVector256(pfloat32(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(in double src, out Vec256<double> dst)
            => dst = BroadcastScalarToVector256(pfloat64(ref asRef(in src))); 
 
        [MethodImpl(Inline)]
        public static Vec128<sbyte> broadcast(in Num128<sbyte> src, out Vec128<sbyte> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<byte> broadcast(in Num128<byte> src, out Vec128<byte> dst)
            => dst = Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<short> broadcast(in Num128<short> src, out Vec128<short> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> broadcast(in Num128<ushort> src, out Vec128<ushort> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<int> broadcast(in Num128<int> src, out Vec128<int> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> broadcast(in Num128<uint> src, out Vec128<uint> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<long> broadcast(in Num128<long> src, out Vec128<long> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> broadcast(in Num128<ulong> src, out Vec128<ulong> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<float> broadcast(in Num128<float> src, out Vec128<float> dst)
            => dst = BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<double> broadcast(in Num128<double> src, out Vec128<double> dst)
            => dst = BroadcastScalarToVector128(src);
 
 
    }
}