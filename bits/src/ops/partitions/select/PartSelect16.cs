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
        public static ushort select(ushort src, BitMask16 mask)
            => Bits.gather(src, mask);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part1x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part2x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part3x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part4x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part4x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part5x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part6x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part6x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part6x3 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part7x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part8x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part8x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part8x4 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part9x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part9x3 part)
            => (byte)Bits.gather(src, (ushort)part);
       
        [MethodImpl(Inline)]
        public static byte select(ushort src, Part10x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part10x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part10x5 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part11x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x3 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x4 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x6 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part13x1 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part15x3 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part15x5 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part16x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part16x4 part)
            => (byte)Bits.gather(src, (ushort)part);

        [MethodImpl(Inline)]
        public static byte select(ushort src, Part16x8 part)
            => (byte)Bits.gather(src, (ushort)part);

    }
}