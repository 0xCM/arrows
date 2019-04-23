//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    using target = System.SByte;
    using targets = Index<sbyte>;



    partial class BitwiseX
    {

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static target And(this target lhs, target rhs)
            => (target)(lhs & rhs);
            
        /// <summary>
        /// Computes and returns the bitwise and of corresponding operand entries
        /// </summary>
        /// <param name="lhs">The first list of values</param>
        /// <param name="rhs">The second list of values</param>
        [MethodImpl(Inline)]
        public static targets And(this targets lhs, targets rhs)
            => Ops.and(lhs,rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static target Or(this target lhs, target rhs)
            => (target)(lhs | rhs);

        /// <summary>
        /// Computes a correctly-typed bitwise xor of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static target XOr(this target lhs, target rhs)
            => (target)(lhs ^ rhs);

        /// <summary>
        /// Computes a correctly-typed left shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static target LShift(this target src, int shift)
            => (target)(src << shift);

        /// <summary>
        /// Computes a correctly-typed right shift of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="shift">The magnitude of the shift</param>
        [MethodImpl(Inline)]
        public static target RShift(this target src, int shift)
            => (target)(src >> shift);

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static target Flip(this target src)
            => (target)(~src);

        /// <summary>
        /// Determines whether a bit in a specified position is on
        /// </summary>
        /// <param name="src">The value to examine</param>
        /// <param name="pos">The position to check</param>
        [MethodImpl(Inline)]
        public static bool TestBit(this target src, int pos)
            => Ops.testbit(src,pos);

        /// <summary>
        /// Renders a value as a base-2 formatted string
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static string ToBitChars(this target src)
            => Ops.bitchars(src);

        /// <summary>
        /// Converts the source value to a sequence of bits
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this target src) 
            => Ops.bitstring(src);

        /// <summary>
        /// Converts the source value to an array of bits
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bit[] ToBits(this target src)
            => Ops.bits(src);

        /// <summary>
        /// Interprets the source as an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this target src)
            => Ops.bytes(src);
    }

}