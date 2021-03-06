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
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static float exp(float pow)
            => MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static ref float exp(ref float pow)
        {
            pow = MathF.Exp(pow);
            return ref pow;
        }

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static double exp(double pow)
            => Math.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static ref double exp(ref double pow)
        {
            pow = Math.Exp(pow);
            return ref pow;
        }

    }

}