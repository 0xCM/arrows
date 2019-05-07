//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    using ulongs = Index<ulong>;

    partial class BitwiseX
    {
        /// <summary>
        /// Computes a bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ulong And(this ulong lhs, ulong rhs)
            => lhs & rhs;            

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong Or(this ulong lhs, ulong rhs)
            => (ulong)(lhs | rhs);

        /// <summary>
        /// Computes a bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong XOr(this ulong lhs, ulong rhs)
            => lhs ^ rhs;

        /// <summary>
        /// Computes a left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static ulong LShift(this ulong src, int shift)
            => src << shift;

        /// <summary>
        /// Computes a right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static ulong RShift(this ulong src, int shift)
            => src >> shift;

        /// <summary>
        /// Computes a two's-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong Flip(this ulong src)
            => ~src;

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this ulong src, int pos)
            => Ops.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this ulong src)
            => Ops.bitchars(src);

        /// <summary>
        /// Converts the source value to a BitString
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this ulong src) 
            => Ops.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this ulong src)
            => Ops.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => Ops.bytes(src);
    }
}