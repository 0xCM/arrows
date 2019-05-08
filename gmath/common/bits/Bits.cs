//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    public static class Bits
    {                
        const byte Zero = 0;

        const byte One = 1;

        // const byte Mask00 = 0&7;
    
        // const byte Mask01 = 1&7;
        
        // const byte Mask02 = 2&7;
        
        // const byte Mask03 = 3&7;
        
        // const byte Mask04 = 4&7;
        
        // const byte Mask05 = 5&7;
        
        // const byte Mask06 = 6&7;
        
        // const byte Mask07 = 7&7;


        // const byte LShift00 = One << Mask00;

        // const byte LShift01 = One << Mask01;

        // const byte LShift02 = One << Mask02;

        // const byte LShift03 = One << Mask03;
        
        // const byte LShift04 = One << Mask04;

        // const byte LShift05 = One << Mask05;

        // const byte LShift06 = One << Mask06;

        // const byte LShift07 = One << Mask07;

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(byte src)
            => log2((uint)src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(ushort src)
            => log2((uint)src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(uint src)
            => BitOperations.Log2(src);

        /// <summary>
        /// Calculates the base-2 log of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int log2(ulong src)
            => BitOperations.Log2(src);



        # region pack

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
        /// <param name="x00">The value to be packed into the least significant bit</param>
        /// <param name="x01">The second value</param>
        /// <param name="x02">The third value</param>
        /// <param name="x03">The fourth value</param>
        /// <param name="x04">The fifth value</param>
        /// <param name="x05">The sixth value</param>
        /// <param name="x06">The seventh value</param>
        /// <param name="x00">The value to be packed into the most significant bit</param>
        public static byte bitpack(byte x00, byte x01, byte x02, byte x03, byte x04, byte x05, byte x06, byte x07)
        {
            var dst = Zero;
            
            if(x00 != Zero)
                dst |= set(dst,0);
            
            if(x01 != Zero)
                dst |= set(dst,1);
            
            if(x02 != Zero)
                dst |= set(dst,2);

            if(x03 != Zero)
                dst |= set(dst,3);

            if(x04 != Zero)
                dst |= set(dst,4);

            if(x05 != Zero)
                dst |= set(dst,5);

            if(x06 != Zero)
                dst |= set(dst,6);

            if(x07 != Zero)
                dst |= set(dst,7);
            
            return dst;
        }

        public static byte bitpack(Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07)
        {
            var dst = (byte)0;
            if(x00)
                dst |= set(dst,0);
            
            if(x01)
                dst |= set(dst,1);
            
            if(x02)
                dst |= set(dst,2);

            if(x03)
                dst |= set(dst,3);

            if(x04)
                dst |= set(dst,4);

            if(x05)
                dst |= set(dst,5);

            if(x06)
                dst |= set(dst,6);

            if(x07)
                dst |= set(dst,7);
            
            return dst;
        }


        public static sbyte bitpack(Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Sign sign)
        {
            var dst = (sbyte)0;

            if(x00)
                dst |= set(dst,0);
            
            if(x01)
                dst |= set(dst,1);
            
            if(x02)
                dst |= set(dst,2);

            if(x03)
                dst |= set(dst,3);

            if(x04)
                dst |= set(dst,4);

            if(x05)
                dst |= set(dst,5);

            if(x06)
                dst |= set(dst,6);

            
            return sign == Sign.Negative ? dst.Negate() : dst;
        }

        public static ushort bitpack(
            Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07,
            Bit x08, Bit x09, Bit x10, Bit x11, Bit x12, Bit x13, Bit x14, Bit x15)
        
        {
            var dst = (ushort)0;

            if(x00)
                dst |= set(dst,0);
            
            if(x01)
                dst |= set(dst,1);
            
            if(x02)
                dst |= set(dst,2);

            if(x03)
                dst |= set(dst,3);

            if(x04)
                dst |= set(dst,4);

            if(x05)
                dst |= set(dst,5);

            if(x06)
                dst |= set(dst,6);

            if(x07)
                dst |= set(dst,7);

            if(x08)
                dst |= set(dst,8);
            
            if(x09)
                dst |= set(dst,9);
            
            if(x10)
                dst |= set(dst,10);

            if(x11)
                dst |= set(dst,11);

            if(x12)
                dst |= set(dst,12);

            if(x13)
                dst |= set(dst,13);

            if(x14)
                dst |= set(dst,14);

            if(x15)
                dst |= set(dst,15);

            return dst;
        }

        public static uint bitpack(
            Bit x00, Bit x01, Bit x02, Bit x03, Bit x04, Bit x05, Bit x06, Bit x07,
            Bit x08, Bit x09, Bit x10, Bit x11, Bit x12, Bit x13, Bit x14, Bit x15,
            Bit x16, Bit x17, Bit x18, Bit x19, Bit x20, Bit x21, Bit x22, Bit x23,
            Bit x24, Bit x25, Bit x26, Bit x27, Bit x28, Bit x29, Bit x30, Bit x31
            )
        
        {
            var dst = 0u;

            if(x00)
                dst |= set(dst,0);
            
            if(x01)
                dst |= set(dst,1);
            
            if(x02)
                dst |= set(dst,2);

            if(x03)
                dst |= set(dst,3);

            if(x04)
                dst |= set(dst,4);

            if(x05)
                dst |= set(dst,5);

            if(x06)
                dst |= set(dst,6);

            if(x07)
                dst |= set(dst,7);

            if(x08)
                dst |= set(dst,8);
            
            if(x09)
                dst |= set(dst,9);
            
            if(x10)
                dst |= set(dst,10);

            if(x11)
                dst |= set(dst,11);

            if(x12)
                dst |= set(dst,12);

            if(x13)
                dst |= set(dst,13);

            if(x14)
                dst |= set(dst,14);

            if(x15)
                dst |= set(dst,15);

            if(x16)
                dst |= set(dst,16);
            
            if(x17)
                dst |= set(dst,17);

            if(x18)
                dst |= set(dst,18);

            if(x19)
                dst |= set(dst,19);

            if(x20)
                dst |= set(dst,20);

            if(x21)
                dst |= set(dst,21);

            if(x22)
                dst |= set(dst,22);

            if(x23)
                dst |= set(dst,23);

            if(x24)
                dst |= set(dst,24);

            if(x25)
                dst |= set(dst,25);
            
            if(x26)
                dst |= set(dst,26);
            
            if(x27)
                dst |= set(dst,27);

            if(x28)
                dst |= set(dst,28);

            if(x29)
                dst |= set(dst,29);

            if(x30)
                dst |= set(dst,30);

            if(x31)
                dst |= set(dst,31);

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
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (short x0, short x1) split(int src)
            => (lo(src), hi(src));

        /// <summary>
        /// ushort => (byte,byte)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) split(ushort src)
            => (lo(src), hi(src));

        /// <summary>
        /// Splits a short into two sbytes
        /// </summary>
        /// <param name="x0">The source bits [0 .. 7]</param>
        /// <param name="x1">The source bits [8 .. 15]</param>
        [MethodImpl(Inline)]
        public static (sbyte x0, sbyte x1) split(short src)
            => (lo(src),hi(src));

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
        /// long => (int,int)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1) split(long src)
            => (lo(src), hi(src));

        /// <summary>
        /// ulong => (uint,uint)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (uint x0, uint x1) split(ulong src)
            => (lo(src), hi(src));

        /// <summary>
        /// (uint,uint) => ulong
        /// </summary>
        /// <param name="x1">The high-order bits</param>
        /// <param name="x0">The low-order bits</param>
        [MethodImpl(Inline)]
        public static ulong pack(uint x0, uint x1)
            => (ulong)x1 << 32 | (ulong)x0;


        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (ushort hi, ushort lo) split(uint src)
            => (hi(src),lo(src));
 

        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
            => pack(pack(x0,x1), pack(x2,x3));

        #endregion


        #region testbit

        [MethodImpl(Inline)]
        public static bool test(sbyte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(byte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(short src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(ushort src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(int src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(uint src, int pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(long src, int pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool testbit(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(double src, int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool test(float src, int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos);

        #endregion

        #region masks

        [MethodImpl(Inline)]
        static byte LeftMask(byte src, int pos)
            => ((byte)1).LShift(pos);

        [MethodImpl(Inline)]
        static sbyte LeftMask(sbyte src, int pos)
            => ((sbyte)1).LShift(pos);

        [MethodImpl(Inline)]
        static short LeftMask(short src, int pos)
            => ((short)1).LShift(pos);

        [MethodImpl(Inline)]
        static ushort LeftMask(ushort src, int pos)
            => ((ushort)1).LShift(pos);

        [MethodImpl(Inline)]
        static int LeftMask(int src, int pos)
            => 1 << pos;

        [MethodImpl(Inline)]
        static uint LeftMask(uint src, int pos)
            => 1u << pos;

        [MethodImpl(Inline)]
        static long LeftMask(long src, int pos)
            => 1L << pos;

        [MethodImpl(Inline)]
        static ulong LeftMask(ulong src, int pos)
            => 1ul << pos;

        #endregion
        
        #region set

        [MethodImpl(Inline)]
        public static sbyte set(sbyte src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static byte set(byte src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static short set(short src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static short set(ref short src, int pos)
             => src = src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static ushort set(ushort src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static ushort set(ref ushort src, int pos)
             => src = src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static int set(int src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static int set(ref int src, int pos)
             => src = src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static uint set(uint src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static uint set(ref uint src, int pos)
             => src = src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static long set(long src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static long set(ref long src, int pos)
             => src = src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ulong set(ulong src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ulong set(ref ulong src, int pos)
             => src = src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static float set(float src, int pos)
        {
            var srcBits = BitConverter.SingleToInt32Bits(src);
            srcBits |= LeftMask(srcBits, pos);
            return BitConverter.Int32BitsToSingle(srcBits);            
        }
             

        [MethodImpl(Inline)]
        public static double set(double src, int pos)
        {
            var srcBits = BitConverter.DoubleToInt64Bits(src);
            srcBits |= LeftMask(srcBits, pos);
            return BitConverter.Int64BitsToDouble(srcBits);
            
        }

        #endregion

        #region unset


        [MethodImpl(Inline)]
        public static byte unset(byte src, int pos)
             => src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static byte unset(ref byte src, int pos)
             => src = src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static sbyte unset(sbyte src, int pos)
             => src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static sbyte unset(ref sbyte src, int pos)
             => src = src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static short unset(short src, int pos)
             => src.And(LeftMask(src,pos).Flip());
        [MethodImpl(Inline)]
        public static short unset(ref short src, int pos)
             => src = src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static ushort unset(ushort src, int pos)
             => src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static ushort unset(ref ushort src, int pos)
             => src = src.And(LeftMask(src,pos).Flip());

        [MethodImpl(Inline)]
        public static int unset(int src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static int unset(ref int src, int pos)
             => src = (src & ~ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static uint unset(uint src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static uint unset(ref uint src, int pos)
             => src = (src & ~ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static long unset(long src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static long unset(ref long src, int pos)
             => src = (src & ~ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static ulong unset(ulong src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ulong unset(ref ulong src, int pos)
             => src = (src & ~ LeftMask(src,pos));

        #endregion

        #region toggle

        [MethodImpl(Inline)]
        public static int toggle(int src, int pos)
             => src ^= LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static int toggle(ref int src, int pos)
             => src = (src ^ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static uint toggle(uint src, int pos)
             => src ^= LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static uint toggle(ref uint src, int pos)
             => src = (src ^ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static long toggle(long src, int pos)
             => src ^= LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static long toggle(ref long src, int pos)
             => src = (src ^ LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static ulong toggle(ulong src, int pos)
             => src ^= LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ulong toggle(ref ulong src, int pos)
             => src = (src ^ LeftMask(src,pos));

        #endregion

        #region bitchars

        [MethodImpl(Inline)]
        public static string bitstring(sbyte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(byte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(short src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(ushort src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(int src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(uint src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(long src)
            => zpad(Convert.ToString(src,2), 64);

        [MethodImpl(Inline)]
        public static string bitstring(ulong src)
        {
             (var x0, var x1) = split(src);
             return bitstring(x1) + bitstring(x0);
        }
            
        [MethodImpl(Inline)]
        public static string bitstring(float src)
            => bitstring(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static string bitstring(double src)
            => bitstring(bitsf(src));

        #endregion

        #region extraction


        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(ushort src)
            => (byte)src;

        /// <summary>
        /// Produces a byte by extracting bits [0 .. 7] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte lo(short src)
            => (sbyte)src;

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(short src)
            => (sbyte)(src >> 8);

        [MethodImpl(Inline)]
        public static short lo(int src)
            => (short)src;

        [MethodImpl(Inline)]
        public static short hi(int src)
            => (short)(src >> 16);

        [MethodImpl(Inline)]
        public static ushort lo(uint src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort hi(uint src)
            => (ushort)(src >> 16);

        [MethodImpl(Inline)]
        public static int hi(long src)
            => (int)(src >> 32);

        [MethodImpl(Inline)]
        public static int lo(long src)
            => (int)src;

        [MethodImpl(Inline)]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline)]
        public static uint lo(ulong src)
            => (uint)src;
                
        [MethodImpl(Inline)]
        public static byte[] bytes(short src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(ushort src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(int src)
            => BitConverter.GetBytes(src); 

        [MethodImpl(Inline)]
        public static byte[] bytes(uint src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(long src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(float src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(double src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Extract bits from a source interger at the corresponding bit 
        /// locations specified by mask to contiguous low bits in dst; the remaining 
        /// upper bits in dst are set to zero.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static uint extract(uint src, uint mask)        
            => Bmi2.ParallelBitExtract(src,mask);

        [MethodImpl(Inline)]
        public static uint extract(uint value, int start, int length)
            => Bmi1.BitFieldExtract(value,(byte)start,(byte)length);

        /// <summary>
        /// Extracts a run of bits from the source beginning at a specified offset
        /// </summary>
        /// <param name="value">The source value</param>
        /// <param name="offset">The offset value</param>
        /// <param name="length">The length of the run</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong extract(ulong value, int offset, int length)
            => Bmi1.X64.BitFieldExtract(value,(byte)offset,(byte)length);

        /// <summary>
        /// Extracts mask-identified bits from the source 
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong extract(ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitExtract(src,mask);


        #endregion

 
        [MethodImpl(Inline)]
        public static ulong rotate(ulong src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static uint rotate(uint src, int offset, bool left = false)            
            => left ? BitOperations.RotateLeft(src,offset) 
                    : BitOperations.RotateRight(src,offset);

        [MethodImpl(Inline)]
        public static ulong andnot(ulong lhs, ulong rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong msbOffCount(ulong src)
            => Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static ulong lsbOffCount(ulong src)
            => Bmi1.X64.TrailingZeroCount(src);

        /// <summary>
        /// Sets mask-identified bits in the soruce
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The extraction mask</param>
        [MethodImpl(Inline)]
        public static ulong deposit(ulong src, ulong mask)        
            => Bmi2.X64.ParallelBitDeposit(src,mask);

        [MethodImpl(Inline)]
        public static ulong leastOnBit(ulong src)
            => Bmi1.X64.ExtractLowestSetBit(src);

        /// <summary>
        /// Partitions the bits of a decimal as a sequence of four integers
        /// </summary>
        /// <param name="x0">The source bits [0 .. 31]</param>
        /// <param name="x1">The source bits [32 .. 63]</param>
        /// <param name="x2">The source bits [64 .. 97]</param>
        /// <param name="x3">The source bits [98 .. 127]</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1, int x2, int x3) split(decimal src)
            => apply(Decimal.GetBits(src), x => (x[0],x[1],x[2],x[3]));
    

        [MethodImpl(Inline)]
        public static uint andnot(uint lhs, uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint leastOnBit(uint src)
            => Bmi1.ExtractLowestSetBit(src);

        [MethodImpl(Inline)]
        public static uint popcount(uint src)
            => Popcnt.PopCount(src);

        [MethodImpl(Inline)]
        public static ulong popcount(ulong src)
            => Popcnt.X64.PopCount(src);

        [MethodImpl(Inline)]
        public static uint[] popcounts(uint min, uint max)
        {
            var current = min;
            var i = 0;
            var dst = new uint[max - min + 1];
            while(current <= max)
                dst[i++] = popcount(current++);
            return dst;
        }

        /// <summary>
        /// Counts the number of 0 bits prior to the first most significant 1 bit
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint msbOffCount(uint src)
            => Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        public static uint lsbOffCount(uint src)
            => Bmi1.TrailingZeroCount(src);

        [MethodImpl(Inline)]
        public static uint deposit(uint src, uint mask)        
            => Bmi2.ParallelBitDeposit(src,mask);


        [MethodImpl(Inline)]
        public static Bit[] bits(sbyte src)
        {
            var bitsize = SizeOf<sbyte>.BitSize;
            var dst = array<Bit>(bitsize);
            for(var i = 0; i < bitsize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static Bit[] bits(int src)
        {
            var dst = array<Bit>(SizeOf<int>.BitSize);
            for(var i = 0; i < SizeOf<int>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static Bit[] bits(float src)
            => bits(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static Bit[] bits(double src)
            => bits(bitsf(src));
 
        [MethodImpl(Inline)]
        public static Bit[] bits(long src)
        {
            var dst = array<Bit>(SizeOf<long>.BitSize);
            for(var i = 0; i < SizeOf<long>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
        

   
        [MethodImpl(Inline)]
        public static Bit[] bits(byte src)
        {
            var dst = array<Bit>(SizeOf<byte>.BitSize);
            for(var i = 0; i < SizeOf<byte>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static Bit[] bits(ushort src)
        {
            var dst = array<Bit>(SizeOf<ushort>.BitSize);
            for(var i = 0; i < SizeOf<ushort>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
    
 
        [MethodImpl(Inline)]
        public static int countTrailingOff(long src)
            => BitOperations.TrailingZeroCount(src);

        // /// <summary>
        // /// Counts the number of trailing zero bits in the source
        // /// </summary>
        // /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(sbyte src)
            => countTrailingOff((int)src);

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countLeadingOff(byte src)
            => countLeadingOff((ushort)src) - 8;

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(byte src)
            => countTrailingOff((uint)src);

        [MethodImpl(Inline)]
        public static int countLeadingOff(ushort src)
            => countLeadingOff((uint)src) - 16;

        [MethodImpl(Inline)]
        public static int countTrailingOff(ushort src)
            => countTrailingOff((uint)src);

        [MethodImpl(Inline)]
        public static Bit[] bits(uint src)
        {
            var dst = array<Bit>(SizeOf<uint>.BitSize);
            for(var i = 0; i < SizeOf<uint>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        /// <summary>
        /// Counts the number of leading zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countLeadingOff(uint src)
            => BitOperations.LeadingZeroCount(src);

        /// <summary>
        /// Counts the number of trailing zero bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int countTrailingOff(uint src)
            => BitOperations.TrailingZeroCount(src);


        [MethodImpl(Inline)]
        static uint parse(ref uint dst, string bitstring)
        {
            var max = Math.Min(32, bitstring.Length);            
            for(var i = 0; i< max; i++)
                if(bitstring[i] != '0')
                    set(ref dst,i);            
            return dst;                                                

        }

        [MethodImpl(Inline)]
        static ulong parse(ref ulong dst, string bitstring)
        {
            var max = Math.Min(64, bitstring.Length);            
            for(var i = 0; i< max; i++)
                if(bitstring[i] != '0')
                    set(ref dst,i);            
            return dst;                                                

        }

        public static T parse<T>(string bitstring)
            where T : struct, IEquatable<T>
        {
            var prim = PrimalKinds.kind<T>();
            switch(prim)
            {
                case PrimalKind.uint64:
                {
                    var dst = 0ul;
                    parse(ref dst, bitstring);
                    return As.generic<T>(dst);
                }

                case PrimalKind.uint32:
                {
                    var dst = 0u;
                    parse(ref dst, bitstring);
                    return As.generic<T>(dst);
                }
                default:
                    throw new Exception($"Kind {prim} not supported");
            }
        }

    }
}