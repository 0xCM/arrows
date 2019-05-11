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
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte Flip(this ref sbyte src)
        {
            src = (sbyte)(~src);
            return ref src;
        }

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte Flip(this ref byte src)
        {
            src = (byte)(~src);
            return ref src;
        }

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short Flip(this ref short src)
        {
            src = (short)(~src);
            return ref src;
        }

        /// <summary>
        /// Computes a correctly-typed twos-complement of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort Flip(this ref ushort src)
        {
            src = (ushort)(~src);
            return ref src;
        }

        /// <summary>
        /// Computes a bitwise complement of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static ref int Flip(this ref int src)
        {
            src = (~src);
            return ref src;
        }

        /// <summary>
        /// Computes a bitwise complement of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static ref uint Flip(this ref uint src)
        {
            src = (~src);
            return ref src;
        }

        /// <summary>
        /// Computes a bitwise complement of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static ref long Flip(this ref long src)
        {
            src = (~src);
            return ref src;
        }

        /// <summary>
        /// Computes a bitwise complement of the operand
        /// </summary>
        /// <param name="src">The operand</param>
        [MethodImpl(Inline)]
        public static ref ulong Flip(this ref ulong src)
        {
            src = (~src);
            return ref src;
        }

    }

}