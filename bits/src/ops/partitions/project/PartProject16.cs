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
        public static ushort project(ushort src, Part1x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part2x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part3x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part4x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part4x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part5x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part6x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part6x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part6x3 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part7x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part8x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part8x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part8x4 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part9x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part9x3 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part10x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part10x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part10x5 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part11x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x3 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x4 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x6 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part13x1 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part15x3 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part15x5 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part16x2 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part16x4 part)
            => Bits.scatter(src, (ushort)part);

        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part16x8 part)
            => Bits.scatter(src, (ushort)part);
 
        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part9x1 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (ushort)part));

        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part9x3 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (ushort)part));

        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part16x2 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (ushort)part));

        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part16x4 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (ushort)part));
 
        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part16x8 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (ushort)part));

    }

}