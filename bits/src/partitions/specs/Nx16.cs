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
        /// Partitions a 32-bit container into 16-bit segments
        /// </summary>
        [Flags]
        public enum Part32x16 : uint
        {
            /// <summary>
            /// The total count of partitioned bits
            /// </summary>
            Length = 32,

            /// <summary>
            /// The partition width
            /// </summary>
            Width = 16,

            /// <summary>
            /// The partition count
            /// </summary>
            Count = Length/Width,

            /// <summary>
            /// Identifies the first 8-bit group
            /// </summary>
            Part0 = Part16x1.Select,

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

    }

}