//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static BitMasks;

    /// <summary>
    /// Defines common 64-bit masks
    /// </summary>
    [Flags]
    public enum BitMask64 : ulong
    {
        /// <summary>
        /// Identifies the most significant bit of each byte
        /// </summary>
        Msb8 = Msb64x8.Select,

        /// <summary>
        /// Identifies the least significant bit of each byte
        /// </summary>
        Lsb8 = Lsb64x8.Select,

        /// <summary>
        /// Identifies every other odd bit in a 64-bit segment
        /// </summary>
        Odd = Odd64x8.Select,

        /// <summary>
        /// Identifies every other odd bit in a 64-bit segment
        /// </summary>
        Even = Even64x8.Select,

        /// <summary>
        /// Selects all 64 bits
        /// </summary>
        All = Odd | Even
    }

}