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
        /// Partitions an 8-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part8x4 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << 4,

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
        /// Partitions an 12-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part12x4 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << 4,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part2 = Part1 << 4,

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
        /// Partitions an 16-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part16x4 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

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
        /// Partitions a 20-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part20x4 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 20,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies the first partition
            /// </summary>
            Part0 = Part4x1.Select,

            /// <summary>
            /// Identifies the second 4-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 4-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth four bits
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fourth four bits
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
        /// Partitions a 24-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part24x4 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

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
 
        /// <summary>
        /// Partitions a 28-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part28x4 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 28,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

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
            /// Specifies partition 7
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part6,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6
        }
 
        /// <summary>
        /// Partitions a 32-bit container into 4-bit segments
        /// </summary>
        [Flags]
        public enum Part32x4 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part4x1.Select,

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
            /// Specifies partition 7
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Specifies partition 8
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
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7
        }
 

        /// <summary>
        /// Partitions a 64-bit container into 16 4-bit segments
        /// </summary>
        [Flags]
        public enum Part64x4 : ulong
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 64,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 4,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part4x1.Select,
            
            /// <summary>
            /// Specifies partition 2
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
            /// Specifies partition 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Specifies partition 7
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Specifies partition 8
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Specifies partition 9
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Specifies partition 10
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Specifies partition 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Specifies partition 12
            /// </summary>
            Part12 = Part11 << (int)Width,

             /// <summary>
             /// Specifies partition 13
            /// </summary>
            Part13 = Part12 << (int)Width,

             /// <summary>
            /// Specifies partition 14
            /// </summary>
            Part14 = Part13 << (int)Width,

            /// <summary>
            /// Specifies partition 15
            /// </summary>
            Part15 = Part14 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part15,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10 | Part11 | Part12 | Part13 | Part14 | Part15
        }

    }
}