//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    
    
    partial class fmath
    {
        /// <summary>
        /// Computes the cube root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float cbrt(float src)
            => MathF.Cbrt(src);

        /// <summary>
        /// Computes the cube root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double cbrt(double src)
            => Math.Cbrt(src);

        /// <summary>
        /// Computes the cube root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float cbrt(ref float src)
        {
            src = MathF.Cbrt(src);
            return ref src;
        }

        /// <summary>
        /// Computes the cube root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double cbrt(ref double src)
        {            
            src = Math.Cbrt(src);
            return ref src;
        }

    }
}