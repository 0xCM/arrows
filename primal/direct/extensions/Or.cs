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
        public static ref sbyte Or(this ref sbyte lhs, sbyte rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref byte Or(this ref byte lhs, byte rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ushort Or(this ref ushort lhs, ushort rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref short Or(this ref short lhs, short rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref int Or(this ref int lhs, int rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref uint Or(this ref uint lhs, uint rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref long Or(this ref long lhs, long rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>

        [MethodImpl(Inline)]
        public static ref ulong Or(this ref ulong lhs, ulong rhs)
        {
            lhs |= rhs;
            return ref lhs;
        }
 
        [MethodImpl(Inline)]
        public static Span<byte> Or(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.or(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> Or(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.or(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> Or(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.or(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> Or(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.or(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> Or(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.or(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> Or(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.or(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> Or(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.or(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> Or(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.or(lhs, rhs, span<ulong>(length(lhs,rhs)));
 
   }

}