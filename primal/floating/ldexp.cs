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
    

    partial class fmath
    {
        /// <summary>
        /// Computes x * 2^i
        /// </summary>
        /// <param name="x">The multiplier</param>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static float ldexp(float x, int i)
            => (float)cephes.ldexp(x, i);

        /// <summary>
        /// Computes x * 2^i
        /// </summary>
        /// <param name="x">The multiplier</param>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static double ldexp(double x, int i)
            => cephes.ldexp(x, i);
    }
}