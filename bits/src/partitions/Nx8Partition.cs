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
        /// Partitions a 16-bit source value into 2 target segments each with a width of 8
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part16x8(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part16x8.Part0), Part16x8.First);            
            dst[1] = project<byte>(select(src, Part16x8.Part1), Part16x8.First);
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


    }
}