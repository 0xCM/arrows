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
        /// Computes the absolute value of a primal FP scalar
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.abs(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.abs(float64(src)));
            else
                throw unsupported<T>();
        }        

        /// <summary>
        /// Computes the absolute value of a primal FP scalar in-place
        /// </summary>
        /// <param name="src">The soruce value to be overwritten by the computed value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.abs(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.abs(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }        

    }

}