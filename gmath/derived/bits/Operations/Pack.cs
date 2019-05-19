//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Packs bools into bytes
        /// </summary>
        /// <param name="src">The source values</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/713057/convert-bool-to-byte</remarks>
        [MethodImpl(NotInline)]
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
        /// <param name="x00">The value to be packed into the least significant bit</param>
        /// <param name="x01">The second value</param>
        /// <param name="x02">The third value</param>
        /// <param name="x03">The fourth value</param>
        /// <param name="x04">The fifth value</param>
        /// <param name="x05">The sixth value</param>
        /// <param name="x06">The seventh value</param>
        /// <param name="x00">The value to be packed into the most significant bit</param>
        [MethodImpl(Inline)]
        public static byte bitpack(byte x00, byte x01, byte x02, byte x03, byte x04, byte x05, byte x06, byte x07)
        {
            var dst = Zero;
            
            if(x00 != Zero)
                dst |= enable(dst,0);
            
            if(x01 != Zero)
                dst |= enable(dst,1);
            
            if(x02 != Zero)
                dst |= enable(dst,2);

            if(x03 != Zero)
                dst |= enable(dst,3);

            if(x04 != Zero)
                dst |= enable(dst,4);

            if(x05 != Zero)
                dst |= enable(dst,5);

            if(x06 != Zero)
                dst |= enable(dst,6);

            if(x07 != Zero)
                dst |= enable(dst,7);
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static byte bitpack(Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07)
        {
            var dst = (byte)0;
            if(x00)
                dst |= enable(dst,0);
            
            if(x01)
                dst |= enable(dst,1);
            
            if(x02)
                dst |= enable(dst,2);

            if(x03)
                dst |= enable(dst,3);

            if(x04)
                dst |= enable(dst,4);

            if(x05)
                dst |= enable(dst,5);

            if(x06)
                dst |= enable(dst,6);

            if(x07)
                dst |= enable(dst,7);
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static sbyte bitpack(Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Sign sign)
        {
            var dst = (sbyte)0;

            if(x00)
                dst |= enable(dst,0);
            
            if(x01)
                dst |= enable(dst,1);
            
            if(x02)
                dst |= enable(dst,2);

            if(x03)
                dst |= enable(dst,3);

            if(x04)
                dst |= enable(dst,4);

            if(x05)
                dst |= enable(dst,5);

            if(x06)
                dst |= enable(dst,6);

            
            return sign == Sign.Negative ? dst.Negate() : dst;
        }

        [MethodImpl(Inline)]
        public static ushort bitpack(
            Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07,
            Bit x08, Bit x09, Bit x10, Bit x11, Bit x12, Bit x13, Bit x14, Bit x15)
        
        {
            var dst = (ushort)0;

            if(x00)
                dst |= enable(dst,0);
            
            if(x01)
                dst |= enable(dst,1);
            
            if(x02)
                dst |= enable(dst,2);

            if(x03)
                dst |= enable(dst,3);

            if(x04)
                dst |= enable(dst,4);

            if(x05)
                dst |= enable(dst,5);

            if(x06)
                dst |= enable(dst,6);

            if(x07)
                dst |= enable(dst,7);

            if(x08)
                dst |= enable(dst,8);
            
            if(x09)
                dst |= enable(dst,9);
            
            if(x10)
                dst |= enable(dst,10);

            if(x11)
                dst |= enable(dst,11);

            if(x12)
                dst |= enable(dst,12);

            if(x13)
                dst |= enable(dst,13);

            if(x14)
                dst |= enable(dst,14);

            if(x15)
                dst |= enable(dst,15);

            return dst;
        }

        public static byte pack8(Span<Bit> src)
        {
            var dst = Byte.MinValue; 
            for(var i = 0; i < math.min(Pow2.T03, src.Length); i++)
                if(src[i])
                    dst |= Pow2.PowU8(i);
            return dst;
        }

        public static ushort pack16(Span<Bit> src)
        {
            var dst = UInt16.MinValue; 
            for(var i = 0; i < math.min(Pow2.T04, src.Length); i++)
                if(src[i])
                    dst |= Pow2.PowU16(i);
            return dst;
        }

        public static uint pack32(Span<Bit> src)
        {
            var dst = UInt32.MinValue; 
            for(var i = 0; i < math.min(Pow2.T05, src.Length); i++)
                if(src[i])
                    dst |= Pow2.PowU32(i);
            return dst;
        }

        public static ulong pack64(Span<Bit> src)
        {
            var dst = UInt64.MinValue; 
            for(var i = 0; i < math.min(Pow2.T06, src.Length); i++)
                if(src[i])
                    dst |= Pow2.PowU32(i);
            return dst;
        }

        public static U128 pack128(Span<Bit> src)
        {
            var x0 = pack64(src);
            var x1 = src.Length >= 64 ? pack64(src.Slice(64)) : 0ul;
            return U128.Define(x0,x1);
        }

        [MethodImpl(Inline)]
        public static uint bitpack(
            Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07,
            Bit x08, Bit x09, Bit x10, Bit x11, Bit x12, Bit x13, Bit x14, Bit x15,
            Bit x16, Bit x17, Bit x18, Bit x19, Bit x20, Bit x21, Bit x22, Bit x23,
            Bit x24, Bit x25, Bit x26, Bit x27, Bit x28, Bit x29, Bit x30, Bit x31
            )
        
        {
            var dst = 0u;

            if(x00)
                dst |= enable(dst,0);
            
            if(x01)
                dst |= enable(dst,1);
            
            if(x02)
                dst |= enable(dst,2);

            if(x03)
                dst |= enable(dst,3);

            if(x04)
                dst |= enable(dst,4);

            if(x05)
                dst |= enable(dst,5);

            if(x06)
                dst |= enable(dst,6);

            if(x07)
                dst |= enable(dst,7);

            if(x08)
                dst |= enable(dst,8);
            
            if(x09)
                dst |= enable(dst,9);
            
            if(x10)
                dst |= enable(dst,10);

            if(x11)
                dst |= enable(dst,11);

            if(x12)
                dst |= enable(dst,12);

            if(x13)
                dst |= enable(dst,13);

            if(x14)
                dst |= enable(dst,14);

            if(x15)
                dst |= enable(dst,15);

            if(x16)
                dst |= enable(dst,16);
            
            if(x17)
                dst |= enable(dst,17);

            if(x18)
                dst |= enable(dst,18);

            if(x19)
                dst |= enable(dst,19);

            if(x20)
                dst |= enable(dst,20);

            if(x21)
                dst |= enable(dst,21);

            if(x22)
                dst |= enable(dst,22);

            if(x23)
                dst |= enable(dst,23);

            if(x24)
                dst |= enable(dst,24);

            if(x25)
                dst |= enable(dst,25);
            
            if(x26)
                dst |= enable(dst,26);
            
            if(x27)
                dst |= enable(dst,27);

            if(x28)
                dst |= enable(dst,28);

            if(x29)
                dst |= enable(dst,29);

            if(x30)
                dst |= enable(dst,30);

            if(x31)
                dst |= enable(dst,31);

            return dst;
        }

        /// <summary>
        /// Packs uint8[2] => uint16
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static ushort pack(byte x0, byte x1)
            => (ushort) ((ushort)x1 << 8 | (ushort)x0);

        /// <summary>
        /// Packs uint8[4] => uint32
        /// </summary>
        /// <param name="x0">Bit indices [0 .. 7] </param>
        /// <param name="x1">Bit indices [8 .. 15]</param>
        /// <param name="x2">Bit indices [16 .. 25]</param>
        /// <param name="x3">Bit indices [24 .. 31]</param>
        [MethodImpl(Inline)]
        public static uint pack(byte x0, byte x1, byte x2, byte x3)
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
        public static ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
            => BitConverter.ToUInt32(array(x0,x1,x2,x3,x4,x5,x6,x7));
 
        /// <summary>
        /// Constructs a short value from two signed byte values
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static short pack(sbyte x0, sbyte x1)
            => (short)((int)x1 << 8 | (int)(byte)(x0));

        /// <summary>
        /// Constructs a int value from two short values
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static int pack(short x0, short x1)
            => (int)x1 << 16 | (int)(ushort)x0;
 
         /// <summary>
        /// Constructs a long value from two int values
        /// </summary>
        /// <param name="x1">The high-order bits</param>
        /// <param name="x0">The low-order bits</param>
        [MethodImpl(Inline)]
        public static long pack(int x0, int x1)
            => (long)x1 << 32 | (long)(uint)x0;

        /// <summary>
        /// Concatenates the bits of four short values to produce a long value
        /// </summary>
        /// <param name="x0">The least significant bits [0..15] of the result</param>
        /// <param name="x1">Bits [16..31] of the result</param>
        /// <param name="x2">Bits [32..47] of the result</param>
        /// <param name="x3">The most significant bits [32..63] of the result</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static long pack(short x0, short x1, short x2, short x3)
            => pack(pack(x0,x1), pack(x2,x3));

        [MethodImpl(Inline)]
        public static uint pack(ushort x0, ushort x1)
            => (uint)x1 << 16 | (uint)x0;

        /// <summary>
        /// (uint,uint) => ulong
        /// </summary>
        /// <param name="x1">The high-order bits</param>
        /// <param name="x0">The low-order bits</param>
        [MethodImpl(Inline)]
        public static ulong pack(uint x0, uint x1)
            => (ulong)x1 << 32 | (ulong)x0;
    
        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
            => pack(pack(x0,x1), pack(x2,x3));
    
    }

}