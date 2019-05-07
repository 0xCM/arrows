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
    using static BitPackBytes;

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

    public static class Bits
    {                

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


        /// <summary>
        /// Extracts the IEEE parts from the source value
        /// </summary>
        /// <param name="sign">The value's sign</param>
        /// <param name="exponent">The value's exponent</param>
        /// <param name="mantissa">The value's mantissa</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/389993/extracting-mantissa-and-exponent-from-double-in-c-sharp</remarks>        
        public static (Sign sign, int exponent, long mantissa)  split (double d)
        {                    
            // Translate the double into sign, exponent and mantissa.
            long bits = BitConverter.DoubleToInt64Bits(d);
            // Note that the shift is sign-extended, hence the test against -1 not 1
            bool negative = (bits & (1L << 63)) != 0;
            int exponent = (int) ((bits >> 52) & 0x7ffL);
            long mantissa = bits & 0xfffffffffffffL;

            // Subnormal numbers; exponent is effectively one higher,
            // but there's no extra normalisation bit in the mantissa
            if (exponent==0)
                exponent++;
            // Normal numbers; leave exponent as it is but add extra
            // bit to the front of the mantissa
            else
                mantissa = mantissa | (1L << 52);

            // Bias the exponent. It's actually biased by 1023, but we're
            // treating the mantissa as m.0 rather than 0.m, so we need
            // to subtract another 52 from it.
            exponent -= 1075;

            if (mantissa == 0) 
                return negative ? (Sign.Negative,0,0) : (Sign.Positive, 0,0);

            /* Normalize */
            while((mantissa & 1) == 0) 
            {    /*  i.e., Mantissa is even */
                mantissa >>= 1;
                exponent++;
            }

            return (negative ? Sign.Negative : Sign.Positive, exponent,mantissa);
        }

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

        [MethodImpl(Inline)]
        public static ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
            => pack(pack(x0,x1), pack(x2,x3));

        #endregion

        #region split

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
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) split(ushort src)
            => (lo(src), hi(src));

        /// <summary>
        /// Splits a short into two bytes
        /// </summary>
        /// <param name="x0">The source bits [0 .. 7]</param>
        /// <param name="x1">The source bits [8 .. 15]</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) split(short src)
            => (lo(src),hi(src));

        /// <summary>
        /// long => (int,int)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1) split(long src)
            => (lo32(src), hi32(src));

        /// <summary>
        /// ulong => (uint,uint)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        [MethodImpl(Inline)]
        public static (uint x0, uint x1) split(ulong src)
            => (lo(src), hi(src));

        #endregion

        #region testbit

        [MethodImpl(Inline)]
        public static bool testbit(sbyte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool testbit(byte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool testbit(short src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool testbit(ushort src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool testbit(int src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool testbit(uint src, int pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool testbit(long src, int pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool testbit(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool testbit(double src, int pos)
            => testbit(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool testbit(float src, int pos)
            => testbit(BitConverter.SingleToInt32Bits(src),pos);

        #endregion

        /// <summary>
        /// Constructs a bit from source at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        [MethodImpl(Inline)]   
        public static bit bitat(int src, int pos)
                => testbit(src, pos);

        /// <summary>
        /// Produces a byte by extracting bits [0 .. 7] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(short src)
            => (byte)src;

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(short src)
            => (byte)(src >> 8);

        /// <summary>
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static short hi(int src)
            => (short)(src >> 16);

        /// <summary>
        /// int => (., short)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static short lo(int src)
            => (short)src;

        /// <summary>
        /// Extracts the least order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k1
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo8(int src)
            => lo(lo(src));

        /// <summary>
        /// Extracts the third order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k3
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hilo(int src)
            => lo(hi(src));

        /// <summary>
        /// Extracts the second order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k2
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lohi(int src)
            => hi(lo(src));

        /// <summary>
        /// Extracts the highest order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k4
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi8(int src)
            => hi(hi(src));



        /// <summary>
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int hi32(long src)
            => (int)(src >> 32);

        /// <summary>
        /// int => (., short)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static int lo32(long src)
            => (int)src;
 
        /// <summary>
        /// Extracts the high-order bits from a ulong to produce a uint
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static uint hi(ulong src)
            => (uint)(src >> 32);

        /// <summary>
        /// Extracts the low-order bits from a ulong to produce a uint
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint lo(ulong src)
            => (uint)src;
                
 
        [MethodImpl(Inline)]
        public static ulong rotate(ulong src, int offset, bool left = false)            
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
    
            /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
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
        /// Extracts the upper half of the bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort hi(uint src)
            => (ushort)(src >> 16);

        /// <summary>
        /// Extracts the most significant byte from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi8(uint src)
            => hi(hi(src));


        /// <summary>
        /// Extracts the lower half of the bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort lo(uint src)
            => (ushort)src;

        /// <summary>
        /// Extracts the least significant byte from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo8(uint src)
            => lo(lo(src));

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
        public static (ushort hi, ushort lo) unpack(uint src)
            => (hi(src),lo(src));

 
        [MethodImpl(Inline)]
        public static uint andnot(uint lhs, uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint leastOnBit(uint src)
            => Bmi1.ExtractLowestSetBit(src);

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

        [MethodImpl(Inline)]
        public static string bitchars(sbyte src)
            => zpad(Convert.ToString(src,2), sizeof(byte));

        [MethodImpl(Inline)]   
        public static BitString bitstring(sbyte src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

        [MethodImpl(Inline)]
        public static string bitchars32(int src)
            => zpad(Convert.ToString(src,2), sizeof(int));

        [MethodImpl(Inline)]
        public static string bitchars(int src)
            => bitchars32(src);

        [MethodImpl(Inline)]   
        public static BitString bitstring(int src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));


        [MethodImpl(Inline)]
        public static string bitchars(float src)
            => bitchars(BitConverter.SingleToInt32Bits(src));
        
        [MethodImpl(Inline)]   
        public static BitString bitstring(float src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

        [MethodImpl(Inline)]
        public static string bitchars(double src)
            => bitchars(bitsf(src));

        [MethodImpl(Inline)]   
        public static BitString bitstring(double src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

        [MethodImpl(Inline)]
        public static string bitchars(long src)
            => zpad(Convert.ToString(src,2), sizeof(long));

        [MethodImpl(Inline)]   
        public static BitString bitstring(long src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

        [MethodImpl(Inline)]
        public static byte[] bytes(sbyte src)
            => array((byte)src);



        [MethodImpl(Inline)]
        public static bit[] bits(sbyte src)
        {
            var bitsize = SizeOf<sbyte>.BitSize;
            var dst = array<bit>(bitsize);
            for(var i = 0; i < bitsize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static byte[] bytes(int src)
            => BitConverter.GetBytes(src); 


        [MethodImpl(Inline)]
        public static bit[] bits(int src)
        {
            var dst = array<bit>(SizeOf<int>.BitSize);
            for(var i = 0; i < SizeOf<int>.BitSize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static byte[] bytes(float src)
            => BitConverter.GetBytes(src);


        [MethodImpl(Inline)]
        public static bit[] bits(float src)
            => bits(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static byte[] bytes(double src)
            => BitConverter.GetBytes(src);


        [MethodImpl(Inline)]
        public static bit[] bits(double src)
            => bits(bitsf(src));
 

        [MethodImpl(Inline)]
        public static byte[] bytes(long src)
            => BitConverter.GetBytes(src);


        [MethodImpl(Inline)]
        public static bit[] bits(long src)
        {
            var dst = array<bit>(SizeOf<long>.BitSize);
            for(var i = 0; i < SizeOf<long>.BitSize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }
        

        /// <summary>
        /// Renders a number as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string bitchars(byte src)
            => zpad(Convert.ToString(src,2), sizeof(byte));

        [MethodImpl(Inline)]   
        public static BitString bitstring(byte src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

   
        [MethodImpl(Inline)]
        public static bit[] bits(byte src)
        {
            var dst = array<bit>(SizeOf<byte>.BitSize);
            for(var i = 0; i < SizeOf<byte>.BitSize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(byte src)
            => new byte[]{src};

    
        [MethodImpl(Inline)]
        public static string bitchars(ushort src)
            => zpad(Convert.ToString(src,2), sizeof(ushort)*8);

        [MethodImpl(Inline)]   
        public static BitString bitstring(ushort src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));


        [MethodImpl(Inline)]
        public static bit[] bits(ushort src)
        {
            var dst = array<bit>(SizeOf<ushort>.BitSize);
            for(var i = 0; i < SizeOf<ushort>.BitSize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }
        
        [MethodImpl(Inline)]
        public static byte[] bytes(ushort src)
            => BitConverter.GetBytes(src);

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
        static string bitcharsu32(uint src)
            => zpad(Convert.ToString(src,2), sizeof(uint));

        [MethodImpl(Inline)]
        public static string bitchars(uint src)
            => bitcharsu32(src);

        [MethodImpl(Inline)]   
        public static BitString bitstring(uint src) 
            => BitString.define(Z0.bit.Parse(bitchars(src)));

        [MethodImpl(Inline)]
        public static byte[] bytes(uint src)
            => BitConverter.GetBytes(src);

 
        [MethodImpl(Inline)]
        public static bit[] bits(uint src)
        {
            var dst = array<bit>(SizeOf<uint>.BitSize);
            for(var i = 0; i < SizeOf<uint>.BitSize; i++)
                dst[i] = testbit(src,i);
            return dst; 
        }

        /// <summary>
        /// Rotates the source bits leftward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static uint lrot(uint src, int offset)            
            => BitOperations.RotateLeft(src,offset);

        /// <summary>
        /// Rotates the source bits rightward
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The rotation magnitude</param>
        [MethodImpl(Inline)]
        public static uint rrot(uint src, int offset)            
            => BitOperations.RotateLeft(src,offset);

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
    }

}