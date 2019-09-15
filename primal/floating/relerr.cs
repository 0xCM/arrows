//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class fmath
    {
        /// <summary>
        /// Computes the relative error between a one floating-point calculation and another
        /// </summary>
        /// <param name="lhs">The result of the first calculation</param>
        /// <param name="rhs">The result of the second calculation</param>
        [MethodImpl(Inline)]
        public static float relerr(float lhs, float rhs)
            => math.abs((lhs - rhs)/lhs);

        /// <summary>
        /// Computes the relative error between a one floating-point calculation and another
        /// </summary>
        /// <param name="lhs">The result of the first calculation</param>
        /// <param name="rhs">The result of the second calculation</param>
        [MethodImpl(Inline)]
        public static double relerr(double lhs, double rhs)
            => math.abs((lhs - rhs)/lhs);
        
        /// <summary>
        /// Computes the relative error between one floating-point calculation and another
        /// </summary>
        /// <param name="lhs">The result of the first calculation</param>
        /// <param name="rhs">The result of the second calculation</param>
        [MethodImpl(Inline)]
        public static float relerr(ComplexF32 lhs, ComplexF32 rhs)
        {
            var re = relerr(lhs.re, rhs.re);
            var im = relerr(lhs.im, rhs.im);
            return re > im ? re : im;
        }

        /// <summary>
        /// Computes the relative error between one floating-point calculation and another
        /// </summary>
        /// <param name="lhs">The result of the first calculation</param>
        /// <param name="rhs">The result of the second calculation</param>
        [MethodImpl(Inline)]
        public static double relerr(ComplexF64 lhs, ComplexF64 rhs)
        {
            var re = relerr(lhs.re, rhs.re);
            var im = relerr(lhs.im, rhs.im);
            return re > im ? re : im;
        }
    }
}