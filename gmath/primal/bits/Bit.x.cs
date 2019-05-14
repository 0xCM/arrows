//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class  BitX
    {
        const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;
        
        #region primitive => Bit[]

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this sbyte src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this byte src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this short src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this ushort src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this int src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this uint src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this long src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this ulong src)
            => Bits.bits(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this float src)
            => Bits.bits(src);

        [MethodImpl(Inline)]
        public static int ToInt32Bits(this float src)
            => Bits.bitsI32(src);

        [MethodImpl(Inline)]
        public static long ToInt64Bits(this double src)
            => Bits.bitsI64(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this double src)
            => Bits.bits(src);

        /// <summary>
        /// Converts a bool to a bit
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static Bit ToBit(this bool src)
            => src;

       /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static IEnumerable<Bit> ToBits(this IEnumerable<bool> src)
            => map(src,x => x.ToBit()); 

        #endregion

        #region testbit

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this sbyte src, int pos)
            => Bits.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this byte src, int pos)
            => Bits.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ushort src, int pos)
            => Bits.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this short src, int pos)
            => Bits.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this int src, int pos)
            => Bits.test(src,pos);

       /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this uint src, int pos)
            => Bits.test(src,pos);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this long src, int pos)
            => Bits.test(src,pos);
 
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ulong src, int pos)
            => Bits.testbit(src,pos);

        #endregion

        # region primitive => byte[]

        /// <summary>
        /// Converts a bit to a byte
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static byte ToByte(this Bit src)
            => src ? (byte)1 : (byte)0;

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this long src)
            => Bits.bytes(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ushort src)
            => Bits.bytes(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => Bits.bytes(src);


        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this uint src)
            => Bits.bytes(src);

       /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this short src)
            => Bits.bytes(src);
 

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => Bits.bytes(src);  
 
        #endregion
        
        #region  primitive => bitvector

        [MethodImpl(Inline)]
        public static BitVectorU8 ToBitVector(this byte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI8 ToBitVector(this sbyte src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU16 ToBitVector(this ushort src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI32 ToBitVector(this int src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU32 ToBitVector(this uint src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorU64 ToBitVector(this ulong src)
            => src;

        [MethodImpl(Inline)]
        public static BitVectorI64 ToBitVector(this long src)
            => src;

        #endregion

        #region primitive => bitstring

        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this sbyte src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this byte src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this short src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this ushort src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this int src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this uint src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this long src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this ulong src)
            => Bits.bitstring(src);
            
        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this float src)
            => Bits.bitstring(src);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this double src)
            => Bits.bitstring(src);

        /// <summary>
        /// Extracts the IEEE parts from the source value
        /// </summary>
        /// <param name="sign">The value's sign</param>
        /// <param name="exponent">The value's exponent</param>
        /// <param name="mantissa">The value's mantissa</param>
        /// <remarks>Adapted from https://stackoverflow.com/questions/389993/extracting-mantissa-and-exponent-from-double-in-c-sharp</remarks>        
        static (Sign sign, int exponent, long mantissa)  split (double d)
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

        /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => zpad(apply(split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            Bits.bitstring(ieee.exponent),
                            Bits.bitstring(ieee.mantissa)
                    )), sizeof(double)); 
 

        #endregion
    
        #region ? => bitstring

        public static string ToBitString<T>(this num<T> src)
            where T : struct, IEquatable<T>
                => Bits.bitstring(src);
                
        #endregion

        public static BitVectorU8 ToBitVector(this BitPattern src)
            => (byte)src;

    }
}