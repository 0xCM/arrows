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
    /// Defines common 8-bit masks
    /// </summary>
    [Flags]
    public enum BitMask8 : byte
    {
        /// <summary>
        /// Identifies the most significant bit 
        /// </summary>
        Msb8 = Msb8x1.Select,

        /// <summary>
        /// Identifies the least significant bit 
        /// </summary>
        Lsb8 = Lsb8x1.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even8x1.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd8x1.Select,

        /// <summary>
        /// Selects all 8 bits
        /// </summary>
        All = Odd | Even
    }


}