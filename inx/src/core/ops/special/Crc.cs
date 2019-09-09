//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
            
    using static zfunc;    

    using CRC = System.Runtime.Intrinsics.X86.Sse42;
    using CRC64 = System.Runtime.Intrinsics.X86.Sse42.X64; 

    /// <summary>
    /// Surfaces CRC intrinsics
    /// </summary>
    public static class Crc
    {
        /// <summary>
        /// unsigned int _mm_crc32_u8 (unsigned int crc, unsigned char v) CRC32 reg, reg/m8
        /// </summary>
        /// <param name="crc"></param>
        /// <param name="data"></param>
        [MethodImpl(Inline)]
        public static uint crc(uint crc, byte data)
            => CRC.Crc32(crc,data);

        /// <summary>
        /// unsigned int _mm_crc32_u16 (unsigned int crc, unsigned short v) CRC32 reg, reg/m16
        /// </summary>
        /// <param name="crc"></param>
        /// <param name="data"></param>
        [MethodImpl(Inline)]
        public static uint crc(uint crc, ushort data)
            => CRC.Crc32(crc,data);

        /// <summary>
        /// unsigned int _mm_crc32_u32 (unsigned int crc, unsigned int v) CRC32 reg, reg/m32 
        /// </summary>
        /// <param name="crc"></param>
        /// <param name="data"></param>
        [MethodImpl(Inline)]
        public static uint crc(uint crc, uint data)
            => CRC.Crc32(crc,data);

        /// <summary>
        /// nsigned __int64 _mm_crc32_u64 (unsigned __int64 crc, unsigned __int64 v) CRC32 reg, reg/m64 
        /// </summary>
        /// <param name="crc"></param>
        /// <param name="data"></param>
        [MethodImpl(Inline)]
        public static ulong crc(uint crc, ulong data)
            => CRC64.Crc32(crc,data);


    }


}