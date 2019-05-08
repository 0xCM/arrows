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

    public static class  BitX
    {
        /// <summary>
        /// Converts a bool to a bit
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static Bit ToBit(this bool src)
            => src;

        /// <summary>
        /// Converts a bit to a bool
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static Bit ToBool(this Bit src)
            => src;

        

        /// <summary>
        /// Converts a bit to a byte
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static byte ToByte(this Bit src)
            => src ? (byte)1 : (byte)0;

       /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        [MethodImpl(Inline)]   
        public static IEnumerable<Bit> ToBits(this IEnumerable<bool> src)
            => map(src,x => x.ToBit()); 
 
         /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this long src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this long src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a BitString
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this long src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this long src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this long src)
            => Bits.bytes(src);
 
 
         /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this byte src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string BitChars(this byte src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString BitString(this byte src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this byte src)
            => Bits.bits(src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ushort src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string BitChars(this ushort src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString BitString(this ushort src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this ushort src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ushort src)
            => Bits.bytes(src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ulong src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this ulong src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a BitString
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ulong src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this ulong src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => Bits.bytes(src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this uint src, int pos)
            => Bits.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this uint src)
            => Bits.bitchars(src);

        /// <summary>
        /// Converts the source value to a BitString
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this uint src) 
            => Bits.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Bit[] ToBits(this uint src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this uint src)
            => Bits.bytes(src);
 
         /// <summary>
        /// Constructs an IEE bitstring from a double
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]   
        public static string ToIeeeBitString(this double x)
            => zpad(apply(Bits.split(x), 
                ieee => append(ieee.sign == Sign.Negative ? "1" : "0",
                            Bits.bitstring(ieee.exponent).format(),
                            Bits.bitstring(ieee.mantissa).format()
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
        public static Bit[] ToBits(this sbyte src)
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
        public static Bit[] ToBits(this short src)
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
        public static Bit[] ToBits(this int src)
            => Bits.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => Bits.bytes(src);  
 
 
         /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static byte And(this byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static byte Or(this byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static byte XOr(this byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        /// <summary>
        /// Computes a correctly-typed left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static byte LShift(this byte src, int shift)
            => (byte)(src << shift);

        /// <summary>
        /// Computes a correctly-typed right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static byte RShift(this byte src, int shift)
            => (byte)(src >> shift);

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte Flip(this byte src)
            => (byte)(~src);


        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ushort And(this ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);            

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort Or(this ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort XOr(this ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        /// <summary>
        /// Computes a correctly-typed left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static ushort LShift(this ushort src, int shift)
            => (ushort)(src << shift);

        /// <summary>
        /// Computes a correctly-typed right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static ushort RShift(this ushort src, int shift)
            => (ushort)(src >> shift);

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort Flip(this ushort src)
            => (ushort)(~src);

    }
}