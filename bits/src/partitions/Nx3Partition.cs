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
        /// Partitions the first 9 bits of a 16-bit source value into 3 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part6x3(byte src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part6x3.Part0), Part6x3.First);
            dst[1] = project<byte>(select(src, Part6x3.Part1), Part6x3.First);
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

        /// <summary>
        /// Partitions the first 12 bits of a 16-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part12x3(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part12x3.Part0), Part12x3.First);
            dst[1] = project<byte>(select(src, Part12x3.Part1), Part12x3.First);
            dst[2] = project<byte>(select(src, Part12x3.Part2), Part12x3.First);
            dst[3] = project<byte>(select(src, Part12x3.Part3), Part12x3.First);

        }

        /// <summary>
        /// Partitions the first 15 bits of a 16-bit source into 6 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part15x3(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part15x3.Part0), Part15x3.First);
            dst[1] = project<byte>(select(src, Part15x3.Part1), Part15x3.First);
            dst[2] = project<byte>(select(src, Part15x3.Part2), Part15x3.First);
            dst[3] = project<byte>(select(src, Part15x3.Part3), Part15x3.First);
            dst[4] = project<byte>(select(src, Part15x3.Part4), Part15x3.First);
        }

        /// <summary>
        /// Partitions the first 18 bits of a 32-bit source into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part18x3(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part18x3.Part0), Part18x3.First);
            dst[1] = project<byte>(select(src, Part18x3.Part1), Part18x3.First);
            dst[2] = project<byte>(select(src, Part18x3.Part2), Part18x3.First);
            dst[3] = project<byte>(select(src, Part18x3.Part3), Part18x3.First);
            dst[4] = project<byte>(select(src, Part18x3.Part4), Part18x3.First);
            dst[5] = project<byte>(select(src, Part18x3.Part5), Part18x3.First);
        }

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

        /// <summary>
        /// Partitions the first 24 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part24x3(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part24x3.Part0), Part24x3.First);
            dst[1] = project<byte>(select(src, Part24x3.Part1), Part24x3.First);
            dst[2] = project<byte>(select(src, Part24x3.Part2), Part24x3.First);
            dst[3] = project<byte>(select(src, Part24x3.Part3), Part24x3.First);
            dst[4] = project<byte>(select(src, Part24x3.Part4), Part24x3.First);
            dst[5] = project<byte>(select(src, Part24x3.Part5), Part24x3.First);
            dst[6] = project<byte>(select(src, Part24x3.Part6), Part24x3.First);
            dst[7] = project<byte>(select(src, Part24x3.Part7), Part24x3.First);

        }

        /// <summary>
        /// Partitions the first 27 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part27x3(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part27x3.Part0), Part27x3.First);
            dst[1] = project<byte>(select(src, Part27x3.Part1), Part27x3.First);
            dst[2] = project<byte>(select(src, Part27x3.Part2), Part27x3.First);
            dst[3] = project<byte>(select(src, Part27x3.Part3), Part27x3.First);
            dst[4] = project<byte>(select(src, Part27x3.Part4), Part27x3.First);
            dst[5] = project<byte>(select(src, Part27x3.Part5), Part27x3.First);
            dst[6] = project<byte>(select(src, Part27x3.Part6), Part27x3.First);
            dst[7] = project<byte>(select(src, Part27x3.Part7), Part27x3.First);
            dst[8] = project<byte>(select(src, Part27x3.Part8), Part27x3.First);

        }

        /// <summary>
        /// Partitions the first 30 bits of a 32-bit source value into 7 target segments each with an effective width of 3
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part30x3(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part30x3.Part0), Part30x3.First);
            dst[1] = project<byte>(select(src, Part30x3.Part1), Part30x3.First);
            dst[2] = project<byte>(select(src, Part30x3.Part2), Part30x3.First);
            dst[3] = project<byte>(select(src, Part30x3.Part3), Part30x3.First);
            dst[4] = project<byte>(select(src, Part30x3.Part4), Part30x3.First);
            dst[5] = project<byte>(select(src, Part30x3.Part5), Part30x3.First);
            dst[6] = project<byte>(select(src, Part30x3.Part6), Part30x3.First);
            dst[7] = project<byte>(select(src, Part30x3.Part7), Part30x3.First);
            dst[8] = project<byte>(select(src, Part30x3.Part8), Part30x3.First);
            dst[9] = project<byte>(select(src, Part30x3.Part9), Part30x3.First);

        }

    }
}