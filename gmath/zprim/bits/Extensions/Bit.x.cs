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
    using static mfunc;
    using static Bits;

    public static partial class BitX
    {
        
        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in sbyte src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in byte src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in short src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in ushort src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in int src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in uint src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in long src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in ulong src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in float src)
            => bitspan(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this in double src)
            => bitspan(src);

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
        public static Span<Bit> ToBits(this ReadOnlySpan<bool> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i < src.Length; i++)
                dst[i] = src[i];
            return dst;
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
 
        [MethodImpl(Inline)]
        public static BitVector<N> ToBitVector<N>(this Span<Bit> src)
            where N : INatPow2, new()
                => BitVector.Define<N>(src);

        [MethodImpl(Inline)]
        public static Bit ToBit(this BinaryDigit digit)
            => digit == BinaryDigit.One;

        [MethodImpl(Optimize)]
        public static Span<Bit> ToBits(this ReadOnlySpan<BinaryDigit> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i].ToBit();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this Span<BinaryDigit> src)
            => src.ToBits().ToBytes();

        [MethodImpl(Inline)]
        public static Span<byte> ToBytes(this ReadOnlySpan<BinaryDigit> src)
            => src.ToBits().ToBytes();

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<BinaryDigit> src)
            => src.ToReadOnlySpan().ToBits();
                
        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this ReadOnlySpan<char> src)
        {
            var dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<char> src)
            => src.ToReadOnlySpan().ToBits();

        [MethodImpl(Optimize)]
        public static ref Span<byte> FromBits(this ReadOnlySpan<Bit> src, out Span<byte> dst)
        {
            dst = span<byte>(src.Length/8);
            for(var i=0; i<src.Length; i++)
            for(var j=0; j < 8; j++)
               if(src[i]) enable(ref dst[i], j);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<byte> FromBits(this Span<Bit> src, out Span<byte> dst)
            => ref src.ToReadOnlySpan().FromBits(out dst);

        [MethodImpl(Inline)]
        public static ref Span<byte> FromDigits(this Span<BinaryDigit> src, out Span<byte> dst)
            => ref src.ToBits().FromBits(out dst);

        [MethodImpl(Inline)]
        public static ref Span<byte> FromDigits(this ReadOnlySpan<BinaryDigit> src, out Span<byte> dst)
            => ref src.ToBits().FromBits(out dst);

        [MethodImpl(Optimize)]        
        public static Span<Bit> ToBits(this ReadOnlySpan<byte> src)
        {
            var dst = span<Bit>(src.Length*8);
            var offset = 0;
            for(var i = 0; i<src.Length; i++, offset += 8)
                src[i].ToBits().CopyTo(dst.Slice(offset));
            return dst;
        }

        [MethodImpl(Inline)]        
        public static Span<Bit> ToBits(this Span<byte> src)
            => src.ToReadOnlySpan().ToBits();


        [MethodImpl(Optimize)]        
        public static ulong PopCount(this ReadOnlySpan<Bit> src)
        {
            var count = 0ul;
            for(var i=0; i<src.Length; i++)
                if(src[i]) count++;
            return count;
        }

        [MethodImpl(Inline)]        
        public static ulong PopCount(this Span<Bit> src)
            => src.ToReadOnlySpan().PopCount();
    }
}