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
        /// Partitions the first 21 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part21x3(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part21x3.Part0), Part21x3.First);
            dst[1] = project<byte>(select(src, Part21x3.Part1), Part21x3.First);
            dst[2] = project<byte>(select(src, Part21x3.Part2), Part21x3.First);
            dst[3] = project<byte>(select(src, Part21x3.Part3), Part21x3.First);
            dst[4] = project<byte>(select(src, Part21x3.Part4), Part21x3.First);
            dst[5] = project<byte>(select(src, Part21x3.Part5), Part21x3.First);
            dst[6] = project<byte>(select(src, Part21x3.Part6), Part21x3.First);

        }


    }

}