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
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        /// <summary>
        /// Computes the quotient of floating-point operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                 return generic<T>(fmath.div(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                 return generic<T>(fmath.div(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the quotient of the left and right operand and overwrites the left operand with the result
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                 fmath.div(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 fmath.div(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }
    }
}