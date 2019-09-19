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
        /// Partitions as 12-bit container into 6-bit segments
        /// </summary>
        [Flags]
        public enum Part12x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

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
        /// Partitions as 18-bit container into 6-bit segments
        /// </summary>
        [Flags]
        public enum Part18x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 18,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

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
        /// Partitions as 24-bit container into 6-bit segments
        /// </summary>
        [Flags]
        public enum Part24x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

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
        /// Partitions as 30-bit container into 6-bit segments
        /// </summary>
        [Flags]
        public enum Part30x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 30,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

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
            /// Specifies partition 5
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
        /// Partitions as 36-bit container into 6-bit segments
        /// </summary>
        [Flags]
        public enum Part36x6 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 36,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 6,

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
            /// Specifies partition 5
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part5,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5

        }

    }

}