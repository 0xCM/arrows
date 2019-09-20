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