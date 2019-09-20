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
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part8x4(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part8x4.Part0), Part8x4.First);
            dst[1] = project(select(src, Part8x4.Part1), Part8x4.First);
        }

        /// <summary>
        /// Partitions an 8-bit source value into 2 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part12x4(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part12x4.Part0), Part12x4.First);
            dst[1] = project<byte>(select(src, Part12x4.Part1), Part12x4.First);
            dst[2] = project<byte>(select(src, Part12x4.Part2), Part12x4.First);
        }

        /// <summary>
        /// Partitions a 16-bit source value into 4 target segments each with an effective width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x4(byte src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part16x4.Part0), Part16x4.First);
            dst[1] = project<byte>(select(src, Part16x4.Part1), Part16x4.First);
            dst[2] = project<byte>(select(src, Part16x4.Part2), Part16x4.First);
            dst[3] = project<byte>(select(src, Part16x4.Part3), Part16x4.First);
        }

        /// <summary>
        /// Partitions a 32-bit source value into 8 segments with an effective bit width of 4
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x4(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part32x4.Part0), Part32x4.First);
            dst[1] = project<byte>(select(src, Part32x4.Part1), Part32x4.First);
            dst[2] = project<byte>(select(src, Part32x4.Part2), Part32x4.First);
            dst[3] = project<byte>(select(src, Part32x4.Part3), Part32x4.First);
            dst[4] = project<byte>(select(src, Part32x4.Part4), Part32x4.First);
            dst[5] = project<byte>(select(src, Part32x4.Part5), Part32x4.First);
            dst[6] = project<byte>(select(src, Part32x4.Part6), Part32x4.First);
            dst[7] = project<byte>(select(src, Part32x4.Part7), Part32x4.First);
        }

    }
}