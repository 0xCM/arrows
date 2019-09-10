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
    /// Defines common 4-bit masks
    /// </summary>
    [Flags]
    public enum BitMask4 : byte
    {
        /// <summary>
        /// Identifies the most significant bit 
        /// </summary>
        Msb4 = Msb4x1.Select,

        /// <summary>
        /// Identifies the least significant bit 
        /// </summary>
        Lsb4 = Lsb4x1.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even4x1.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd4x1.Select,

        /// <summary>
        /// Selects all 4 bits
        /// </summary>
        All = Odd | Even
    }


}