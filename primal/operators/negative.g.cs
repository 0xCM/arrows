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

    partial class gmath
    {
        /// <summary>
        /// Determines whether a value is strictly less than zero
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static bool negative<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src) < 0;
            else if(typeof(T) == typeof(byte))
                return false;
            else if(typeof(T) == typeof(short))
                return int16(src) < 0;
            else if(typeof(T) == typeof(ushort))
                return false;
            else if(typeof(T) == typeof(int))
                return int32(src) < 0;
            else if(typeof(T) == typeof(uint))
                return false;
            else if(typeof(T) == typeof(long))
                return int64(src) < 0;
            else if(typeof(T) == typeof(ulong))
                return false;
            else if(typeof(T) == typeof(float))
                return float32(src) < 0;
            else if(typeof(T) == typeof(double))
                return float64(src) < 0;
            else            
                 throw unsupported<T>();                
       }           
    }

}