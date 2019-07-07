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



    }
}
