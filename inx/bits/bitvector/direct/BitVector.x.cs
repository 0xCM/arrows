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
        public static BitVector8 ToBitVector(this byte src)
            => src;


        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector(this ushort src)
            => src;


        [MethodImpl(Inline)]
        public static BitVector32 ToBitVector(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector64 ToBitVector(this ulong src)
            => src;


        [MethodImpl(Inline)]
        public static BitVector<byte> ToGeneric(this BitVector8 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<ushort> ToGeneric(this BitVector16 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<uint> ToGeneric(this BitVector32 src)
            => src;

        [MethodImpl(Inline)]
        public static BitVector<ulong> ToGeneric(this BitVector64 src)
            => src;

    }
}
