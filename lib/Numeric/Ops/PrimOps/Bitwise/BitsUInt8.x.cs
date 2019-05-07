//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    using static zcore;
    using static zfunc;

    using bytes = Index<byte>;

    partial class BitwiseX
    {

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static byte And(this byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        /// <summary>
        /// Computes and returns the bitwise and of corresponding operand entries
        /// </summary>
        /// <param name="lhs">The first list of values</param>
        /// <param name="rhs">The second list of values</param>
        [MethodImpl(Inline)]
        public static bytes And(this bytes lhs, bytes rhs)
        {
            var count = countmatch(lhs,rhs);
            var dst = alloc<byte>(lhs.Count);
            iter(count, i => dst[i] = lhs[i].And(rhs[i]));
            return dst;
        }

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
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this byte src, int pos)
            => Ops.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string BitChars(this byte src)
            => Ops.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString BitString(this byte src) 
            => Ops.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this byte src)
            => Ops.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this byte src)
            => Ops.bytes(src);
    }

}