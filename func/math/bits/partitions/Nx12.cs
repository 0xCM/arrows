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
        /// Partitions a 24-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part24x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 24,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part12x1.Select,

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
        /// Partitions a 36-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part36x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 36,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part12x1.Select,

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
        /// Partitions a 36-bit container into 12-bit segments
        /// </summary>
        [Flags]
        public enum Part48x12 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 48,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 12,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Specifies partition 1
            /// </summary>
            Part0 = Part12x1.Select,

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



    }

}