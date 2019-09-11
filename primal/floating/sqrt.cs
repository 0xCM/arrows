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
        
    using static As;
    using static AsIn;
    using static zfunc;

    partial class fmath
    {
        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float sqrt(float src)
            => MathF.Sqrt(src);

        /// <summary>
        /// Computes the square root of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double sqrt(double src)
            => Math.Sqrt(src); 

        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float sqrt(ref float src)
        {
            src = MathF.Sqrt(src);
            return ref src;
        }

        /// <summary>
        /// Computes the square root of the source value in-place
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double sqrt(ref double src)
        {
            src = Math.Sqrt(src);
            return ref src;
        }

        /// <summary>
        /// Computes the square root of the source and stores the result 
        /// in a specified target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline)]
        public static ref float sqrt(in float src, ref float dst)
        {
            dst = sqrt(src);
            return ref dst;
        }

        /// <summary>
        /// Computes the square root of the source and stores the result 
        /// in a specified target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline)]
        public static ref double sqrt(in double src, ref double dst)
        {
            dst = sqrt(src);
            return ref dst;
        }

    }

}