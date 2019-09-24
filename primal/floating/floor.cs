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
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static float floor(float src)
            => MathF.Floor(src);

        /// <summary>
        /// Computes the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static double floor(double src)
            => Math.Floor(src); 

        /// <summary>
        /// Computes in-place the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref float floor(ref float src)
        {
            src = MathF.Floor(src);
            return ref src;
        }

        /// <summary>
        /// Computes in-place the largest integral value less than or equal to the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ref double floor(ref double src)
        {
            src = Math.Floor(src); 
            return ref src;
        }

    }

}