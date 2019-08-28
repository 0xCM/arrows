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
    using static AsIn;

    partial class gfp
    {
        /// <summary>
        /// Computes and returns the result r = x*y + z
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The floating point operand type</typeparam>
        [MethodImpl(Inline)]
        public static T fma<T>(T x, T y, T z)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.fma(float32(x), float32(y), float32(z)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.fma(float64(x), float64(y), float64(z)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Overwrites the first operand with the fma result, x = x*y + z
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        /// <typeparam name="T">The floating point operand type</typeparam>
        [MethodImpl(Inline)]
        public static ref T fma<T>(ref T x, in T y, in T z)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.fma(ref float32(ref x), in float32(in y), in float32(in z));
            else if(typeof(T) == typeof(double))
                fmath.fma(ref float64(ref x), in float64(in y), in float64(in z));
            else            
                throw unsupported<T>();
            return ref x;
        }

    }

}