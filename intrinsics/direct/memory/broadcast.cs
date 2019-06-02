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

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(ref byte src, out Vec256<byte> dst)
            => dst = BroadcastScalarToVector256(puint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(ref sbyte src, out Vec256<sbyte> dst)
            => dst = BroadcastScalarToVector256(pint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(ref short src, out Vec256<short> dst)
            => dst = BroadcastScalarToVector256(pint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(ref ushort src, out Vec256<ushort> dst)
            => dst = BroadcastScalarToVector256(puint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(ref int src, out Vec256<int> dst)
            => dst =  BroadcastScalarToVector256(pint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(ref uint src, out Vec256<uint> dst)
            =>  dst = BroadcastScalarToVector256(puint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(ref long src, out Vec256<long> dst)
            =>  dst = BroadcastScalarToVector256(pint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(ref ulong src, out Vec256<ulong> dst)
            =>  dst = BroadcastScalarToVector256(puint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(ref float src, out Vec256<float> dst)
            =>  dst = BroadcastScalarToVector256(pfloat32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(ref double src, out Vec256<double> dst)
            => dst = BroadcastScalarToVector256(pfloat64(ref src)); 
    }
}