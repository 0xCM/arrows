//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {         
        /// <summary>
        /// Condenses two uint8 values into a single uint16 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 8 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 8 bits of the output</param>
        [MethodImpl(Inline)]
        public static ushort pack(byte x0, byte x1)
            => (ushort)(
              (ushort)x0 << 0 * 8
            | (ushort)x1 << 1 * 8
            );

        /// <summary>
        /// Condenses two uint16 values into a single uint32 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 8 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 8 bits of the output</param>
        [MethodImpl(Inline)]
        public static uint pack(ushort x0, ushort x1)
              => (uint)x0 << 0 * 16
               | (uint)x1 << 1 * 16;

        /// <summary>
        /// Condenses two uint32 values into a single uint64 value
        /// </summary>
        /// <param name="x0">The value to be mapped to the lo 32 bits of the output</param>
        /// <param name="x1">The value to be mapped to the hi 32 bits of the output</param>
        [MethodImpl(Inline)]
        public static ulong pack(in uint x0, in uint x1)
              => (ulong)x0 | (ulong)x1 << 32;

        
        [MethodImpl(Inline)]
        public static uint pack(byte x0, byte x1, byte x2, byte x3)
              =>  (uint)x0 << 0 * 8
                | (uint)x1 << 1 * 8
                | (uint)x2 << 2 * 8
                | (uint)x3 << 3 * 8;

        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)        
            => (ulong)x0 << 0 * 16
            |  (ulong)x1 << 1 * 16
            |  (ulong)x1 << 2 * 16
            |  (ulong)x1 << 3 * 16;

        [MethodImpl(Inline)]
        public static ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {            
            return 
              (ulong)x0 << 0 * 8
            | (ulong)x1 << 1 * 8
            | (ulong)x2 << 2 * 8
            | (ulong)x3 << 3 * 8
            | (ulong)x4 << 4 * 8
            | (ulong)x5 << 5 * 8
            | (ulong)x6 << 6 * 8
            | (ulong)x7 << 7 * 8
            ;
        }        

        /// <summary>
        /// Selects a bit from each byte at a specified position packs these 8 bits into a single byte
        /// </summary>
        /// <param name="x00">The value to be packed into the least significant bit</param>
        /// <param name="x01">The second value</param>
        /// <param name="x02">The third value</param>
        /// <param name="x03">The fourth value</param>
        /// <param name="x04">The fifth value</param>
        /// <param name="x05">The sixth value</param>
        /// <param name="x06">The seventh value</param>
        /// <param name="x00">The value to be packed into the most significant bit</param>
        [MethodImpl(Inline)]
        public static ref byte pack(in byte x0, in byte x1, in byte x2, in byte x3, in byte x4, in byte x5, in byte x6, in byte x7, in byte pos, ref byte dst)
        {
          if(BitMask.test(x0, pos)) BitMask.enable(ref dst, 0);
          if(BitMask.test(x1, pos)) BitMask.enable(ref dst, 1);
          if(BitMask.test(x2, pos)) BitMask.enable(ref dst, 2);
          if(BitMask.test(x3, pos)) BitMask.enable(ref dst, 3);
          if(BitMask.test(x4, pos)) BitMask.enable(ref dst, 4);
          if(BitMask.test(x5, pos)) BitMask.enable(ref dst, 5);
          if(BitMask.test(x6, pos)) BitMask.enable(ref dst, 6);
          if(BitMask.test(x7, pos)) BitMask.enable(ref dst, 7);
          return ref dst;
        }

        /// <summary>
        /// Packs bools into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        public static byte[] pack(params bool[] src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            var dst = new byte[dstLen];
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)((byte)1 << (i & 0x07));
            
            return dst;
        }
 
    }
}