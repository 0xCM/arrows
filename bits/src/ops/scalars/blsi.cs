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
        /// unsigned int _blsi_u32 (unsigned int a) BLSI reg, reg/m32
        /// Extracts the lowest set bit, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte blsi(byte src)
            => (byte)ExtractLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a) BLSI reg, reg/m32
        /// Extracts the lowest set bit, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort blsi(ushort src)
            => (ushort)ExtractLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a) BLSI reg, reg/m32
        /// Extracts the lowest set bit, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint blsi(uint src)
            => ExtractLowestSetBit(src);

        /// <summary>
        /// __int64 _blsi_u64 (unsigned __int64 a) BLSI reg, reg/m64
        /// Extracts the lowest set bit, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong blsi(ulong src)
            => ExtractLowestSetBit(src);
 
 
 
    }

}