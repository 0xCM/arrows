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

    partial class math
    {
        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref sbyte sal(ref sbyte src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte sal(ref byte src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref short sal(ref short src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref ushort sal(ref ushort src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref int sal(ref int src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint sal(ref uint src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref long sal(ref long src, int offset)
        {
            src <<= offset;
            return ref src;
        }

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong sal(ref ulong src, int offset)
        {
            src <<= offset;
            return ref src;
        }

    }

}