//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zcore;

    /// <summary>
    /// Interesting approach!
    /// </summary>
    /// <remarks>See https://stackoverflow.com/questions/5419453/getting-upper-and-lower-byte-of-an-integer-in-c-sharp-and-putting-it-as-a-char-a</remarks>
    [StructLayout(LayoutKind.Explicit )]
    public struct UInt32Bytes 
    {
        [FieldOffset(0)]
        public uint value;
        
        [FieldOffset(0)]
        public readonly byte lolo;
        
        [FieldOffset(1)]
        public readonly byte lohi;
        
        [FieldOffset(2)]
        public readonly byte hilo;
        
        [FieldOffset(3)]
        public readonly byte hihi;
    }

    public static class Bits
    {

        /// <summary>
        /// Parses the bits from a string representation of a bitstring
        /// </summary>
        /// <param name="src">The representation to parse</param>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,bit> parse<N>(string src)
            where N : TypeNat, new()
        {
            Prove.claim<N>(src.Length);
            var digits = new bit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            return digits;
        }


        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public static bool xtest<T>(intg<T> src, int pos)            
            => (src & (intg<T>.One << pos)) != intg<T>.Zero;


        [MethodImpl(Inline)]
        public static bool test(byte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(sbyte src, int pos)
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
        public static bool test(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;

        /// <summary>
        /// Determines the binary digit in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryDigit digit<T>(intg<T> src, int pos)
            => src.testbit(pos) switch 
                {
                    true => BinaryDigit.B0,
                    false => BinaryDigit.B1
                };

        /// <summary>
        /// Constructs a bit from the data in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static bit bit<T>(intg<T> src, int pos)
            => new bit(src.testbit(pos));

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
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static byte hi(short src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static byte lo(short src)
            => (byte)src;


        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort hi(uint src)
            => (ushort)(src >> 16);

        /// <summary>
        /// Extracts the low-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ushort lo(uint src)
            => (ushort)src;


        /// <summary>
        /// Extracts the highest-order byte from the source, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k4
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hihi(uint src)
            => hi(hi(src));

        /// <summary>
        /// Extracts the third order byte from a 32-bit integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k3
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hilo(uint src)
            => lo(hi(src));

        /// <summary>
        /// Extracts the second order byte from a 32-bit integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k2
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lohi(uint src)
            => hi(lo(src));

        /// <summary>
        /// Extracts the least order byte from a 32-bit integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k1
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lolo(uint src)
            => lo(lo(src));

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
        /// Extracts the highest order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k4
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hihi(int src)
            => hi(hi(src));

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
        /// Extracts the least order byte from a 32-bit signed integer, i.e.,
        /// For a 32-bit integer k comprised of a sequence of bytes (k4)(k3)(k2)(k1),
        /// yeilds k1
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lolo(int src)
            => lo(lo(src));


        /// <summary>
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int hi(long src)
            => (int)(src >> 32);

        /// <summary>
        /// int => (., short)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static int lo(long src)
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
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static uint lo(ulong src)
            => (uint)src;

        /// <summary>
        /// Constructs a short value from two signed byte values
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static short concat(sbyte hi, sbyte lo)
            => (short)((int)hi << 8 | (int)(byte)(lo));

        /// <summary>
        /// (uint,uint) => ulong
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ushort concat(byte hi, byte lo)
            => (ushort) ((ushort)hi << 8 | (ushort)lo);


        /// <summary>
        /// Constructs a int value from two short values
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static int concat(short hi, short lo)
            => (int)hi << 16 | (int)(ushort)lo;

        /// <summary>
        /// (ushort,ushort) => uint
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static uint concat(ushort hi, ushort lo)
            => (uint)hi << 16 | (uint)lo;

        /// <summary>
        /// Constructs a long value from two int values
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static long concat(int hi, int lo)
            => (long)hi << 32 | (long)(uint)lo;

        /// <summary>
        /// (uint,uint) => ulong
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong concat(uint hi, uint lo)
            => (ulong)hi << 32 | (ulong)lo;

        /// <summary>
        /// (byte,byte,byte,byte) => uint
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static uint concat(byte x1, byte x2, byte x3, byte x4)
            => BitConverter.ToUInt32(array(x1,x2,x3,x4));

        /// <summary>
        /// (byte,byte,byte,byte,byte,byte,byte,byte) => ulong
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong concat(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8)
            => BitConverter.ToUInt64(array(x1,x2,x3,x4,x5,x6,x7,x8));

        /// <summary>
        /// (short,short,short,short) => long
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static long concat(short x1, short x2, short x3, short x4)
            => concat(concat(x1,x2), concat(x3,x4));

        /// <summary>
        /// (ushort,ushort,ushort,ushort) => ulong
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong concat(ushort x1, ushort x2, ushort x3, ushort x4)
            => concat(concat(x1,x2), concat(x3,x4));

        /// <summary>
        /// ushort => (byte,byte)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (byte hi, byte lo) split(short src)
            => (hi(src),lo(src));

        /// <summary>
        /// ushort => (byte,byte)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (byte hi, byte lo) split(ushort src)
            => (hi(src),lo(src));


        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (short hi, short lo) split(int src)
            => (hi(src),lo(src));

        /// <summary>
        /// uint => (ushort,ushort)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (ushort hi, ushort lo) split(uint src)
            => (hi(src),lo(src));


       /// <summary>
        /// long => (int,int)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (int hi, int lo) split(long src)
            => (hi(src),lo(src));

        /// <summary>
        /// ulong => (uint,uint)
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (uint hi, uint lo) split(ulong src)
            => (hi(src),lo(src));

        /// <summary>
        /// Partitions the bits of a decimal as a sequence of four integers
        /// </summary>
        /// <param name="hihi">The hi bits of the hi half</param>
        /// <param name="hilo">The lo bits of the hi half</param>
        /// <param name="lohi">The hi bits of the lo half</param>
        /// <param name="lolo">The lo bits of the lo half</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static (int hihi, int hilo, int lohi, int lolo) split(decimal src)
            => apply(Decimal.GetBits(src), x => (x[3],x[2],x[1],x[0]));

       /// <summary>
       /// Interprets the source as an array of bytes
       /// </summary>
       /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(byte src)
            => array(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(sbyte src)
            => array((byte)src);

        /// <summary>
        /// Extracts the data contained in the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(short src)
            => array(hi(src),lo(src));

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(ushort src)
            => array(hi(src),lo(src));

        /// <summary>
        /// Extracts the data contained in the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(int src)
            => array(hihi(src),hilo(src),lohi(src),lolo(src));

        /// <summary>
        /// Extracts the data contained in the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(uint src)
            => array(hihi(src),hilo(src),lohi(src),lolo(src));


        /// <summary>
        /// Extracts the data contained in the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(long src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Extracts the data contained in the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(ulong src)
            => BitConverter.GetBytes(src);

       /// <summary>
       /// Interprets the source as an array of bytes
       /// </summary>
       /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(decimal src)
            => zcore.concat(map(Decimal.GetBits(src), bytes));

       /// <summary>
       /// Interprets the source as an array of bytes
       /// </summary>
       /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(float src)
            => BitConverter.GetBytes(src);

       /// <summary>
       /// Interprets the source as an array of bytes
       /// </summary>
       /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte[] bytes(double src)
            => BitConverter.GetBytes(src);

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


     }
}