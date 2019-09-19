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


    [Flags]
    public enum BitPartKind : uint
    {
        /// <summary>
        /// Identifies a 1x1partition
        /// </summary>
        Part1x1 = (1u << 16) | 1,

        /// <summary>
        /// Identifies a 2x1partition
        /// </summary>
        Part2x1 = (2u << 16) | 1,

        /// <summary>
        /// Identifies a 4x1partition
        /// </summary>
        Part4x1 = (4u << 16) | 1,

        /// <summary>
        /// Identifies a 4x2partition
        /// </summary>
        Part4x2 = (4u << 16) | 1,

        /// <summary>
        /// Identifies a 16x8 partition
        /// </summary>
        P16x8 = (16u << 16) | 8,

        /// <summary>
        /// Identifies a 21x3 partition
        /// </summary>
        P21x3 = (21u << 16) | 3,

        /// <summary>
        /// Identifies a 24x3 partition
        /// </summary>
        P24x3 = (24u << 16) | 3,

        /// <summary>
        /// Identifies a 27x3 partition
        /// </summary>
        P27x3 = (27u << 16) | 3,

        /// <summary>
        /// Identifies a 30x3 partition
        /// </summary>
        P23x3 = (30u << 16) | 3,

        /// <summary>
        /// Identifies a 24x8 partition
        /// </summary>
        P24x8 = (24u << 16) | 8,

        /// <summary>
        /// Identifies a 32x8 partition
        /// </summary>
        P32x8 = (32u << 16) | 8,

        /// <summary>
        /// Identifies a 40x8 partition
        /// </summary>
        P40x8 = (40u << 16) | 8,

        /// <summary>
        /// Identifies a 64x8 partition
        /// </summary>
        P64x8  = (64u << 16) | 8,
    }

}