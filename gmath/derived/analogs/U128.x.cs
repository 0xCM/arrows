//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static mfunc;

    public static class U128X
    {
        const int BitSize = 128;
        
        const int ByteSize = 16;
        
        [MethodImpl(Inline)]
        public static ref U128 SetBit(this ref U128 src, int pos)
            => ref Bits.enable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref U128 UnsetBit(this ref U128 src, int pos)
            => ref Bits.disable(ref src, pos);
             
        [MethodImpl(Inline)]
        public static bool TestBit(this in U128 src, int pos)
            => Bits.test(in src,pos);

        [MethodImpl(Inline)]
        public static string ToBitString(this in U128 src)
            => Bits.bitstring(in src);

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this in U128 src)
            => Bits.bytes(src);
        
        public static Span<Bit> ToBits(this in U128 src)
            => Bits.bits(src);

        public static int PopCount(this in U128 src)
            => Bits.pop(src);
    }
}