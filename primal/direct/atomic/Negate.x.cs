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
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte Negate(this ref sbyte src)
        {
            src = (sbyte) -src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref byte Negate(this ref byte src)
        {
            src = math.negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short Negate(this ref short src)
        {
            src = (short) -src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ushort Negate(this ref ushort src)
        {
            src = math.negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int Negate(this ref int src)
        {
            src = (sbyte) -src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref uint Negate(this ref uint src)
        {
            src = math.negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long Negate(this ref long src)
        {
            src = (short) -src;
            return ref src;
        }

        /// <summary>
        /// Computes the two's complement negation of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref ulong Negate(this ref ulong src)
        {
            src = math.negate(src);
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float Negate(this ref float src)
        {
            src = (sbyte) -src;
            return ref src;
        }

        /// <summary>
        /// Negates the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double Negate(this ref double src)
        {
            src = (short) -src;
            return ref src;
        }

    }

}