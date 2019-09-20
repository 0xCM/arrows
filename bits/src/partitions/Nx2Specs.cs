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
        /// Paritions a 4-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part4x2 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 4,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,
            
            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1,
        }

        /// <summary>
        /// Partitions a 6-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part6x2 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 2-bit group
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Identifies the second 2-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 2-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2
        }


        /// <summary>
        /// Partitions am 8-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part8x2 : byte
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 8,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies the first partition
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Specifies the Second partition
            /// </summary>
            Part1 = Part0 << 2,

            /// <summary>
            /// Specifies the third partition
            /// </summary>
            Part2 = Part1 << 2,

            /// <summary>
            /// Specifies the fourth partition
            /// </summary>
            Part3 = Part2 << 2,

            /// <summary>
            /// Identifies the fist partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part3,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3,
        }

        /// <summary>
        /// Partitions a 10-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part10x2 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 10,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part2x1.Select,

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
            Select = Part0 | Part1 | Part2 | Part3 | Part4,
        }
 
        /// <summary>
        /// Partitions a 12-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part12x2 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part2x1.Select,

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
            /// Specifies partition 4
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Specifies partition 5
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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5,
        }
 

        /// <summary>
        /// Partitions a 14-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part14x2 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 14,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part1 = Part0 << 2,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part2 = Part1 << 2,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part3 = Part2 << 2,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part4 = Part3 << 2,

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part5 = Part4 << 2,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part6 = Part5 << 2,

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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6,
        }
 
        /// <summary>
        /// Partitions a 16-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part16x2 : ushort
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 16,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << 2,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part2 = Part1 << 2,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part3 = Part2 << 2,

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part4 = Part3 << 2,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part5 = Part4 << 2,

            /// <summary>
            /// Specifies partition 7
            /// </summary>
            Part6 = Part5 << 2,

            /// <summary>
            /// Specifies partition 8
            /// </summary>
            Part7 = Part6 << 2,

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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7,
        }

        /// <summary>
        /// Partitions a 18-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part18x2 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 18,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part2x1.Select,

            /// <summary>
            /// Specifies partition 2
            /// </summary>
            Part1 = Part0 << 2,

            /// <summary>
            /// Specifies partition 3
            /// </summary>
            Part2 = Part1 << 2,

            /// <summary>
            /// Specifies partition 4
            /// </summary>
            Part3 = Part2 << 2,

            /// <summary>
            /// Specifies partition 5
            /// </summary>
            Part4 = Part3 << 2,

            /// <summary>
            /// Specifies partition 6
            /// </summary>
            Part5 = Part4 << 2,

            /// <summary>
            /// Specifies partition 7
            /// </summary>
            Part6 = Part5 << 2,

            /// <summary>
            /// Specifies partition 8
            /// </summary>
            Part7 = Part6 << 2,

            /// <summary>
            /// Specifies partition 9
            /// </summary>
            Part8 = Part7 << 2,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part8,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8,
        }


        /// <summary>
        /// Partitions a 20-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part20x2 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 20,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part2x1.Select,

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
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part9,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9,
        }


        /// <summary>
        /// Partitions a 32-bit container into 2-bit segments
        /// </summary>
        [Flags]
        public enum Part32x2 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 2,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 0
            /// </summary>
            Part0 = Part2x1.Select,

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
            Select = Part0 | Part1 | Part2 | Part3   | Part4  | Part5  | Part6  | Part7 
                   | Part8 | Part9 | Part10 | Part11 | Part12 | Part13 | Part14 | Part15,
        }


    }

}