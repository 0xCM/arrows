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
    using System.Numerics;
    
    using static zfunc;    

    partial class math
    {
        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte abs(sbyte src)
            => (sbyte)(src + (src >> 7)^(src >> 7));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static short abs(short src)
            => (short)(src + (src >> 15)^(src >> 15));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static int abs(int src)
            => (src + (src >> 31)^(src >> 31));         

        /// <summary>
        /// Computes the absolute value of the source without branching
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static long abs(long src)
            => (src + (src >> 63)^(src >> 63));         

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float abs(float src)
            => MathF.Abs(src);

        /// <summary>
        /// Computes the absolute value of the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double abs(double src)
            => Math.Abs(src);
 
        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref sbyte abs(ref sbyte src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref short abs(ref short src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref int abs(ref int src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref long abs(ref long src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float abs(ref float src)
        {
            src = abs(src);
            return ref src;
        }

        /// <summary>
        /// Computes the absolute value of the source in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double abs(ref double src)
        {
            src = abs(src);
            return ref src;
        }

 
    }

}