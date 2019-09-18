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
        public static uint select(uint src, BitMask32 mask)
            => Bits.gather(src, mask);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part1x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part2x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part3x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part4x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part4x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part5x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part6x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part6x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part6x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part7x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part8x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part8x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part8x4 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part9x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part9x3 part)
            => (byte)Bits.gather(src, (uint)part);
       
        [MethodImpl(Inline)]
        public static byte select(uint src, Part10x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part10x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part10x5 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part11x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part12x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part12x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part12x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part12x4 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part12x6 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part13x1 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part15x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part15x5 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part16x2 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part16x4 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part16x8 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part21x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part24x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part27x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part30x3 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part32x4 part)
            => (byte)Bits.gather(src, (uint)part);

        [MethodImpl(Inline)]
        public static byte select(uint src, Part32x8 part)
            => (byte)Bits.gather(src, (uint)part);

    }

}