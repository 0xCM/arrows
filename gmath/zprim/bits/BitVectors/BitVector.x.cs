//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static Bits;

    public static partial class BitVectorX
    {        

        [MethodImpl(Inline)]
        public static BitVectorU8 ToBitVector(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI8 ToBitVector(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU16 ToBitVector(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI32 ToBitVector(this int src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU32 ToBitVector(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU64 ToBitVector(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI64 ToBitVector(this long src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU128 ToBitVector(this u128 src)
            => src;
    }

}
