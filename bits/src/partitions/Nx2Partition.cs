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
    using static Bits;

    partial class BitParts
    {        

        /// <summary>
        /// Partitions an 8-bit source into 4 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part8x2(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part8x2.Part0), Part8x2.First);
            dst[1] = project<byte>(select(src, Part8x2.Part1), Part8x2.First);
            dst[2] = project<byte>(select(src, Part8x2.Part2), Part8x2.First);
            dst[3] = project<byte>(select(src, Part8x2.Part3), Part8x2.First);
        }

        /// <summary>
        /// Partitions a 16-bit source into 8 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x2(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part16x2.Part0), Part16x2.First);
            dst[1] = project<byte>(select(src, Part16x2.Part1), Part16x2.First);
            dst[2] = project<byte>(select(src, Part16x2.Part2), Part16x2.First);
            dst[3] = project<byte>(select(src, Part16x2.Part3), Part16x2.First);
            dst[4] = project<byte>(select(src, Part16x2.Part4), Part16x2.First);
            dst[5] = project<byte>(select(src, Part16x2.Part5), Part16x2.First);
            dst[6] = project<byte>(select(src, Part16x2.Part6), Part16x2.First);
            dst[7] = project<byte>(select(src, Part16x2.Part7), Part16x2.First);
        }

        /// <summary>
        /// Partitions a 32-bit source into 16 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x2(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part32x2.Part0), Part32x2.First);
            dst[1] = project<byte>(select(src, Part32x2.Part1), Part32x2.First);
            dst[2] = project<byte>(select(src, Part32x2.Part2), Part32x2.First);
            dst[3] = project<byte>(select(src, Part32x2.Part3), Part32x2.First);
            dst[4] = project<byte>(select(src, Part32x2.Part4), Part32x2.First);
            dst[5] = project<byte>(select(src, Part32x2.Part5), Part32x2.First);
            dst[6] = project<byte>(select(src, Part32x2.Part6), Part32x2.First);
            dst[7] = project<byte>(select(src, Part32x2.Part7), Part32x2.First);
            dst[8] = project<byte>(select(src, Part32x2.Part8), Part32x2.First);
            dst[9] = project<byte>(select(src, Part32x2.Part9), Part32x2.First);
            dst[10] = project<byte>(select(src, Part32x2.Part10), Part32x2.First);
            dst[11] = project<byte>(select(src, Part32x2.Part11), Part32x2.First);
            dst[12] = project<byte>(select(src, Part32x2.Part12), Part32x2.First);
            dst[13] = project<byte>(select(src, Part32x2.Part13), Part32x2.First);
            dst[14] = project<byte>(select(src, Part32x2.Part14), Part32x2.First);
            dst[15] = project<byte>(select(src, Part32x2.Part15), Part32x2.First);
        }

    }
}