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
    


    partial class mathx
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
     }

}