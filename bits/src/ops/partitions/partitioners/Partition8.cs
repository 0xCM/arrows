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
        public static void part8x1(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part8x1.Part0), Part8x1.First);
            dst[1] = project(select(src, Part8x1.Part1), Part8x1.First);
            dst[2] = project(select(src, Part8x1.Part2), Part8x1.First);
            dst[3] = project(select(src, Part8x1.Part3), Part8x1.First);
            dst[4] = project(select(src, Part8x1.Part4), Part8x1.First);
            dst[5] = project(select(src, Part8x1.Part5), Part8x1.First);
            dst[6] = project(select(src, Part8x1.Part6), Part8x1.First);
            dst[7] = project(select(src, Part8x1.Part7), Part8x1.First);
        }

        public static void part8x2(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part8x2.Part0), Part8x2.First);
            dst[1] = project(select(src, Part8x2.Part1), Part8x2.First);
            dst[2] = project(select(src, Part8x2.Part2), Part8x2.First);
            dst[3] = project(select(src, Part8x2.Part3), Part8x2.First);
        }

        public static void part8x4(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part8x4.Part0), Part8x4.First);
            dst[1] = project(select(src, Part8x4.Part1), Part8x4.First);
        }

    }

}