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
        /// Computes x * 2^i
        /// </summary>
        /// <param name="x">The multiplier</param>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static float ldexp(float x, int i)
            => x * MathF.Pow(2.0f,i);

        /// <summary>
        /// Computes x * 2^i
        /// </summary>
        /// <param name="x">The multiplier</param>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static double ldexp(double x, int i)
            => x * Math.Pow(2.0, i);
    }
}