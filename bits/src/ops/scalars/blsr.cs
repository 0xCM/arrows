//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _blsr_u32 (unsigned int a) BLSR reg, reg/m32
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte blsr(byte src)
            => (byte)ResetLowestSetBit(src);
 
        /// <summary>
        /// unsigned int _blsr_u32 (unsigned int a) BLSR reg, reg/m32
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort blsr(ushort src)
            => (ushort)ResetLowestSetBit(src);
 
        /// <summary>
        /// unsigned int _blsr_u32 (unsigned int a) BLSR reg, reg/m32
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint blsr(uint src)
            => ResetLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsr_u64 (unsigned __int64 a) BLSR reg, reg/m64
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong blsr(ulong src)
            => ResetLowestSetBit(src);
    }
}