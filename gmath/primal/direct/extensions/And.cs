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

    
    using static mfunc;


    partial class mathx
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

    }

}