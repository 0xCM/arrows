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
        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source value into 9 target segments each with an effective width of 1
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part9x1(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part9x1.Part0), Part9x1.First);
            dst[1] = project<byte>(select(src, Part9x1.Part1), Part9x1.First);
            dst[2] = project<byte>(select(src, Part9x1.Part2), Part9x1.First);
            dst[3] = project<byte>(select(src, Part9x1.Part3), Part9x1.First);
            dst[4] = project<byte>(select(src, Part9x1.Part4), Part9x1.First);
            dst[5] = project<byte>(select(src, Part9x1.Part5), Part9x1.First);
            dst[6] = project<byte>(select(src, Part9x1.Part6), Part9x1.First);
            dst[7] = project<byte>(select(src, Part9x1.Part7), Part9x1.First);
            dst[8] = project<byte>(select(src, Part9x1.Part8), Part9x1.First);

        }
            
        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part9x3(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part9x3.Part0), Part9x3.First);
            dst[1] = project<byte>(select(src, Part9x3.Part1), Part9x3.First);
            dst[2] = project<byte>(select(src, Part9x3.Part2), Part9x3.First);
        }
    }

}