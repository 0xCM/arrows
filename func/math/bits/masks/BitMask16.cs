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

    /// <summary>
    /// Defines common 16-bit masks
    /// </summary>
    [Flags]
    public enum BitMask16 : ushort
    {
        /// <summary>
        /// Identifies the most significant bit 
        /// </summary>
        Msb8 = Msb16x8.Select,

        /// <summary>
        /// Identifies the least significant bit 
        /// </summary>
        Lsb8 = Lsb16x8.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even16x8.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd16x8.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }


}