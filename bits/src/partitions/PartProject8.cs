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
        public static byte project(byte src, Part1x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part2x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part3x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part4x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part4x2 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part5x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part6x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part6x2 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part6x3 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part7x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part8x1 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part8x2 part)
            => Bits.scatter(src, (byte)part);

        [MethodImpl(Inline)]
        public static byte project(byte src, Part8x4 part)
            => Bits.scatter(src, (byte)part);



    }

}