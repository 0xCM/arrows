//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static mfunc;
    using static As;

    public static partial class Vec256
    {


        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> broadcast(ref byte src)
            => Avx2.BroadcastScalarToVector256(puint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> broadcast(ref sbyte src)
            => Avx2.BroadcastScalarToVector256(pint8(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> broadcast(ref short src)
            => BroadcastScalarToVector256(pint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> broadcast(ref ushort src)
            => BroadcastScalarToVector256(puint16(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> broadcast(ref int src)
            => BroadcastScalarToVector256(pint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> broadcast(ref uint src)
            => BroadcastScalarToVector256(puint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> broadcast(ref long src)
            => BroadcastScalarToVector256(pint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> broadcast(ref ulong src)
            => BroadcastScalarToVector256(puint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<float> broadcast(ref float src)
            => BroadcastScalarToVector256(pfloat32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<double> broadcast(ref double src)
            => BroadcastScalarToVector256(pfloat64(ref src)); 
    } 
}