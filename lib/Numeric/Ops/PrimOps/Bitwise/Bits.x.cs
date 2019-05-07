//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;
    using static zfunc;

    using target = System.Double;
    using targets = Index<double>;


    public static class MoreBits
    {
        /// <summary>
        /// Parses the bits from a string representation of a bitstring
        /// </summary>
        /// <param name="src">The representation to parse</param>
        /// <typeparam name="N">The natural length type</typeparam>
        [MethodImpl(Inline)]
        public static Slice<N,bit> parse<N>(string src)
            where N : ITypeNat, new()
        {
            Prove.claim<N>(src.Length);
            var digits = new bit[src.Length];
            for(var i = 0; i< digits.Length; i++)
                digits[i] = src[i] == '0' ? BinaryDigit.B0 : BinaryDigit.B0;        
            return digits;
        }

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


    }

    partial class BitwiseX
    {
        /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => zpad(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            primops.bitstring(ieee.exponent).format(),
                            primops.bitstring(ieee.mantissa).format()
                    )), sizeof(double)); 

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static sbyte And(this sbyte lhs, sbyte rhs)
            => (sbyte)(lhs & rhs);
            
        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static sbyte Or(this sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static sbyte XOr(this sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        /// <summary>
        /// Computes a correctly-typed left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static sbyte LShift(this sbyte src, int shift)
            => (sbyte)(src << shift);

        /// <summary>
        /// Computes a correctly-typed right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static sbyte RShift(this sbyte src, int shift)
            => (sbyte)(src >> shift);

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte Flip(this sbyte src)
            => (sbyte)(~src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this sbyte src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this sbyte src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this sbyte src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this sbyte src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this sbyte src)
            => Bits.bytes(src);
 
        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static short And(this short lhs, short rhs)
            => (short)(lhs & rhs);            

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static short Or(this short lhs, short rhs)
            => (short)(lhs | rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static short XOr(this short lhs, short rhs)
            => (short)(lhs ^ rhs);

        /// <summary>
        /// Computes a correctly-typed left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static short LShift(this short src, int shift)
            => (short)(src << shift);

        /// <summary>
        /// Computes a correctly-typed right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static short RShift(this short src, int shift)
            => (short)(src >> shift);

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short Flip(this short src)
            => (short)(~src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this short src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this short src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this short src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this short src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this short src)
            => Bits.bytes(src);
 
        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this int src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this int src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a BitString
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this int src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this int src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => Bits.bytes(src);  
     }
}