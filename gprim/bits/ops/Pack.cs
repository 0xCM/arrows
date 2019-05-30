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

        public static Span<uint> pack(ReadOnlySpan<byte> src, Span<uint> dst)            
        {
            var srcIx = 0;
            var dstOffset = 0;
            var dstIx = 0;
            var srcSize = SizeOf<byte>.BitSize;
            var dstSize = SizeOf<uint>.BitSize;
            while(srcIx < src.Length && dstIx < dst.Length)
            {
                for(var i = 0; i< srcSize; i++)
                    if(gbits.test(src[srcIx], i))
                        gbits.enable(ref dst[dstIx], dstOffset + i);

                srcIx++;
                if((dstOffset + srcSize) >= dstSize)
                {
                    dstOffset = 0;
                    dstIx++;
                }
                else
                    dstOffset += srcSize;
            }
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
        public static byte pack8(
            in byte x00, in byte x01, in byte x02, in byte x03, 
            in byte x04, in byte x05, in byte x06, in byte x07)
        {
            var dst = Zero;
            
            if(x00 != Zero)
                enable(ref dst,0);
            
            if(x01 != Zero)
                enable(ref dst,1);
            
            if(x02 != Zero)
                enable(ref dst,2);

            if(x03 != Zero)
                enable(ref dst,3);

            if(x04 != Zero)
                enable(ref dst,4);

            if(x05 != Zero)
                enable(ref dst,5);

            if(x06 != Zero)
                enable(ref dst,6);

            if(x07 != Zero)
                enable(ref dst,7);
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static byte pack8(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, in Bit x07)
        {
            var dst = (byte)0;
            if(x00)
                enable(ref dst, 0);
            
            if(x01)
                enable(ref dst, 1);
            
            if(x02)
                enable(ref dst, 2);

            if(x03)
                enable(ref dst, 3);

            if(x04)
                enable(ref dst, 4);

            if(x05)
                enable(ref dst, 5);

            if(x06)
                enable(ref dst, 6);

            if(x07)
                enable(ref dst,7);
            
            return dst;
        }

        [MethodImpl(Inline)]
        public static sbyte pack8(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, Sign sign)
        {
            var dst = (sbyte)0;

            if(x00)
                enable(ref dst, 0);
            
            if(x01)
                enable(ref dst, 1);
            
            if(x02)
                enable(ref dst, 2);

            if(x03)
                enable(ref dst, 3);

            if(x04)
                enable(ref dst, 4);

            if(x05)
                enable(ref dst, 5);

            if(x06)
                enable(ref dst, 6);
            
            return sign == Sign.Negative ? dst.Negate() : dst;
        }

        [MethodImpl(Inline)]
        public static ushort pack16(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, in Bit x07,
            in Bit x08, in Bit x09, in Bit x10, in Bit x11, 
            in Bit x12, in Bit x13, in Bit x14, in Bit x15)
        
        {
            var dst = (ushort)0;

            if(x00)
                enable(ref dst, 0);
            
            if(x01)
                enable(ref dst, 1);
            
            if(x02)
                enable(ref dst, 2);

            if(x03)
                enable(ref dst, 3);

            if(x04)
                enable(ref dst, 4);

            if(x05)
                enable(ref dst, 5);

            if(x06)
                enable(ref dst, 6);

            if(x07)
                enable(ref dst, 7);

            if(x08)
                enable(ref dst, 8);
            
            if(x09)
                enable(ref dst, 9);
            
            if(x10)
                enable(ref dst, 10);

            if(x11)
                enable(ref dst, 11);

            if(x12)
                enable(ref dst, 12);

            if(x13)
                enable(ref dst, 13);

            if(x14)
                enable(ref dst, 14);

            if(x15)
                enable(ref dst, 15);

            return dst;
        }


        /// <summary>
        /// Packs uint8[2] => uint16
        /// </summary>
        /// <param name="x0">The low-order bits</param>
        /// <param name="x1">The high-order bits</param>
        [MethodImpl(Inline)]
        public static ushort pack16(in byte x0, in byte x1)
            => (ushort) ((ushort)x1 << 8 | (ushort)x0);
 

        [MethodImpl(Inline)]
        public static uint pack32(
            in Bit x00, in Bit x01, in Bit x02, in Bit x03, 
            in Bit x04, in Bit x05, in Bit x06, in Bit x07,
            in Bit x08, in Bit x09, in Bit x10, in Bit x11, 
            in Bit x12, in Bit x13, in Bit x14, in Bit x15,
            in Bit x16, in Bit x17, in Bit x18, in Bit x19, 
            in Bit x20, in Bit x21, in Bit x22, in Bit x23,
            in Bit x24, in Bit x25, in Bit x26, in Bit x27, 
            in Bit x28, in Bit x29, in Bit x30, in Bit x31
            )
        {
            var dst = 0u;

            if(x00) enable(ref dst, 0);            
            if(x01) enable(ref dst, 1);            
            if(x02) enable(ref dst, 2);
            if(x03) enable(ref dst, 3);

            if(x04) enable(ref dst, 4);
            if(x05) enable(ref dst, 5);
            if(x06) enable(ref dst, 6);
            if(x07) enable(ref dst, 7);

            if(x08) enable(ref dst, 8);            
            if(x09) enable(ref dst, 9);            
            if(x10) enable(ref dst, 10);
            if(x11) enable(ref dst, 11);

            if(x12) enable(ref dst, 12);
            if(x13) enable(ref dst, 13);
            if(x14) enable(ref dst, 14);
            if(x15) enable(ref dst, 15);

            if(x16) enable(ref dst,16);            
            if(x17) enable(ref dst,17);
            if(x18) enable(ref dst,18);
            if(x19) enable(ref dst,19);

            if(x20)
                enable(ref dst,20);

            if(x21)
                enable(ref dst,21);

            if(x22)
                enable(ref dst,22);

            if(x23)
                enable(ref dst,23);

            if(x24)
                enable(ref dst,24);

            if(x25)
                enable(ref dst,25);
            
            if(x26)
                enable(ref dst,26);
            
            if(x27)
                enable(ref dst,27);

            if(x28)
                enable(ref dst,28);

            if(x29)
                enable(ref dst,29);

            if(x30)
                enable(ref dst,30);

            if(x31)
                enable(ref dst,31);

            return dst;
        }

        /// <summary>
        /// Packs uint8[4] => uint32
        /// </summary>
        /// <param name="x0">Bit indices [0 .. 7] </param>
        /// <param name="x1">Bit indices [8 .. 15]</param>
        /// <param name="x2">Bit indices [16 .. 25]</param>
        /// <param name="x3">Bit indices [24 .. 31]</param>
        [MethodImpl(Inline)]
        public static uint pack32(byte x0, byte x1, byte x2, byte x3)
        {
            return BitConverter.ToUInt32(new byte[] {x0, x1,x2,x3});
        }
            

        [MethodImpl(Inline)]
        public static uint pack32(in ushort x0, in ushort x1)
            => (uint)x1 << 16 | (uint)x0;

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
        public static ulong pack64(
            in byte x0, in byte x1, in byte x2, in byte x3, 
            in byte x4, in byte x5, in byte x6, in byte x7)
        {
            Span<byte> src = stackalloc byte[8]{x0, x1, x2, x3, x4, x5, x6, x7};
            return BitConverter.ToUInt64(src);
        }

        [MethodImpl(Inline)]
        public static ulong pack64(in uint x0, in uint x1)
            => (ulong)x1 << 32 | (ulong)x0;
    
        /// <summary>
        /// Concatenates the bits of four ushort values to produce a ulong value
        /// </summary>
        /// <param name="x0">The least significant bits [0..15] of the result</param>
        /// <param name="x1">Bits [16..31] of the result</param>
        /// <param name="x2">Bits [32..47] of the result</param>
        /// <param name="x3">The most significant bits [32..63] of the result</param>
        [MethodImpl(Inline)]
        public static ulong pack64(in ushort x0, in ushort x1, in ushort x2, in ushort x3)
            => pack64(pack32(x0,x1), pack32(x2,x3));    

        public static u128 pack128(in Span<Bit> src)
        {
            var x1 = 0ul;
            bitpack(src, out ulong x0);
            if(src.Length >= 64) 
                bitpack(src.Slice(64), out x1);                
            return u128.Define(x0,x1);
        } 
    }
}