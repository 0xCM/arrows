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

    partial class Bits
    {

        [MethodImpl(Inline)]
        public static byte select(byte src, BitMask8 mask)
            => Bits.gather(src, mask);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part1x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part2x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part3x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part4x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part4x2 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part5x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part6x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part6x2 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part6x3 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part7x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part8x1 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part8x2 part)
            => Bits.gather(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte select(byte src, Part8x4 part)
            => Bits.gather(src, (byte)part);


    }

}