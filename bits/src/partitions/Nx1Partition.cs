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
        /// Partitions the first 6 bits of a source into 6 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part6x1(byte src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part6x1.Part0), Part6x1.First);
            dst[1] = project<byte>(select(src, Part6x1.Part1), Part6x1.First);
            dst[2] = project<byte>(select(src, Part6x1.Part2), Part6x1.First);
            dst[3] = project<byte>(select(src, Part6x1.Part3), Part6x1.First);
            dst[4] = project<byte>(select(src, Part6x1.Part4), Part6x1.First);
            dst[5] = project<byte>(select(src, Part6x1.Part5), Part6x1.First);
        }

        /// <summary>
        /// Partitions the first 6 bits of a source into 6 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock6 part6x1(byte src, ref BitBlock6 dst)
        {
            dst.Bit0 = project<byte>(select(src, Part6x1.Part0), Part6x1.First);
            dst.Bit1 = project<byte>(select(src, Part6x1.Part1), Part6x1.First);
            dst.Bit2 = project<byte>(select(src, Part6x1.Part2), Part6x1.First);
            dst.Bit3 = project<byte>(select(src, Part6x1.Part3), Part6x1.First);
            dst.Bit4 = project<byte>(select(src, Part6x1.Part4), Part6x1.First);
            dst.Bit5 = project<byte>(select(src, Part6x1.Part5), Part6x1.First);
            return ref dst;
        }

        /// <summary>
        /// Partitions the first 7 bits of source into 7 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part7x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part7x1.Part0), Part7x1.First);
            dst[1] = project<byte>(select(src, Part7x1.Part1), Part7x1.First);
            dst[2] = project<byte>(select(src, Part7x1.Part2), Part7x1.First);
            dst[3] = project<byte>(select(src, Part7x1.Part3), Part7x1.First);
            dst[4] = project<byte>(select(src, Part7x1.Part4), Part7x1.First);
            dst[5] = project<byte>(select(src, Part7x1.Part5), Part7x1.First);
            dst[6] = project<byte>(select(src, Part7x1.Part6), Part7x1.First);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part8x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part8x1.Part0), Part8x1.First);
            dst[1] = project<byte>(select(src, Part8x1.Part1), Part8x1.First);
            dst[2] = project<byte>(select(src, Part8x1.Part2), Part8x1.First);
            dst[3] = project<byte>(select(src, Part8x1.Part3), Part8x1.First);
            dst[4] = project<byte>(select(src, Part8x1.Part4), Part8x1.First);
            dst[5] = project<byte>(select(src, Part8x1.Part5), Part8x1.First);
            dst[6] = project<byte>(select(src, Part8x1.Part6), Part8x1.First);
            dst[7] = project<byte>(select(src, Part8x1.Part7), Part8x1.First);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock8 part8x1(uint src, ref BitBlock8 dst)
        {
            dst.Bit1 = project<byte>(select(src, Part8x1.Part0), Part8x1.First);
            dst.Bit2 = project<byte>(select(src, Part8x1.Part1), Part8x1.First);
            dst.Bit3 = project<byte>(select(src, Part8x1.Part2), Part8x1.First);
            dst.Bit4 = project<byte>(select(src, Part8x1.Part3), Part8x1.First);
            dst.Bit5 = project<byte>(select(src, Part8x1.Part4), Part8x1.First);
            dst.Bit6 = project<byte>(select(src, Part8x1.Part5), Part8x1.First);
            dst.Bit7 = project<byte>(select(src, Part8x1.Part6), Part8x1.First);
            return ref dst;
        }

        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part9x1(uint src, Span<byte> dst)
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
        /// Partitions the first 9 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock9 part9x1(ushort src, ref BitBlock9 dst)
        {
            dst.Bit0 = project<byte>(select(src, Part9x1.Part0), Part9x1.First);
            dst.Bit1 = project<byte>(select(src, Part9x1.Part1), Part9x1.First);
            dst.Bit2 = project<byte>(select(src, Part9x1.Part2), Part9x1.First);
            dst.Bit3 = project<byte>(select(src, Part9x1.Part3), Part9x1.First);
            dst.Bit4 = project<byte>(select(src, Part9x1.Part4), Part9x1.First);
            dst.Bit5 = project<byte>(select(src, Part9x1.Part5), Part9x1.First);
            dst.Bit6 = project<byte>(select(src, Part9x1.Part6), Part9x1.First);
            dst.Bit7 = project<byte>(select(src, Part9x1.Part7), Part9x1.First);
            dst.Bit8 = project<byte>(select(src, Part9x1.Part8), Part9x1.First);
            return ref dst;
        }

        /// <summary>
        /// Partitions the first 10 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part10x1(ushort src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part10x1.Part0), Part10x1.First);
            dst[1] = project<byte>(select(src, Part10x1.Part1), Part10x1.First);
            dst[2] = project<byte>(select(src, Part10x1.Part2), Part10x1.First);
            dst[3] = project<byte>(select(src, Part10x1.Part3), Part10x1.First);
            dst[4] = project<byte>(select(src, Part10x1.Part4), Part10x1.First);
            dst[5] = project<byte>(select(src, Part10x1.Part5), Part10x1.First);
            dst[6] = project<byte>(select(src, Part10x1.Part6), Part10x1.First);
            dst[7] = project<byte>(select(src, Part10x1.Part7), Part10x1.First);
            dst[8] = project<byte>(select(src, Part10x1.Part8), Part10x1.First);
            dst[9] = project<byte>(select(src, Part10x1.Part9), Part10x1.First);

        }

        /// <summary>
        /// Partitions the first 10 bits of a 16-bit source into 9 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock10 part10x1(uint src, ref BitBlock10 dst)
        {
            dst.Bit0 = project<byte>(select(src, Part10x1.Part0), Part10x1.First);
            dst.Bit1 = project<byte>(select(src, Part10x1.Part1), Part10x1.First);
            dst.Bit2 = project<byte>(select(src, Part10x1.Part2), Part10x1.First);
            dst.Bit3 = project<byte>(select(src, Part10x1.Part3), Part10x1.First);
            dst.Bit4 = project<byte>(select(src, Part10x1.Part4), Part10x1.First);
            dst.Bit5 = project<byte>(select(src, Part10x1.Part5), Part10x1.First);
            dst.Bit6 = project<byte>(select(src, Part10x1.Part6), Part10x1.First);
            dst.Bit7 = project<byte>(select(src, Part10x1.Part7), Part10x1.First);
            dst.Bit8 = project<byte>(select(src, Part10x1.Part8), Part10x1.First);
            dst.Bit9 = project<byte>(select(src, Part10x1.Part9), Part10x1.First);
            return ref dst;
        }


        /// <summary>
        /// Partitions 32 bits from the source into 16 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock16 part16x1(ushort src, ref BitBlock16 dst)
        {
            dst.Bit0 = project<byte>(select(src, Part32x1.Part0), Part32x1.First);
            dst.Bit1 = project<byte>(select(src, Part32x1.Part1), Part32x1.First);
            dst.Bit2 = project<byte>(select(src, Part32x1.Part2), Part32x1.First);
            dst.Bit3 = project<byte>(select(src, Part32x1.Part3), Part32x1.First);
            dst.Bit4 = project<byte>(select(src, Part32x1.Part4), Part32x1.First);
            dst.Bit5 = project<byte>(select(src, Part32x1.Part5), Part32x1.First);
            dst.Bit6 = project<byte>(select(src, Part32x1.Part6), Part32x1.First);
            dst.Bit7 = project<byte>(select(src, Part32x1.Part7), Part32x1.First);
            dst.Bit8 = project<byte>(select(src, Part32x1.Part8), Part32x1.First);
            dst.Bit9 = project<byte>(select(src, Part32x1.Part9), Part32x1.First);
            dst.Bit10 = project<byte>(select(src, Part32x1.Part10), Part32x1.First);
            dst.Bit11 = project<byte>(select(src, Part32x1.Part11), Part32x1.First);
            dst.Bit12 = project<byte>(select(src, Part32x1.Part12), Part32x1.First);
            dst.Bit13 = project<byte>(select(src, Part32x1.Part13), Part32x1.First);
            dst.Bit14 = project<byte>(select(src, Part32x1.Part14), Part32x1.First);
            dst.Bit15 = project<byte>(select(src, Part32x1.Part15), Part32x1.First);
            return ref dst;

        }

        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock32 part32x1(uint src, ref BitBlock32 dst)
        {
            dst.Bit0 = project<byte>(select(src, Part32x1.Part0), Part32x1.First);
            dst.Bit1 = project<byte>(select(src, Part32x1.Part1), Part32x1.First);
            dst.Bit2 = project<byte>(select(src, Part32x1.Part2), Part32x1.First);
            dst.Bit3 = project<byte>(select(src, Part32x1.Part3), Part32x1.First);
            dst.Bit4 = project<byte>(select(src, Part32x1.Part4), Part32x1.First);
            dst.Bit5 = project<byte>(select(src, Part32x1.Part5), Part32x1.First);
            dst.Bit6 = project<byte>(select(src, Part32x1.Part6), Part32x1.First);
            dst.Bit7 = project<byte>(select(src, Part32x1.Part7), Part32x1.First);
            dst.Bit8 = project<byte>(select(src, Part32x1.Part8), Part32x1.First);
            dst.Bit9 = project<byte>(select(src, Part32x1.Part9), Part32x1.First);
            dst.Bit10 = project<byte>(select(src, Part32x1.Part10), Part32x1.First);
            dst.Bit11 = project<byte>(select(src, Part32x1.Part11), Part32x1.First);
            dst.Bit12 = project<byte>(select(src, Part32x1.Part12), Part32x1.First);
            dst.Bit13 = project<byte>(select(src, Part32x1.Part13), Part32x1.First);
            dst.Bit14 = project<byte>(select(src, Part32x1.Part14), Part32x1.First);
            dst.Bit15 = project<byte>(select(src, Part32x1.Part15), Part32x1.First);
            dst.Bit16 = project<byte>(select(src, Part32x1.Part16), Part32x1.First);
            dst.Bit17 = project<byte>(select(src, Part32x1.Part17), Part32x1.First);
            dst.Bit18 = project<byte>(select(src, Part32x1.Part18), Part32x1.First);
            dst.Bit19 = project<byte>(select(src, Part32x1.Part19), Part32x1.First);
            dst.Bit20 = project<byte>(select(src, Part32x1.Part20), Part32x1.First);
            dst.Bit21 = project<byte>(select(src, Part32x1.Part21), Part32x1.First);
            dst.Bit22 = project<byte>(select(src, Part32x1.Part22), Part32x1.First);
            dst.Bit23 = project<byte>(select(src, Part32x1.Part23), Part32x1.First);
            dst.Bit24 = project<byte>(select(src, Part32x1.Part24), Part32x1.First);
            dst.Bit25 = project<byte>(select(src, Part32x1.Part25), Part32x1.First);
            dst.Bit26 = project<byte>(select(src, Part32x1.Part26), Part32x1.First);
            dst.Bit27 = project<byte>(select(src, Part32x1.Part27), Part32x1.First);
            dst.Bit28 = project<byte>(select(src, Part32x1.Part28), Part32x1.First);
            dst.Bit29 = project<byte>(select(src, Part32x1.Part29), Part32x1.First);
            dst.Bit30 = project<byte>(select(src, Part32x1.Part30), Part32x1.First);
            dst.Bit31 = project<byte>(select(src, Part32x1.Part31), Part32x1.First);

            return ref dst;

        }

        static readonly Part32x1[] P32x1Index = new Part32x1[32]
        {
            Part32x1.Part0,  Part32x1.Part1,  Part32x1.Part2,  Part32x1.Part3,
            Part32x1.Part4,  Part32x1.Part5,  Part32x1.Part6,  Part32x1.Part7,
            Part32x1.Part8,  Part32x1.Part9,  Part32x1.Part10, Part32x1.Part11,
            Part32x1.Part12, Part32x1.Part13, Part32x1.Part14, Part32x1.Part15, 
            Part32x1.Part16, Part32x1.Part17, Part32x1.Part18, Part32x1.Part19,
            Part32x1.Part20, Part32x1.Part21, Part32x1.Part22, Part32x1.Part23,
            Part32x1.Part24, Part32x1.Part25, Part32x1.Part26, Part32x1.Part27, 
            Part32x1.Part28, Part32x1.Part29, Part32x1.Part30, Part32x1.Part31,
        };


        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static void part32x1(uint src, Span<byte> dst)
        {
            dst[0] = project<byte>(select(src, Part32x1.Part0), Part32x1.First);
            dst[1] = project<byte>(select(src, Part32x1.Part1), Part32x1.First);
            dst[2] = project<byte>(select(src, Part32x1.Part2), Part32x1.First);
            dst[3] = project<byte>(select(src, Part32x1.Part3), Part32x1.First);
            dst[4] = project<byte>(select(src, Part32x1.Part4), Part32x1.First);
            dst[5] = project<byte>(select(src, Part32x1.Part5), Part32x1.First);
            dst[6] = project<byte>(select(src, Part32x1.Part6), Part32x1.First);
            dst[7] = project<byte>(select(src, Part32x1.Part7), Part32x1.First);
            dst[8] = project<byte>(select(src, Part32x1.Part8), Part32x1.First);
            dst[9] = project<byte>(select(src, Part32x1.Part9), Part32x1.First);
            dst[10] = project<byte>(select(src, Part32x1.Part10), Part32x1.First);
            dst[11] = project<byte>(select(src, Part32x1.Part11), Part32x1.First);
            dst[12] = project<byte>(select(src, Part32x1.Part12), Part32x1.First);
            dst[13] = project<byte>(select(src, Part32x1.Part13), Part32x1.First);
            dst[14] = project<byte>(select(src, Part32x1.Part14), Part32x1.First);
            dst[15] = project<byte>(select(src, Part32x1.Part15), Part32x1.First);
            dst[16] = project<byte>(select(src, Part32x1.Part16), Part32x1.First);
            dst[17] = project<byte>(select(src, Part32x1.Part17), Part32x1.First);
            dst[18] = project<byte>(select(src, Part32x1.Part18), Part32x1.First);
            dst[19] = project<byte>(select(src, Part32x1.Part19), Part32x1.First);
            dst[20] = project<byte>(select(src, Part32x1.Part20), Part32x1.First);
            dst[21] = project<byte>(select(src, Part32x1.Part21), Part32x1.First);
            dst[22] = project<byte>(select(src, Part32x1.Part22), Part32x1.First);
            dst[23] = project<byte>(select(src, Part32x1.Part23), Part32x1.First);
            dst[24] = project<byte>(select(src, Part32x1.Part24), Part32x1.First);
            dst[25] = project<byte>(select(src, Part32x1.Part25), Part32x1.First);
            dst[26] = project<byte>(select(src, Part32x1.Part26), Part32x1.First);
            dst[27] = project<byte>(select(src, Part32x1.Part27), Part32x1.First);
            dst[28] = project<byte>(select(src, Part32x1.Part28), Part32x1.First);
            dst[29] = project<byte>(select(src, Part32x1.Part29), Part32x1.First);
            dst[30] = project<byte>(select(src, Part32x1.Part30), Part32x1.First);
            dst[31] = project<byte>(select(src, Part32x1.Part31), Part32x1.First);
        }

        /// <summary>
        /// Partitions 32 bits from the source into 32 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        [MethodImpl(Inline)]
        public static Span<byte> part32x1(uint src)
        {
            BitBlock32 block = default;
            return BitBlock.AsSpan(ref part32x1(src, ref block));
        }

    }


}