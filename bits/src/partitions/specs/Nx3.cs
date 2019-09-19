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
        /// Partitions a 6-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part6x3 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 6,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1
        }


        /// <summary>
        /// Partitions a 9-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part9x3 : ushort
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 9,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
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
            Select = Part0 |  Part1 |  Part2

        }

        /// <summary>
        /// Partitions a 12-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part12x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 12,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
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
        /// Partitions a 15-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part15x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 15,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

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
        /// Partitions an 18-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part18x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 18,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
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
        /// Partitions a 21-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part21x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 21,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 3-bit group
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6,
        }

        /// <summary>
        /// Partitions a 24-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part24x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

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
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7,

        }

        /// <summary>
        /// Partitions a 27-bit container into 3-bit segments
        /// </summary>
        [Flags]
        public enum Part27x3 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 27,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

            /// <summary>
            /// Identifies the second 3-bit group
            /// </summary>
            Part1 = Part0 << (int)Width,

            /// <summary>
            /// Identifies the third 3-bit group
            /// </summary>
            Part2 = Part1 << (int)Width,

            /// <summary>
            /// Identifies the fourth 3-bit group
            /// </summary>
            Part3 = Part2 << (int)Width,

            /// <summary>
            /// Identifies the fifth 3-bit group
            /// </summary>
            Part4 = Part3 << (int)Width,

            /// <summary>
            /// Identifies the sixth 3-bit group
            /// </summary>
            Part5 = Part4 << (int)Width,

            /// <summary>
            /// Identifies the seventh 3-bit group
            /// </summary>
            Part6 = Part5 << (int)Width,

            /// <summary>
            /// Identifies the eighth 3-bit group
            /// </summary>
            Part7 = Part6 << (int)Width,

            /// <summary>
            /// Identifies the ninth 3-bit group
            /// </summary>
            Part8 = Part7 << (int)Width,

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
       /// Partitions a 30-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part30x3 : uint
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 30,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

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
            /// Specifies partition 9
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Specifies partition 10
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
       /// Partitions a 33-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part33x3 : ulong
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 33,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

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
            /// Specifies partition 9
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Specifies partition 10
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Specifies partition 11
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part10,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10,
        }

       /// <summary>
       /// Partitions a 36-bit container into 3-bit segments
       /// </summary>
        [Flags]
        public enum Part36x3 : ulong
        {            
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 33,

            /// <summary>
            /// The width of each segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part3x1.Select,

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
            /// Specifies partition 9
            /// </summary>
            Part8 = Part7 << (int)Width,

            /// <summary>
            /// Specifies partition 10
            /// </summary>
            Part9 = Part8 << (int)Width,

            /// <summary>
            /// Specifies partition 11
            /// </summary>
            Part10 = Part9 << (int)Width,

            /// <summary>
            /// Specifies partition 11
            /// </summary>
            Part11 = Part10 << (int)Width,

            /// <summary>
            /// Identifies the first partition
            /// </summary>
            First = Part0,

            /// <summary>
            /// Identifies the last partition
            /// </summary>
            Last = Part11,

            /// <summary>
            /// Selects all container bits
            /// </summary>
            Select = Part0 | Part1 | Part2 | Part3 | Part4 | Part5 | Part6 | Part7 | Part8 | Part9 | Part10 | Part11,
        }


 
    }

}