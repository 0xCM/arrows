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
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref sbyte And(this ref sbyte lhs, sbyte rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref byte And(this ref byte lhs, byte rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ushort And(this ref ushort lhs, ushort rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a correctly-typed bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref short And(this ref short lhs, short rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref int And(this ref int lhs, int rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref uint And(this ref uint lhs, uint rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref long And(this ref long lhs, long rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        /// <summary>
        /// Computes a bitwise and of the operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ref ulong And(this ref ulong lhs, ulong rhs)
        {
            lhs &= rhs;
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<byte> And(this ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.and(lhs, rhs, span<byte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<sbyte> And(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.and(lhs, rhs, span<sbyte>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<short> And(this ReadOnlySpan<short> lhs, ReadOnlySpan<short> rhs)
            => math.and(lhs, rhs, span<short>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ushort> And(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.and(lhs, rhs, span<ushort>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<int> And(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs)
            => math.and(lhs, rhs, span<int>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<uint> And(this ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.and(lhs, rhs, span<uint>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<long> And(this ReadOnlySpan<long> lhs, ReadOnlySpan<long> rhs)
            => math.and(lhs, rhs, span<long>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<ulong> And(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.and(lhs, rhs, span<ulong>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<byte> And(this ref Span<byte> lhs, ReadOnlySpan<byte> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<sbyte> And(this ref Span<sbyte> lhs, ReadOnlySpan<sbyte> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<short> And(this ref Span<short> lhs, ReadOnlySpan<short> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ushort> And(this ref Span<ushort> lhs, ReadOnlySpan<ushort> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<int> And(this ref Span<int> lhs, ReadOnlySpan<int> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<uint> And(this ref Span<uint> lhs, ReadOnlySpan<uint> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<long> And(this ref Span<long> lhs, ReadOnlySpan<long> rhs)
            => math.and(lhs, rhs);

        [MethodImpl(Inline)]
        public static Span<ulong> And(this ref Span<ulong> lhs, ReadOnlySpan<ulong> rhs)
            => math.and(lhs, rhs);
    }
}