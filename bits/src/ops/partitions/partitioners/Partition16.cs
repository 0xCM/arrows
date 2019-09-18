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
        /// Partitions a 16-bit source value into 8 target segments each with an effective width of 2
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x2(ushort src, Span<byte> dst)
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
        /// Partitions a 16-bit source value into 2 target segments each with a width of 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x8(byte src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part16x8.Part0), Part16x8.First);            
            dst[1] = project<byte>(select(src, Part16x8.Part1), Part16x8.First);
        }

    }

}