//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zcore;

    public static class Bits
    {
        /// <summary>
        /// Tests whether the bit in an specific position is set
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <param name="pos">The bit position to test</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        /// <returns>Returns true if the identified bit is set, false otherwise</returns>
        [MethodImpl(Inline)]
        public static bool test<T>(intg<T> src, int pos)            
            => (src & (intg<T>.One << pos)) != intg<T>.Zero;


        /// <summary>
        /// Determines the binary digit in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryDigit digit<T>(intg<T> src, int pos)
            => test(src,pos) switch 
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
            => new bit(test(src,pos));

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
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static byte lo(ushort src)
            => (byte)src;

        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static sbyte hi(short src)
            => (sbyte)(src >> 8);

        /// <summary>
        /// Extracts the low-order bits from a ushort to produce a byte
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static sbyte lo(short src)
            => (sbyte)src;

        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
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
        /// int => (short, .)
        /// </summary>
        /// <param name="src">The source value</param>
        /// <returns></returns>
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
            => concat(concat(x1,x2), concat(x3,x4));

        /// <summary>
        /// (byte,byte,byte,byte,byte,byte,byte,byte) => ulong
        /// </summary>
        /// <param name="hi">The high-order bits</param>
        /// <param name="lo">The low-order bits</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong concat(byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte x8)
            => concat(concat(concat(x1,x2), concat(x3,x4)),
                concat(concat(x4,x5), concat(x6,x7)));

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
        public static (sbyte hi, sbyte lo) split(short src)
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

        public static (int hihi, int hilo, int lohi, int lolo) split(decimal src)
            => apply(Decimal.GetBits(src), x => (x[3],x[2],x[1],x[0]));

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