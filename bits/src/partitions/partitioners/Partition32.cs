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

        /// <summary>
        /// Partitions a 32-bit source value into 4 segments of bit width 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x8(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part32x8.Part0), Part32x8.First);
            dst[1] = project<byte>(select(src, Part32x8.Part1), Part32x8.First);
            dst[2] = project<byte>(select(src, Part32x8.Part2), Part32x8.First);
            dst[3] = project<byte>(select(src, Part32x8.Part3), Part32x8.First);
        }

        /// <summary>
        /// Partitions a 32-bit source value into 2 segments of bit width 16
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part32x16(uint src, Span<ushort> dst)
        {
            dst[0] = project<ushort>(select(src, Part32x16.Part0), Part32x16.First);
            dst[1] = project<ushort>(select(src, Part32x16.Part1), Part32x16.First);
        }

    }

}