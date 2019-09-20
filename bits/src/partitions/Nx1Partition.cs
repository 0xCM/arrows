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
            dst[0] = project(select(src, Part6x1.Part0), Part6x1.First);
            dst[1] = project(select(src, Part6x1.Part1), Part6x1.First);
            dst[2] = project(select(src, Part6x1.Part2), Part6x1.First);
            dst[3] = project(select(src, Part6x1.Part3), Part6x1.First);
            dst[4] = project(select(src, Part6x1.Part4), Part6x1.First);
            dst[5] = project(select(src, Part6x1.Part5), Part6x1.First);
        }

        /// <summary>
        /// Partitions the first 6 bits of a source into 6 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock6 part6x1(byte src, ref BitBlock6 dst)
        {
            dst.Bit0 = project(select(src, Part6x1.Part0), Part6x1.First);
            dst.Bit1 = project(select(src, Part6x1.Part1), Part6x1.First);
            dst.Bit2 = project(select(src, Part6x1.Part2), Part6x1.First);
            dst.Bit3 = project(select(src, Part6x1.Part3), Part6x1.First);
            dst.Bit4 = project(select(src, Part6x1.Part4), Part6x1.First);
            dst.Bit5 = project(select(src, Part6x1.Part5), Part6x1.First);
            return ref dst;
        }

        /// <summary>
        /// Partitions the first 7 bits of source into 7 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part7x1(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part7x1.Part0), Part7x1.First);
            dst[1] = project(select(src, Part7x1.Part1), Part7x1.First);
            dst[2] = project(select(src, Part7x1.Part2), Part7x1.First);
            dst[3] = project(select(src, Part7x1.Part3), Part7x1.First);
            dst[4] = project(select(src, Part7x1.Part4), Part7x1.First);
            dst[5] = project(select(src, Part7x1.Part5), Part7x1.First);
            dst[6] = project(select(src, Part7x1.Part6), Part7x1.First);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static void part8x1(byte src, Span<byte> dst)
        {
            dst[0] = project(select(src, Part8x1.Part0), Part8x1.First);
            dst[1] = project(select(src, Part8x1.Part1), Part8x1.First);
            dst[2] = project(select(src, Part8x1.Part2), Part8x1.First);
            dst[3] = project(select(src, Part8x1.Part3), Part8x1.First);
            dst[4] = project(select(src, Part8x1.Part4), Part8x1.First);
            dst[5] = project(select(src, Part8x1.Part5), Part8x1.First);
            dst[6] = project(select(src, Part8x1.Part6), Part8x1.First);
            dst[7] = project(select(src, Part8x1.Part7), Part8x1.First);
        }

        /// <summary>
        /// Partitions 8 bits of a source into 8 target segments of effective width 1 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">A target span of sufficient length</param>
        public static ref BitBlock8 part8x1(byte src, ref BitBlock8 dst)
        {
            dst.Bit1 = project(select(src, Part8x1.Part0), Part8x1.First);
            dst.Bit2 = project(select(src, Part8x1.Part1), Part8x1.First);
            dst.Bit3= project(select(src, Part8x1.Part2), Part8x1.First);
            dst.Bit4 = project(select(src, Part8x1.Part3), Part8x1.First);
            dst.Bit5 = project(select(src, Part8x1.Part4), Part8x1.First);
            dst.Bit6 = project(select(src, Part8x1.Part5), Part8x1.First);
            dst.Bit7 = project(select(src, Part8x1.Part6), Part8x1.First);
            return ref dst;
        }

        /// <summary>
        /// Partitions the first 9 bits of a 16-bit source into 9 target segments of effective width 1 
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
        public static ref BitBlock10 part10x1(ushort src, ref BitBlock10 dst)
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


        public static void part32x1_test(uint src, Span<byte> dst)
        {
            dst[0] = ((src & (1u << 0)) != 0u).ToByte();
            dst[1] = ((src & (1u << 1)) != 0u).ToByte();
            dst[2] = ((src & (1u << 2)) != 0u).ToByte();
            dst[3] = ((src & (1u << 3)) != 0u).ToByte();
            dst[4] = ((src & (1u << 4)) != 0u).ToByte();
            dst[5] = ((src & (1u << 5)) != 0u).ToByte();
            dst[6] = ((src & (1u << 6)) != 0u).ToByte();
            dst[7] = ((src & (1u << 7)) != 0u).ToByte();
            dst[8] = ((src & (1u << 8)) != 0u).ToByte();
            dst[9] = ((src & (1u << 9)) != 0u).ToByte();
            dst[10] = ((src & (1u << 10)) != 0u).ToByte();
            dst[11] = ((src & (1u << 11)) != 0u).ToByte();
            dst[12] = ((src & (1u << 12)) != 0u).ToByte();
            dst[13] = ((src & (1u << 13)) != 0u).ToByte();
            dst[14] = ((src & (1u << 14)) != 0u).ToByte();
            dst[15] = ((src & (1u << 15)) != 0u).ToByte();
            dst[16] = ((src & (1u << 16)) != 0u).ToByte();
            dst[17] = ((src & (1u << 17)) != 0u).ToByte();
            dst[18] = ((src & (1u << 18)) != 0u).ToByte();
            dst[19] = ((src & (1u << 19)) != 0u).ToByte();
            dst[20] = ((src & (1u << 20)) != 0u).ToByte();
            dst[21] = ((src & (1u << 21)) != 0u).ToByte();
            dst[22] = ((src & (1u << 22)) != 0u).ToByte();
            dst[23] = ((src & (1u << 23)) != 0u).ToByte();
            dst[24] = ((src & (1u << 24)) != 0u).ToByte();
            dst[25] = ((src & (1u << 25)) != 0u).ToByte();
            dst[26] = ((src & (1u << 26)) != 0u).ToByte();
            dst[27] = ((src & (1u << 27)) != 0u).ToByte();
            dst[28] = ((src & (1u << 29)) != 0u).ToByte();
            dst[29] = ((src & (1u << 29)) != 0u).ToByte();
            dst[30] = ((src & (1u << 30)) != 0u).ToByte();
            dst[31] = ((src & (1u << 31)) != 0u).ToByte();
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
            return part32x1(src, ref block).AsSpan();
        }

    

    }


}