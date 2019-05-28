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
    using static Bits;

    public static class BitStringX
    {
        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in sbyte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in byte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in short src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in ushort src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in int src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in uint src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in long src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in ulong src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);



        [MethodImpl(Inline)]        
        public static string ToBitString(this Span<byte> src)
        {
            var dst = span<char>(src.Length);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = src[i] == 1 ? '1' : '0';
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static ref Span<byte> BitStringBytes(this ReadOnlySpan<char> src, out Span<byte> dst)
        {
            dst = span<byte>(src.Length/8);
            for(var i=0; i<src.Length; i++)
            for(var j=0; j < 8; j++)
               if(src[i] == Bit.One) enable(ref dst[i], j);
            return ref dst;
        }
 
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

        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => zpad(apply(split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            bitstring(ieee.exponent),
                            gbits.bitstring(ieee.mantissa)
                    )), sizeof(double)); 
 
 
    }
}