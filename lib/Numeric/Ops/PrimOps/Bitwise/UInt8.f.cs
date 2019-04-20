//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static BitPackBytes;
    using static zcore;

    using operand = System.Byte;

    static class BitPackBytes
    {
        public const byte Zero = 0;

        public const byte One = 1;

        public const byte Mask00 = 0&7;
    
        public const byte Mask01 = 1&7;
        
        public const byte Mask02 = 2&7;
        
        public const byte Mask03 = 3&7;
        
        public const byte Mask04 = 4&7;
        
        public const byte Mask05 = 5&7;
        
        public const byte Mask06 = 6&7;
        
        public const byte Mask07 = 7&7;

        public const byte LShift00 = One << Mask00;

        public const byte LShift01 = One << Mask01;

        public const byte LShift02 = One << Mask02;

        public const byte LShift03 = One << Mask03;
        
        public const byte LShift04 = One << Mask04;

        public const byte LShift05 = One << Mask05;

        public const byte LShift06 = One << Mask06;

        public const byte LShift07 = One << Mask07;
    }

    public static partial class Bits
    {

        /// <summary>
        /// Packs bools into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        [MethodImpl(Inline)]
        public static byte[] pack(params bool[] src)
        {
            int srcLen = src.Length;
            int dstLen = srcLen >> 3;
            
            if ((srcLen & 0x07) != 0) 
                ++dstLen;

            var dst = new byte[dstLen];
            for (int i = 0; i < srcLen; i++)
                if (src[i])
                    dst[i >> 3] |= (byte)(One << (i & 0x07));
            
            return dst;
        }

        /// <summary>
        /// Packs 8 bytes into a single byte by considering only whether each input value is nonzero.
        /// </summary>
        /// <param name="x0">The value to be packed into the least significant bit</param>
        /// <param name="x1">The second value</param>
        /// <param name="x2">The third value</param>
        /// <param name="x3">The fourth value</param>
        /// <param name="x4">The fifth value</param>
        /// <param name="x5">The sixth value</param>
        /// <param name="x6">The seventh value</param>
        /// <param name="x0">The value to be packed into the most significant bit</param>
        public static byte pack8(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
        {
            var dst = Zero;
            
            if(x0 != Zero)
                dst |= LShift00;
            
            if(x1 != Zero)
                dst |= LShift01;
            
            if(x2 != Zero)
                dst |= LShift02;

            if(x3 != Zero)
                dst |= LShift03;

            if(x4 != Zero)
                dst |= LShift04;

            if(x5 != Zero)
                dst |= LShift05;

            if(x6 != Zero)
                dst |= LShift06;

            if(x7 != Zero)
                dst |= LShift07;
            
            return dst;
        }

        /// <summary>
        /// Packs uint8[2] => uint16
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static ushort pack(operand x0, operand x1)
            => (ushort) ((ushort)x1 << 8 | (ushort)x0);


        /// <summary>
        /// Packs uint8[4] => uint32
        /// </summary>
        /// <param name="x0">Bit indices [0 .. 7] </param>
        /// <param name="x1">Bit indices [8 .. 15]</param>
        /// <param name="x2">Bit indices [16 .. 25]</param>
        /// <param name="x3">Bit indices [24 .. 31]</param>
        [MethodImpl(Inline)]
        public static uint pack(operand x0, operand x1, operand x2, operand x3)
            => BitConverter.ToUInt32(array(x0,x1,x2,x3));


        /// <summary>
        /// Packs uint8[8] => uint64
        /// </summary>
        /// <param name="x0">Bit indices [0 .. 7] </param>
        /// <param name="x1">Bit indices [8 .. 15]</param>
        /// <param name="x2">Bit indices [16 .. 25]</param>
        /// <param name="x3">Bit indices [24 .. 31]</param>
        /// <param name="x4">Bit indices [32 .. 39]</param>
        /// <param name="x5">Bit indices [40 .. 47]</param>
        /// <param name="x6">Bit indices [48 .. 55]</param>
        /// <param name="x7">Bit indices [55 .. 63]</param>
        [MethodImpl(Inline)]
        public static ulong pack(operand x0, operand x1, operand x2, operand x3, operand x4, operand x5, operand x6, operand x7)
            => BitConverter.ToUInt32(array(x0,x1,x2,x3,x4,x5,x6,x7));
    }

}