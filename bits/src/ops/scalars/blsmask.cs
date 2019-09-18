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
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Set all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte blsmask(byte src)
            => (byte)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Set all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort blsmask(ushort src)
            => (ushort)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Set all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint blsmask(uint src)
            => GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsmsk_u64 (unsigned __int64 a) BLSMSK reg, reg/m6
        /// Set all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong blsmask(ulong src)
            => GetMaskUpToLowestSetBit(src);
    }

}