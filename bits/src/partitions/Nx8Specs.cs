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
    using static BitMasks;

    
    partial class BitParts
    {        
        /// <summary>
        /// Partitions a 16-bit container into 8-bit segments
        /// </summary>
        [Flags]
        public enum Part16x8 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part8x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part1,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1
        }


        /// <summary>
        /// Partitions a 24-bit container into 8-bit segments
        /// </summary>
        [Flags]
        public enum Part24x8 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part6x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 8-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part2,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2
        }

        /// <summary>
        /// Partitions a 32-bit container into 8-bit sgments
        /// </summary>
        [Flags]
        public enum Part32x8 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part8x1.Select,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3
        }

        /// <summary>
        /// Partitions a 40-bit container into 8-bit sgments
        /// </summary>
        [Flags]
        public enum Part40x8 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part6x1.Select,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part4,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4
        }

        /// <summary>
        /// Partitions a 64-bit container into 8-bit segments
        /// </summary>
        [Flags]
        public enum Part64x8 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 64,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 8,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part8x1.Select,

            /// <summary>
            /// Identifies the second 8-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 8-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 8-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 8-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 8-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 8-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 8-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,
            
            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part7,

            /// <summary>
            /// Selects all bits in the partition
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7

        }


    }

}