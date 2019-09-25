//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gfp
    {
        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="src">The soruce value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline)]
        public static T exp<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fmath.exp(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fmath.exp(float64(src)));
            else
                throw unsupported<T>();
        }        

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="src">The soruce value to be overwritten by the computed value</param>
        /// <typeparam name="T">The FP type</typeparam>
        [MethodImpl(Inline)]
        public static ref T exp<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                fmath.exp(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                fmath.exp(ref float64(ref src));
            else
                throw unsupported<T>();
            return ref src;
        }         
    }

}