//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
 
    using static zfunc;
    using static As;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b    
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static byte trunc(byte src, byte len)
            => (byte)ZeroHighBits(src, len);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b    
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static ushort trunc(ushort src, byte len)
            => (ushort)ZeroHighBits(src, len);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b    
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static uint trunc(uint src, byte len)
            => ZeroHighBits(src, len);

        /// <summary>
        /// unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a, reg/m32, r64b 
        /// Clears bits external to the segment [0..(len - 1)]
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="len">The count of lower bits that go unmolested</param>
        [MethodImpl(Inline)]
        public static ulong trunc(ulong src, byte len)
            => ZeroHighBits(src, len);



    }

}