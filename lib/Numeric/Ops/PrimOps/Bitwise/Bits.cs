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

    using static zcore;

    public static partial class Bits
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
        /// Determines the binary digit in an integral value at a specified position
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The underlying integral type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryDigit digit<T>(intg<T> src, int pos)
            where T : struct, IEquatable<T>
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
            where T : struct, IEquatable<T>
                => new bit(src.testbit(pos));

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