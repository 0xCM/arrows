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
    /// Defines common 32-bit masks
    /// </summary>
    [Flags]
    public enum BitMask32 : uint
    {
        /// <summary>
        /// Identifies the most significant bit in each byte
        /// </summary>
        Msb8 = Msb32x8.Select,

        /// <summary>
        /// Identifies the least significant bit in each byte
        /// </summary>
        Lsb8 = Lsb32x8.Select,

        /// <summary>
        /// Identifies every other odd bit
        /// </summary>
        Odd = Odd32x8.Select,

        /// <summary>
        /// Identifies every other even bit
        /// </summary>
        Even = Even32x8.Select,

        /// <summary>
        /// Identifies every bit
        /// </summary>
        Ones = Odd | Even
    }

 

}