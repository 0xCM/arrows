//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    
    using static zfunc;    
    


    partial class MathX
    {
        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref sbyte XOr(this ref sbyte lhs, sbyte rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref byte XOr(this ref byte lhs, byte rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ushort XOr(this ref ushort lhs, ushort rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref short XOr(this ref short lhs, short rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref int XOr(this ref int lhs, int rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref uint XOr(this ref uint lhs, uint rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref long XOr(this ref long lhs, long rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ulong XOr(this ref ulong lhs, ulong rhs)
        {
            lhs ^= rhs;
            return ref lhs;
        }
 
        [MethodImpl(Inline)]
        public static Span<byte> XOr(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.xor(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> XOr(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.xor(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> XOr(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.xor(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> XOr(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.xor(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> XOr(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.xor(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> XOr(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.xor(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> XOr(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.xor(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> XOr(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.xor(lhs, rhs, span<ulong>(length(lhs,rhs)));
 
     }

}