//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class bitvector
    {

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
        {
            var bs = dst.AsBytes();
            BitParts.part32x8(src,bs);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
        {
            var bs = dst.AsUInt16();
            BitParts.part32x16(src,bs);
            return dst;
        }


    }
}