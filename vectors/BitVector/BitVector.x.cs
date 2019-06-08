//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitVectorX
    {
        [MethodImpl(Inline)]
        public static BitVectorU8 ToBits(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI8 ToBits(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU16 ToBits(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI32 ToBits(this int src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU32 ToBits(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU64 ToBits(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI64 ToBits(this long src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<sbyte> ToGeneric(this BitVectorI8 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<short> ToGeneric(this BitVectorI16 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<int> ToGeneric(this BitVectorI32 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<long> ToGeneric(this BitVectorI64 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<byte> ToGeneric(this BitVectorU8 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGeneric(this BitVectorU16 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<uint> ToGeneric(this BitVectorU32 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGeneric(this BitVectorU64 src)
            => src;


    }
}
